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

namespace _206Excel上传工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel|*.xls";
            openFileDialog1.Multiselect = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                label2.Text = openFileDialog1.FileName;
            }
        }


        /// <summary>
        /// 上传数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string ip = ConfigurationManager.AppSettings["ip"];
            string uid = ConfigurationManager.AppSettings["uid"];
            string pwd = ConfigurationManager.AppSettings["pwd"];
            FtpClient fc = new FtpClient(ip, uid, pwd);
            string serverFileName = "01_" + System.DateTime.Now.ToString("yyyMMdd")+ ".xls";
            bool b = fc.Upload(new FileInfo(label2.Text.Trim()), @"Excel/" + serverFileName);
            if (b)
            {
                MessageBox.Show("上传成功！");
            }
            else
            {
                MessageBox.Show("上传失败！");
            }


        }
    }
}
