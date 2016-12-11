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

namespace _185通过SqlHelper实现增删查改
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clsName = textBox1.Text.Trim();
            string clsDesc = textBox2.Text.Trim();

            string sql = "insert into TblClass values(@name,@desc)";

            SqlParameter[] pm = new SqlParameter[]{
            new SqlParameter("@name",clsName),
            new SqlParameter("@desc",clsDesc)
            };

            int r = SqlHelper.ExecuteNonQuery(sql, pm);
            MessageBox.Show("成功插入" + r + "行。");
        }
    }
}
