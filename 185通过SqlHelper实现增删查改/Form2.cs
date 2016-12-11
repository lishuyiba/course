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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql="select * from TblClass";
            string constr="Data Source=lenovo-pc;Initial Catalog=ItCastCn;Integrated Security=True";
            //DataTable dt= SqlHelper.ExecuteDataTable(sql, null);            
            //dataGridView1.DataSource = dt;

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, constr);
            DataTable dt = new DataTable();

            sqlAdapter.Fill(0, 10, dt);
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select * from TblClass";
            string constr = "Data Source=lenovo-pc;Initial Catalog=ItCastCn;Integrated Security=True";
            //DataTable dt= SqlHelper.ExecuteDataTable(sql, null);            
            //dataGridView1.DataSource = dt;

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, constr);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(11, 20, dt);
            dataGridView1.DataSource = dt;


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select * from TblClass";
            string constr = "Data Source=lenovo-pc;Initial Catalog=ItCastCn;Integrated Security=True";
            //DataTable dt= SqlHelper.ExecuteDataTable(sql, null);            
            //dataGridView1.DataSource = dt;

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, constr);
            DataTable dt = new DataTable();

            sqlAdapter.Fill(0, 10, dt);
            dataGridView1.DataSource = dt;


        }
    }
}
