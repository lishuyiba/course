using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _167查询表中的数据
{
    class Program
    {
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
                            while (reader.Read())//Read表示向后移动一条
                            {
                                Console.Write(reader.GetValue(0).ToString()+"\t");
                                Console.Write(reader.GetValue(1).ToString() + "\t");
                                Console.Write(reader.GetValue(2).ToString() + "\t");
                                Console.Write(reader.GetValue(3).ToString() + "\t");
                                Console.Write(reader.GetValue(4).ToString() + "\t");
                                Console.Write(reader.GetValue(5).ToString() + "\t");
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
