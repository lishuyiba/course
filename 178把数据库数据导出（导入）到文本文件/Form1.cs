using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _178把数据库数据导出_导入_到文本文件
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
                string sql = "select * from TblClass";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //判断是否有数据
                        if (reader.HasRows)
                        {
                            //如果有数据就创建文件流
                            using (StreamWriter sw = new StreamWriter("TblClass.txt"))
                            {
                                //循环每一行数据
                                while (reader.Read())
                                {
                                    //object obj1 = reader.GetValue(0);
                                    //object obj2 = reader.GetValue(1);
                                    //object obj3 = reader.GetValue(2);
                                    //string line = string.Format("{0}\n{1}\n{2}\n", obj1, obj2, obj3);

                                    #region 强类型获取

                                    //用强类型来获取可以判断数据库中某一行是否为空。
                                    int clsId = reader.GetInt32(0);
                                    string clsName = reader.GetString(1);
                                    string clsDesc = reader.IsDBNull(2) ? "NULL" : reader.GetString(2);
                                    string line = string.Format("{0},{1},{2}\n", clsId, clsName, clsDesc);

                                    #endregion

                                    //循环每一行就写入每一行
                                    sw.Write(line);
                                }
                                MessageBox.Show("数据导出完毕！");
                            }
                        }
                        //如果没有数据，则提示。
                        else
                        {
                            MessageBox.Show("表中没有数据，没有导出任何行！");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("TblClass.txt"))
            {
                string constr = "Data Source=LENOVO-PC;Initial Catalog=ItCastCn;Integrated Security=True";
                using (SqlConnection con=new SqlConnection(constr))
                {
                    string sql = "Insert into TblClass values(@clsName,@clsDesc)";
                    using (SqlCommand cmd=new SqlCommand(sql,con))
                    {

                        SqlParameter p1 = new SqlParameter("@clsName",SqlDbType.VarChar);
                        SqlParameter p2 = new SqlParameter("@clsDesc", SqlDbType.VarChar);
                        cmd.Parameters.Add(p1);
                        cmd.Parameters.Add(p2);

                        con.Open();
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] columns = line.Split(',');
                            #region 读取数据测试
                            //Console.Write(columns[0]);
                            //Console.Write(columns[1]);
                            //Console.Write(columns[2]);
                            //Console.WriteLine(); 
                            #endregion

                            #region 将数据导入到数据库中(将参数集合清空一下)

                            //SqlParameter p1 = new SqlParameter("@clsName", columns[1]);
                            //SqlParameter p2 = new SqlParameter("@clsDesc", columns[2]);
                            //cmd.Parameters.Add(p1);
                            //cmd.Parameters.Add(p2);
                            
                            //cmd.ExecuteNonQuery();

                            ////每次用完参数以后，将参数集合清空一下。
                            //cmd.Parameters.Clear();

                            #endregion

                            #region 另外一种解决参数重复问题

                            p1.Value = columns[1];
                            p2.Value = columns[2];
                            cmd.ExecuteNonQuery();

                            #endregion
                        }
                    }
                }                
            }
            MessageBox.Show("数据导入成功！");
        }
    }
}
