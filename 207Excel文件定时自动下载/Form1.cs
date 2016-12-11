using Lvl.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _207Excel文件定时自动下载
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "开始下载...";
            string ip = ConfigurationManager.AppSettings["ip"];
            string uid = ConfigurationManager.AppSettings["uid"];
            string pwd = ConfigurationManager.AppSettings["pwd"];
            FtpClient fc = new FtpClient(ip,uid,pwd);            
            string serverFileName = "01_" + System.DateTime.Now.ToString("yyyyMMdd") + ".xls";
            //string serverFileName = "01_20140905.xls";
            //serverFileName = "Excel/" + serverFileName;
            fc.RemotePath = "excel";
            //下载之前判断一下文件是否存在！D:\FTPServerDir\Excel（判断文件是否存在发生错误，没写！！！！）
            bool b = fc.Download(serverFileName, @"D:\ItCastCnDir\01_20140905下载.xls");
            if (b)
            {
                //MessageBox.Show("下载成功！");
                //Application.Exit();
                label1.Text = "下载成功！";
            }
            else
            {
                MessageBox.Show("下载失败！");
            }

            #region 旧代码
            //if (fc.CheckFileExist(serverFileName))
            //{
            //    bool b = fc.Download(serverFileName, @"D:\ItCastCnDir\01_20140905下载.xls");
            //    if (b)
            //    {
            //        MessageBox.Show("下载成功！");
            //    }
            //    else
            //    {
            //        MessageBox.Show("下载失败！");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("服务器上暂无文件，请联系01分店！");
            //} 
            #endregion

        }
    }
}
