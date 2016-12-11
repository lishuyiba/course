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

namespace _188Ado.net调用存储过程
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string usp_chkLogin = "usp_chkLogin";
                using (SqlCommand cmd = new SqlCommand(usp_chkLogin,con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter[] pms = new SqlParameter[] { 
                        new SqlParameter("@uid",txtUid.Text.Trim()),
                        new SqlParameter("@pwd",txtPwd.Text)
                    };
                    cmd.Parameters.AddRange(pms);
                    con.Open();
                    int r =Convert.ToInt32( cmd.ExecuteScalar());
                    if (r>0)
                    {
                        MessageBox.Show("登陆成功");
                    }
                    else
                    {
                        MessageBox.Show("登陆失败");
                    }
                }
            }
        }
    }
}
