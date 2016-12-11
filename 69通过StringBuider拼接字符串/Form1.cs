using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _69通过StringBuider拼接字符串
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sbHtml = new StringBuilder();

            sbHtml.AppendLine("<html>");
            sbHtml.AppendLine("<head>");
            sbHtml.AppendLine("<title>大家好。");
            sbHtml.AppendLine("/title");
            sbHtml.AppendLine("/head");
            sbHtml.AppendLine("<body>");
            sbHtml.AppendLine("<font color=\"red\">哈哈！</font>");
            sbHtml.AppendLine("/body");
            sbHtml.AppendLine("/html");

            webBrowser1.DocumentText = sbHtml.ToString();
        }
    }
}
