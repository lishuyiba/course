using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _197通过MD5加密登陆
{
    public partial class frmChangePwd : Form
    {
        public frmChangePwd()
        {
            InitializeComponent();
        }

        private void frmChangePwd_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + "-" + GlobalHelper.realName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.验证两次输入的新密码是否一致
            if (txtNewPwd.Text == txtNewPwdAgain.Text)
            {
                //表示新密码一致
                //验证用户输入的密码是否正确
                string sql = "select count(*) from t_seats where autoid=@autoid and loginpwd=@pwd";
                SqlParameter[] pms = new SqlParameter[] { 
                    new SqlParameter("@autoid",GlobalHelper.currentId),
                    new SqlParameter("@pwd",CommonHelper.Md5Encrypt( txtOldPwd.Text)),
                };
                int r = Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text, pms));
                if (r > 0)
                {
                    string updateSql = "update t_seats set loginpwd=@pwd where autoid=@autoid";
                    SqlParameter[] sqPms = new SqlParameter[] { 
                                            new SqlParameter("@pwd",CommonHelper.Md5Encrypt( txtNewPwd.Text)),
                                            new SqlParameter("@autoid",GlobalHelper.currentId)
                                            };
                    int r_update = Convert.ToInt32(SqlHelper.ExecuteNonQuery(updateSql, CommandType.Text, sqPms));
                    if (r_update > 0)
                    {
                        MessageBox.Show("密码修改成功！");
                    }
                    else
                    {
                        MessageBox.Show("密码修改失败！");
                    }                    
                }
                else
                {
                    MessageBox.Show("输入的旧密码不正确！");
                }
            }
            else
            {
                MessageBox.Show("输入两次密码不一样！");
            }


            //2.验证用户输入的旧密码是否正确



            //3.如果正确则执行update修改密码


        }
    }
}
