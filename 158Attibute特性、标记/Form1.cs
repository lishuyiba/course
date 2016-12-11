using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _158Attibute特性_标记
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SayHi();
        }

        //标记元素
        [Obsolete("这个方法已经过时了，建议使用SayHello",true)]
        private void SayHi()
        {
            MessageBox.Show("Hi");
        }

        private void SayHello()
        {
            MessageBox.Show("Hello");
        }
    }
}
