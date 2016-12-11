using _197通过MD5加密登陆;
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

namespace _214通过SqlHelper实现年龄自动增长
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int autoid = Convert.ToInt32(textBox1.Text);
            string sql = "update mystudent set fage=fage+1 where fid=@pid";
            SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@pid",autoid));
            MessageBox.Show("成功！");
        }
    }
}
