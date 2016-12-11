using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _141自定义事件实现验证控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uerValidataControl1.UserLoginValidating += uerValidataControl1_UserLoginValidating;
        }

        void uerValidataControl1_UserLoginValidating(object sender, MyEventArgs e)
        {
            if (e.LoginId == "admin" && e.LoginPwd == "888888")
            {
                e.IsSuccess = true;
            }
        }
    }
}
