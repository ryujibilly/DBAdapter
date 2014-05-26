using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace DataBaseAdapter.Server
{
    /// <summary>
    /// 客户端会话信息类
    /// </summary>
    public class Client
    {
        Socket m_clientSocket;
        public Client() { }
        public Socket ClientSocket
        {
            get { return m_clientSocket; }
            set { this.m_clientSocket = value; }
        }
    }
}
