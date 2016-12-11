using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _141自定义事件实现验证控件
{
    public delegate void UserValidatingDelegate(object sender,MyEventArgs e);

    public partial class UerValidataControl : UserControl
    {
        public event UserValidatingDelegate UserLoginValidating;

        public UerValidataControl()
        {
            InitializeComponent();
        }

        //用户点击登陆的时候执行的代码
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //bool b = false;
            MyEventArgs eventArgs=new MyEventArgs();
            eventArgs.LoginId = txtUserId.Text.Trim();
            eventArgs.LoginPwd = txtUserPsw.Text.Trim();
            //这个属性用来控制验证是否成功！
            eventArgs.IsSuccess = false;

            UserLoginValidating(this, eventArgs);
            if (eventArgs.IsSuccess)
            {
                txtUserId.BackColor = Color.Green;
                txtUserPsw.BackColor = Color.Green;
            }
            else
            {
                txtUserId.BackColor = Color.Red;
                txtUserPsw.BackColor = Color.Red;
            }
        }
    }
    public class MyEventArgs
    {
        public string LoginId
        {
            get;
            set;
        }
        public string LoginPwd
        {
            get;
            set;
        }
        public bool IsSuccess
        {
            get;
            set;
        }
    }
}
