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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public WeiTuosDelegate FangFa;

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //this.Text = this.textBox1.Text;
            //获取用户输入的内容
            string userInput = this.textBox1.Text;
            //我希望，在这里当调用了UpdateTextBox()方法的时候，这个方法可以更新窗体1的文本框
            if (FangFa!=null)
            {
                FangFa(userInput);
            }           
        }

    }
}
