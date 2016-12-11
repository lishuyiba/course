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

namespace _166Command对象的使用_insert_delete_update_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            string constr = "Data Source=LENOVO-PC;Initial Catalog=ItCastcn;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                //拼接sql插入语句
                string sql = string.Format("insert into Employees values('{0}','{1}',{2},'{3}','{4}')", txtEmpName.Text.Trim(), txtEmpGender.Text.Trim(), txtEmpAge.Text.Trim(), txtEmpEmail.Text.Trim(), txtEmpAddress.Text.Trim());
                //创建一个命令对象（Command），执行sql语句
                using (SqlCommand cmd = new SqlCommand(sql, con))//SqlCommand(sql语句,con连接对象)
                {
                    //与参数相等
                    //cmd.CommandText = sql;
                    //cmd.Connection = con;

                    //打开连接
                    con.Open();

                    //ExecuteNonQuery方法用来执行insert、delete、update语句,返回值是一个整型，表示当前语句执行后所影响的行数
                    i = cmd.ExecuteNonQuery();
                }
                MessageBox.Show("成功插入" + i + "行！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string consrt = "Data Source=LENOVO-PC;Initial Catalog=ItCastCn;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(consrt))
            {
                string sql = string.Format("delete from Employees where EmpId={0}", txtDelete.Text.Trim());
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //用之前打开，用完之后马上关闭。
                    con.Open();
                    i = cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("成功删除" + i + "行。");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            string constr = "Data Source=LENOVO-PC;Initial Catalog=ItCastCn;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = string.Format("update Employees set empname='{0}',empgender='{1}' where empid={2}", "时绿艳", "女", txtDelete.Text.Trim());
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    i = cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("成功更新" + i + "行！");
        }
    }
}
