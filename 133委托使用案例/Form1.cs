using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _133委托使用案例
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //在窗体2显示之前，将窗体1中的方法UpdateTextBox1赋值给窗体2种的字段FangFa；
            f2.FangFa = UpdateTextBox1;
            f2.Show();
        }

        /// <summary>
        /// 更新文本框
        /// </summary>   
        private void UpdateTextBox1(string txt)
        {
            this.textBox1.Text = txt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
