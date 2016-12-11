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
    public partial class frmReg : Form
    {
        public frmReg()
        {
            InitializeComponent();
        }

        private void BtnZhuCe_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.Trim();
            string realName = txtUname.Text.Trim();
            string upwd = CommonHelper.Md5Encrypt(txtPwd.Text);

            string sql = "insert into T_Seats values(@loginId,@realName,@pwd)";
            SqlParameter[] pms = new SqlParameter[] { 
            new SqlParameter("@loginId",uid),
            new SqlParameter("@realName",realName),
            new SqlParameter("@pwd",upwd)
            };
            int r = SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
            if (r>0)
            {
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("注册失败！");
            }
        }
    }
}
