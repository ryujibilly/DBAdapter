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

namespace DataBaseAdapter.Server
{
    /// <summary>
    /// TCP服务器，接受中转程序连接
    /// </summary>
    public class TCPServer
    {

        ISQLPool isqlpool1 = SQLPool.sqlPool1;
        ISQLPool isqlpool2 = SQLPool.sqlPool2;
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
        /// 构造函数 
        /// </summary>
        /// <param name="portNum">端口</param>
        public TCPServer(string serverIP,int portNum)
        {
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
        void RecvThreadFunc()
        {
            Trace.WriteLine("TCPServer县城启动！");
            byte[] receivedBuffer = new byte[65535];
            while(IsContinue)
                try
                {
                    CurrClientSocket = ServerSocket.Accept();
                    Trace.WriteLine(string.Format("客户端{0}已经连接！", ((IPEndPoint)CurrClientSocket.RemoteEndPoint).Address.ToString()));
                    CurrClientSocket.Send(ASCIIEncoding.ASCII.GetBytes("Server OK,YOU CAN SEND WITSData!"));
                    while(IsContinue)
                    {

                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }
        }
        /// <summary>
        /// 数据库线程主函数
        /// </summary>
        void ProcThreadFunc()
        {

        }

    }
}
