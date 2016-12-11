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

namespace _165连接字符串生成器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            propertyGrid1.SelectedObject = sqlBuilder;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sb = (SqlConnectionStringBuilder)propertyGrid1.SelectedObject;
            MessageBox.Show(sb.ConnectionString);
        }
    }
}
