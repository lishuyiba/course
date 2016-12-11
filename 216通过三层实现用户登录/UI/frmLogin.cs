using _216通过三层实现用户登录.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _216通过三层实现用户登录.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.Trim();
            string pwd = txtPwd.Text;
            TSeatsBll bll = new TSeatsBll();
            int autoId;
            string realName;
            LoginResult result = bll.UserLoginValidate(uid, pwd,out autoId,out realName);
            if (result==LoginResult.UserNotExists)
            {
                MessageBox.Show("用户名不存在！");
            }
            else if(result==LoginResult.ErrorPassword)
            {
                MessageBox.Show("密码错误！");
            }
            else
            {
                //当前登录成功以后记录当前用户autoId与真实姓名
                GlobalHelper.currentId = autoId;
                GlobalHelper.realnName = realName;
                label3.Text = "欢迎：" + realName;
                //this.Text ="当前登录-"+ realName;
                button1.Enabled = true;
                MessageBox.Show("登录成功！");                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPasswordEdit pwd = new frmPasswordEdit();
            pwd.Show();
        }
    }
}
