using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _173IsDBNull判断列是否为空
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=LENOVO-PC;Initial Catalog=ItCastCn;Integrated Security=True";
            using (SqlConnection con=new SqlConnection(constr))
            {
                string sql = "select * from TblClass";
                using (SqlCommand cmd=new SqlCommand(sql,con))
                {
                    con.Open();
                    using (SqlDataReader reader=cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //Console.WriteLine(reader.GetValue(0));
                                //Console.WriteLine(reader.GetValue(1));
                                //Console.WriteLine(reader.GetValue(2));


                                int obj1 = reader.GetInt32(0);
                                string obj2 = reader.GetString(1);
                                //当 当前列如果为null的话，调用强类型的获取数据的方法就报错了，就需要获取数据之前做一个判断，通过Reader.IsDBNull（index）来验证。
                                string obj3 =reader.IsDBNull(2)?"空": reader.GetString(2);
                                Console.WriteLine("{0}-{1}-{2}",obj1,obj2,obj3);

                            }
                        }
                    }
                }
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
