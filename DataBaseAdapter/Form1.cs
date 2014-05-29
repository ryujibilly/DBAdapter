using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseAdapter.Server;

namespace DataBaseAdapter
{
    public partial class Form1 : Form
    {
        public Random random = new Random();
        public TCPServer tcpserver;
        private int progressValue;
        /// <summary>
        /// 本机IPv4/v6
        /// </summary>
        string[] HostAddresses { get; set; }
        private int errorTimes = 0;
        /// <summary>
        /// 数据库服务器IP地址
        /// </summary>
        private string ipAddress { get; set; }
        /// <summary>
        /// 数据库服务器端口号
        /// </summary>
        private string PortNumber { get; set; }
        /// <summary>
        /// 数据库用户
        /// </summary>
        private string User { get; set; }
        /// <summary>
        /// 数据库密码
        /// </summary>
        private string Password { get; set; }

        /// <summary>
        /// 数据库名字
        /// </summary>
        private string DBase { get; set; }


        public string errorLog = Application.StartupPath + "\\errorLog.wits";
        public string OriginLog = Application.StartupPath + "\\OriginLog.wits";
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] HostAddresses = GetLocalAddresses();
            vComboBox1.Items.Clear();
            if(HostAddresses.Length>0)
            {
                for (int i = 0; i < HostAddresses.Length; i++)
                    vComboBox1.Items.Add(HostAddresses[i]);
            }
            vComboBox1.Text = vComboBox1.Items[0].Text;
            vTextBox1.Text = "9001";
            vTextBox2.Text = errorTimes.ToString();
            this.StopButton.Enabled = false;
            this.User = "sa";
            this.Password = "123456";
            timer1.Enabled = false;
            
        }

        /// <summary>
        /// 获取本机地址列表
        /// </summary>
        public string[] GetLocalAddresses()
        {
            // 获取主机名
            string strHostName = Dns.GetHostName();

            // 根据主机名进行查找
            IPHostEntry iphostentry = Dns.GetHostEntry(strHostName);

            string[] retval = new string[iphostentry.AddressList.Length];

            int i = iphostentry.AddressList.Length;
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                retval[i - 1] = ipaddress.ToString();
                i--;
            }
            return retval;
        }

        public bool IsInteger(string s)
        {
            string pattern = @"^\d*$";
            return Regex.IsMatch(s, pattern);
        }

        /// <summary>
        /// 字节流数据打包为WITSData
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        //public WITSData Convert(string[] data)
        //{
        //    WITSData witsData = new WITSData();
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        try
        //        {
        //            if (data[i].Length >= 2 && data[i].Substring(0, 2) == "??")
        //            {
        //                DBase = data[i].Substring(2);//接受工程名 
        //                this.sqlConnection1 = new SqlConnection("server=" + m_serverIP + ";Initial Catalog="
        //                    + DBase + ";Persist Security Info=True;User ID=" + User + ";Password=" + Password);
        //                if (sqlConnection1.State != ConnectionState.Open)
        //                {
        //                    sqlConnection1.Open();
        //                    this.AddRunningInfo(">> " + DateTime.Now.ToString() + " SqlServer[" + m_serverIP + "] connected.----Receiving Thread");
        //                }
        //                ad1.setConStr(m_serverIP, User, Password, DBase);
        //                ad2.setConStr(m_serverIP, User, Password, DBase);
        //                ad1.sqlCon = sqlConnection1;
        //                ad2.sqlCon = sqlConnection1;
        //                ad1.sqlCon1 = sqlConnection1;
        //                ad2.sqlCon1 = sqlConnection1;

        //                this.sqlConnection2 = new SqlConnection("server=" + m_serverIP + ";Initial Catalog="
        //                    + DBase + ";Persist Security Info=True;User ID=" + User + ";Password=" + Password);
        //                if (sqlConnection2.State != ConnectionState.Open)
        //                {
        //                    sqlConnection2.Open();
        //                    button1.Enabled = false;
        //                    this.AddRunningInfo(">> " + DateTime.Now.ToString() + " SqlServer[" + m_serverIP + "] connected.----Processing Thread");
        //                }
        //                ad1.sqlCon2 = sqlConnection2;
        //                ad1.databases = ad1.databaseList();
        //                ad1.createSQLPool(sqlConnection1, DBase, 1);
        //                ad1.createSQLPool(sqlConnection2, DBase, 2);
        //                ad2.sqlCon2 = sqlConnection2;
        //                ad2.databases = ad2.databaseList();
        //                ad2.createSQLPool(sqlConnection1, DBase, 1);
        //                ad2.createSQLPool(sqlConnection2, DBase, 2);
        //                continue;
        //            }
        //            if (data[i].Length >= 2 && data.Length > 4)
        //            {
        //                witsData.RecordID[i] = int.Parse(data[i].Substring(0, 2));
        //                witsData.ItemID[i] = int.Parse(data[i].Substring(2, 2));
        //                witsData.Data[i] = data[i].Substring(4);
        //                witsData.DataLength = data.Length;

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            errorTimes++;
        //            Debug.WriteLine(ex.Message + "Convert函数解包出错!data[" + i + "]=" + data[i].ToString());
        //            textBox7.Text = errorTimes.ToString();
        //            swErrorWits.WriteLine("ErrorData[" + errorTimes + "]--->>>>" + data[i] + "<<<<");
        //            continue;
        //        }
        //    }
        //    if (data.Length < 2)
        //        witsData.DataLength = 0;
        //    return witsData;
        //}
        public string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(System.Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }

        /// <summary>
        /// 将运行信息加入显示列表
        /// </summary>
        private void AddRunningInfo(string message)
        {
            lstRunningInfo.BeginUpdate();
            lstRunningInfo.Items.Insert(message, 0);
            if (lstRunningInfo.Items.Count > 500)
            {
                lstRunningInfo.Items.RemoveAt(500);
            }
            lstRunningInfo.EndUpdate();
        }

        /// <summary>
        /// 开启TCPServer 侦听9001端口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();
            if(IsInteger(vTextBox1.Text.Trim()))
            {
                TCPServer tcpserver = new TCPServer(vComboBox1.Text.Trim(),int.Parse(vTextBox1.Text));
                tcpserver.Start();
                this.StartButton.Enabled = false;
                this.StopButton.Enabled = true;
                this.vComboBox1.Enabled = false;
                this.vTextBox1.Enabled = false;
                this.vTextBox2.Enabled = false;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            tcpserver.Stop();
            this.StartButton.Enabled = true;
            this.StopButton.Enabled = false;
            this.vComboBox1.Enabled = true;
            this.vTextBox1.Enabled = true;
            this.vTextBox2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vCircularProgressBar1.Value = random.Next(100);
        }

        void RecvFunc()
        {
        }
    }
}
