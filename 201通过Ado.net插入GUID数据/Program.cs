using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201通过Ado.net插入GUID数据
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=lenovo-pc;Initial Catalog=Test;Integrated Security=True";
            using (SqlConnection con=new SqlConnection(constr))
            {
                string sql = "insert into TGUID values(@g,@n)";
                using (SqlCommand cmd=new SqlCommand(sql,con))
                {
                    SqlParameter[] pms ={
                                      new SqlParameter("@g",Guid.NewGuid()),
                                      new SqlParameter("@n","赵晓虎")
                                      };
                    cmd.Parameters.AddRange(pms);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("哦了！！！！");
                    Console.ReadKey();
                }
            }
        }
    }
}
