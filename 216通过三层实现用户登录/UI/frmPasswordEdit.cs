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
    public partial class frmPasswordEdit : Form
    {
        public frmPasswordEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string OldPwd = txtOldPwd.Text;
            string newPwd = txtNewPwd.Text;
            string newPwd1 = txtNewPwd2.Text;

            TSeatsBll bll = new TSeatsBll();
            ChangePasswprdResult result = bll.ChangePassword(GlobalHelper.currentId,OldPwd,newPwd,newPwd1);
            switch (result)
            {
                case ChangePasswprdResult.NullValue:
                    MessageBox.Show("必填字段必须填！");
                    break;
                case ChangePasswprdResult.DiffPwd:
                    MessageBox.Show("两次输入的密码不一样！");
                    break;
                case ChangePasswprdResult.OldPwdError:
                    MessageBox.Show("旧密码不对！");
                    break;
                case ChangePasswprdResult.OK:
                    MessageBox.Show("修改成功！");
                    break;
                case ChangePasswprdResult.Failed:
                    MessageBox.Show("修改失败！");
                    break;
            }
            

        }
    }
}
