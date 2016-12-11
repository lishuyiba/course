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

namespace _177使用带参数的sql语句避免注入攻击
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=LENOVO-PC;Initial Catalog=ItCastCn;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select count(*) from UserLogin where LoginId=@uid and LoginPwd=@pwd";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //位变量@uid与pwd赋值

                    #region Command对象增加参数 方法一
                    //cmd.Parameters.AddWithValue("@uid", txtLoginId.Text.Trim());
                    //cmd.Parameters.AddWithValue("@pwd", txtLoginPwd.Text); 
                    #endregion


                    #region Command对象增加参数 方法二(创建对象)

                    //SqlParameter p1 = new SqlParameter("@uid", txtLoginId.Text.Trim());
                    //cmd.Parameters.Add(p1);

                    //SqlParameter p2 = new SqlParameter("@pwd", txtLoginPwd.Text);
                    //cmd.Parameters.Add(p2);


                    #endregion

                    #region Command对象增加参数 方法三（数组）

                    SqlParameter[] pms = new SqlParameter[]{
                    new SqlParameter("@uid",txtLoginId.Text.Trim()),
                    new SqlParameter("@pwd",txtLoginPwd.Text)
                    };
                    cmd.Parameters.AddRange(pms);

                    #endregion


                    con.Open();
                    int r = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    if (r > 0)
                    {
                        MessageBox.Show("登陆成功！");
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                    }
                }
            }
        }
    }
}
