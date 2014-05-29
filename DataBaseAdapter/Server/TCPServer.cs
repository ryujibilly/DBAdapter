using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.Windows.Forms;
using System.IO;

namespace DataBaseAdapter.Server
{
    /// <summary>
    /// TCP服务器，接受中转程序连接
    /// </summary>
    public class TCPServer
    {
        public ConcurrentQueue<WITSData> bagQueue = new ConcurrentQueue<WITSData>();
        public SqlConnection SqlCon1 = new SqlConnection();
        public SqlConnection SqlCon2 = new SqlConnection();
        public WITSData result = new WITSData();
        public Client client = new Client();
        ISQLPool isqlpool1 = SQLPool.sqlPool1;
        ISQLPool isqlpool2 = SQLPool.sqlPool2;
        Decode decode = null;
        /// <summary>
        /// socket接收端口
        /// </summary>
        private int ServerPort = 9002;
        private string ServerIP = "10.242.100.83";
        
        /// <summary>
        /// 服务器IP
        /// </summary>
        private string ServerHostName=null;

        /// <summary>
        /// 服务器socket
        /// </summary>
        private Socket ServerSocket = null;

        /// <summary>
        /// 接收线程
        /// </summary>
        private Thread RecvThread = null;
        private Thread ProcThread = null;
        /// <summary>
        /// 当前客户端
        /// </summary>
        private Socket CurrClientSocket = null;

        /// <summary>
        /// 
        /// </summary>
        private object ClientSocketAsynObj = new object();

        /// <summary>
        /// 接受字节数
        /// </summary>
        private UInt16 RecvCount = 0;

        /// <summary>
        /// 是否开始接受
        /// </summary>
        private bool IsStartRecv = false;

        /// <summary>
        /// 接受wits数据字节数组
        /// </summary>
        private byte[] receiveBuffer = new byte[40960];

        /// <summary>
        /// 是否继续接收线程
        /// </summary>
        private bool IsContinue = true;

        /// <summary>
        /// 数据库名字
        /// </summary>
        private string DBase { get; set; }

        public string[] separator = new string[] { "&&", "\r", "\n" };
        public string[] endTag = new string[] { "!!" };
        private string[] witsPackets;
        private string[] PacketData;
        private string conString = null;
        private WITSData witsData;
        private FileStream fsLogWits;
        private StreamWriter swLogWits;
        private FileStream fsErrorWits;
        private StreamWriter swErrorWits;

        public int DLen;
        public int receiveDataLength;
        public int DgramNum = 0;
        public int ProcDgramNum = 0;
        //是否写文件
        public bool isWriteFile;
        public bool socketOn = true;
        public bool o = false, k = false;


        public delegate void RecvThreadDelegate(Client client);

        RecvThreadDelegate receiveThreadDelegate;

        private void ReceiveThreadCallback(IAsyncResult AR)
        {
            receiveThreadDelegate.EndInvoke(AR);
        }
        /// <summary>
        /// 构造函数 
        /// </summary>
        /// <param name="portNum">端口</param>
        public TCPServer(string serverIP,int portNum)
        {
            this.decode = new Decode(SqlCon1);
            this.ServerPort = portNum;
            this.ServerIP = serverIP;
            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse(serverIP), portNum);
            RecvThread = new Thread(new ThreadStart(RecvThreadFunc));
            ProcThread = new Thread(new ThreadStart(ProcThreadFunc));
        }

        /// <summary>
        /// TCP服务启动
        /// </summary>
        /// <returns></returns>
        public bool Start()
        {
            bool bRet = false;
            try
            {
                IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, ServerPort);
                ServerSocket.Bind(localEndPoint);
                ServerSocket.Listen(10);
                RecvThread.Start();
                ProcThread.Start();
                bRet = true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("TcpServer::Start->" + ex.Message);
                bRet = false;
            }
            return bRet;
        }

        /// <summary>
        /// TCP服务终止
        /// </summary>
        public void Stop()
        {
            IsContinue = false;

            try
            {
                if (ServerSocket != null)
                {
                    ServerSocket.Close();
                }
            }
            catch { }
            try
            {

                if (RecvThread != null)
                {
                    RecvThread.Abort();
                }
            }
            catch { }
            try
            {
                if (ProcThread != null)
                {
                    ProcThread.Abort();
                }
            }
            catch { }
        }
        /// <summary>
        /// 接收数据线程主函数
        /// </summary>
        public void RecvThreadFunc()
        {
            while(IsContinue)
            {
                try 
                {
                    Thread.Sleep(5);
                    client.ClientSocket = CurrClientSocket;
                    CurrClientSocket = ServerSocket.Accept();
                    receiveThreadDelegate = new RecvThreadDelegate(RecvFunc);
                    receiveThreadDelegate.BeginInvoke(client, ReceiveThreadCallback,ClientSocketAsynObj);
                    if (!IsStartRecv) break;
                }
                catch(Exception ex)
                {                    
                    Trace.WriteLine("接收线程::出错-->~"+ex.Message);
                }
            }
        }
        public void RecvFunc(Client client)
        {
            try
            {
                while (IsContinue)
                {
                    Thread.Sleep(5);
                    receiveBuffer = new byte[40960];
                    client.ClientSocket.Receive(receiveBuffer);
                    string strReceiveData = Encoding.Default.GetString(receiveBuffer);
                    if (!string.IsNullOrEmpty(strReceiveData))
                    {
                        strReceiveData = strReceiveData.TrimEnd('\0');
                        swLogWits.Write(strReceiveData);
                        witsPackets = strReceiveData.Split(endTag, StringSplitOptions.RemoveEmptyEntries);
                        int numOfPackets = witsPackets.Length;
                        DgramNum += numOfPackets;
                        receiveDataLength += strReceiveData.Length;
                        for (int i = 0; i < numOfPackets; i++)
                        {
                            PacketData = witsPackets[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
                            witsData = decode.Convert(PacketData);
                            bagQueue.Enqueue(witsData);
                        }
                        Trace.WriteLine(">> Receive data from [" + client.ClientSocket.RemoteEndPoint.ToString() + "]:"
                            + "Packet(s) of " + numOfPackets + ",Packets length is " + strReceiveData.Length.ToString() + "Bytes");
                    }
                    if (!IsContinue) break;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message + "--------------------bagQuene.Count=" + bagQueue.Count);
            }
        }
        /// <summary>
        /// 数据库线程主函数
        /// </summary>
        public void ProcThreadFunc()
        {
            while (true)
            {
                try
                {
                    if (bagQueue.TryDequeue(out result))
                    {
                        o = isqlpool1.InsertWitsData(SqlCon1, DBase,ref result);
                        k = isqlpool2.InsertIntoTable(SqlCon1,SqlCon2, DBase,ref result);
                        if (o && k)
                            Trace.WriteLine(">>> Insert data into database successfully!----" + DateTime.Now.ToLongTimeString());
                        else if (result.RecordID[0] == 0)
                            Trace.WriteLine(">>> Connect database" + DBase + " successfully!----" + DateTime.Now.ToLongTimeString());
                        else
                        {
                            Trace.WriteLine(">>> Insert data into database failed!----" + DateTime.Now.ToLongTimeString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message + "----处理线程异常！");
                }
            }
        }

    }
}
