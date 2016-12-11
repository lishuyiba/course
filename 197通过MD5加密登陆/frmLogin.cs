using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _197通过MD5加密登陆
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
            string pwd = CommonHelper.Md5Encrypt(txtPwd.Text);

            #region 普通登陆
            //string sql = "select count(*) from T_Seats where loginId=@uid and loginpwd=@pwd";
            //SqlParameter[] pms = new SqlParameter[] { 
            //new SqlParameter("@uid",uid),
            //new SqlParameter("@pwd",pwd)
            //};
            //int r=Convert.ToInt32( SqlHelper.ExecuteScalar(sql, CommandType.Text, pms));
            //if (r>0)
            //{
            //    MessageBox.Show("登陆成功！");
            //}
            //else
            //{
            //    MessageBox.Show("用户名或密码错误！");
            //} 
            #endregion

            string sql = "select * from T_Seats where loginId=@uid";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, new SqlParameter("@uid", uid)))
            {
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        string upwd = reader.GetString(3);
                        if (upwd==pwd)
                        {
                            //如果登陆成功，则记录当前用户的主键id和真实姓名
                            GlobalHelper.currentId = reader.GetInt32(0);
                            GlobalHelper.realName = reader.GetString(2);
                            BtnChangePassword.Enabled = true;
                            MessageBox.Show("登陆成功！");
                        }
                        else
                        {
                            MessageBox.Show("密码错误！");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("用户不存在！");
                }
            }



        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePwd change = new frmChangePwd();
            change.Show();
        }
    }
}
