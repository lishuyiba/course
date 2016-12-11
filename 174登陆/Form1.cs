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

namespace _174登陆
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SQL漏洞攻击
        //用户名输入" jk' or 1=1 --"就可以登陆成功.

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtLoginId.Text.Trim();
            string pwd = txtLoginPwd.Text;

            string constr = "Data Source=lenovo-pc;Initial Catalog=Itcastcn;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                #region 方法1
                string sql = string.Format("select count(*) from UserLogin where loginId='{0}' and loginPwd='{1}'", id, pwd);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    if (userCount > 0)
                    {
                        MessageBox.Show("登陆成功！");
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                    }
                } 
                #endregion

                #region 方法2

                //string sql = string.Format("select * from UserLogin where loginId='{0}' and loginPwd='{1}'", id, pwd);

                //通过执行SqlDataReader如果reader.HasRows则表示有数据，则用户登陆成功！

                #endregion
            }
        }
    }
}
