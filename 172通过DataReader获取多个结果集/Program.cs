using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _172通过DataReader获取多个结果集
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=LENOVO-PC;Initial Catalog=ItCastCn;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select * from Employees;select * from TblClass";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        #region 读取一个结果集
                        //if (reader.HasRows)
                        //{
                        //    while (reader.Read())
                        //    {
                        //        for (int i = 0; i < reader.FieldCount; i++)
                        //        {
                        //            Console.Write(reader.GetValue(i));
                        //        }
                        //        Console.WriteLine();
                        //    }
                        //} 
                        #endregion

                        #region 读取多个结果

                        do
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        string dbType = reader.GetDataTypeName(i);
                                        switch (dbType)
                                        {
                                            case"varchar":
                                            case"nvarchar":
                                            case"char":
                                            case"nchar":
                                                Console.Write(reader.GetValue(i)+"\t");
                                                break;
                                            case"int":
                                                Console.Write(reader.GetValue(i)+"\t");
                                                break;
                                        }
                                    }
                                }
                            }
                            
                        } while (reader.NextResult());//当多个结果集的时候可以调用NextResult

                        #endregion
                    }
                }
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
