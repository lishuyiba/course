using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _127UBB代码翻译器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //[font=Impact][Size=7]北京[/Size][/font][url=http://www.itcast.cn/]传智播客网[/url]
            string txtUbb = "[url=http://www.itcast.cn/]传智播客网[/url]";
            txtHtml.Text = Regex.Replace(txtUbb, @"\[[uU][rR][lL]=([a-zA-Z]+://.+?)\](.+?)\[/[uU][rR][lL]\]", "<a herf=\"$1\">$2</a>");
            //txtHtml.Text = Regex.Replace(txtUbb, @"\[[uU][rR][lL]=([a-zA-Z]+://.+?)\](.+?)\[/[uU][rR][lL]\]", "<a herf=\"$1\">$2</a>");

        }
    }
}
