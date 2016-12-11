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

namespace _168增删查改
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbnAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            string constr = "Data Source=LENOVO-PC;Initial Catalog=ItCastCn;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql =string.Format( "insert into TblClass values('{0}','{1}')",txtName.Text.Trim(),txtDesc.Text.Trim());
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    i = cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("成功插入" + i + "行。");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=LENOVO-PC;Initial Catalog=ItCastCn;Integrated Security=True";
            //对于连接对象,如果写在了using语句里面，则即便发生了异常
            //当using语句退出的时候也会调用Dispose()方法，所以也会释放资源
            //所以可以在using中使用连接对象，而不用Try-Catch
            using (SqlConnection con=new SqlConnection(constr))
            {
                string sql = "select * from TblClass";
                using (SqlCommand cmd=new SqlCommand(sql,con))
                {
                    con.Open();//可能发生异常
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())//可能发生异常
                        {
                            //在Reader使用过程当中必须保证Connection是打开状态
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Console.Write(reader.GetValue(0));
                                    Console.Write(reader.GetValue(1));
                                    Console.WriteLine();//输出换行
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("发生了异常！");
                    }
                }
            }
        }
    }
}
