using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// <summary>
        /// socket接收端口
        /// </summary>
        private int ServerPort = 9002;
        
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

        /// <summary>
        /// 当前客户端
        /// </summary>
        private Socket CurrClientSocket = null;

        /// <summary>
        /// 
        /// </summary>
        private object ClientSocketAsynObj = new object();

        /// <summary>
        /// 接收定时器
        /// </summary>
        private MMTimer RecvTimer = null;

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
        public TCPServer(int portNum)
        {
            this.ServerPort = portNum;
            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            RecvThread = new Thread(new ThreadStart(RecvThreadFunc));
            RecvTimer = new MMTimer(this.SendTimerFunc);
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
                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, ServerPort);
                ServerSocket.Bind(ipEnd);
                ServerSocket.Listen(10);
                RecvThread.Start();
                RecvTimer.Start(1000, true);
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
                if (RecvTimer != null)
                {
                    RecvTimer.Stop();
                }
            }
            catch { }
        }

        internal void RecvThreadFunc()
        {

        }

        internal void SendTimerFunc(uint uTimerID,uint uMsg,UIntPtr dwUser,UIntPtr dw1,UIntPtr dw2)
        {

        }

    }
}
