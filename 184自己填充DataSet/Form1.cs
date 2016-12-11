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

namespace _184自己填充DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=lenovo-pc;Initial Catalog=ItCastCn;Integrated Security=True";
            string sql = "select * from TblStudent";

            //SqlDataAdapter内部封装了SqlConnection、SqlCommand、SqlDataReader
            SqlDataAdapter adapter = new SqlDataAdapter(sql, constr);

            #region MyRegion
            //DataSet ds = new DataSet();
            //adapter.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0]; 
            #endregion


            //适配器（把数据转换）
            #region 使用SqlDataAdapter分页

            DataTable dt = new DataTable();//创建一个临时表
            adapter.Fill(0,10,dt);//从0开始读取10条，放到dt表
            dataGridView1.DataSource = dt;//把dt表作为DataGridView表的数据源

            #endregion



        }
    }
}
