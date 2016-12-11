using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171DataReader里面reader获取值的两种方式
{
    class Program
    {

        //1.GetValue
        //2.Reader索引器
        //3.Get强类型GetInt、GetString
        //4.根据索引来获取数据

        static void Main(string[] args)
        {
            string constr = "Data Source=LENOVO-PC;Initial Catalog=ItCastCn;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select * from Employees";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //根据索引来获取数据，而不要根据列名(lie)获取数据
                            int c1 = reader.GetOrdinal("lie1");
                            int c2 = reader.GetOrdinal("lie2");

                            while (reader.Read())//Read表示向后移动一条
                            {
                                #region GetValue与Reader索引器
                                ////第一种：通过GetValues(0)编号获取
                                ////Console.Write(reader.GetValue(0).ToString() + "\t");
                                ////Console.Write(reader.GetValue(1).ToString() + "\t");
                                ////Console.Write(reader.GetValue(2).ToString() + "\t");
                                ////Console.Write(reader.GetValue(3).ToString() + "\t");
                                ////Console.Write(reader.GetValue(4).ToString() + "\t");
                                ////Console.Write(reader.GetValue(5).ToString() + "\t");

                                ////第二种：通过GetValues索引器下标获取（返回值永远都是object类型）
                                ////string columnName = "EmpGender";

                                //string columnName = "EmpName";
                                ////先根据列名获取索引，然后再根据索引调用GetValue()
                                //int index = reader.GetOrdinal(columnName);
                                //Console.WriteLine(reader.GetValue(index)); 
                                #endregion


                                #region Reader使用强类型来获取数据

                                //一般如果没有特殊情况建议使用索引来获取信息，不要使用列名（效率低下）
                                int EmpId = reader.GetInt32(0);
                                string EmpName = reader.GetString(1);

                                //数据库种float，这里得用GetDouble()获取
                                //reader.GetDouble(); 

                                //这样写效率低下
                                //object obj1 = reader["lie1"];
                                //object obj2 = reader["lie2"];

                                //在循环外面根据列名先计算出索引
                                //然后在循环里面还是使用索引。
                                object obj1=reader[c1];
                                object obj2 = reader[c2];


                                Console.WriteLine(EmpId);
                                Console.WriteLine(EmpName);
                                #endregion

                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
