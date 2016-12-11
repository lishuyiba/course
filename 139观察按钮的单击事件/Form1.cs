using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _139观察按钮的单击事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //这个就相当于是委托指向的那个方法
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("按钮被单击了！");
        }
    }
}
