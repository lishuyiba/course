using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _192带参数的Sql语句中的一个问题
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=lenovo-pc;Initial Catalog=itcastcn;Integrated Security=True";
            using (SqlConnection con=new SqlConnection(constr))
            {
                string sql = "insert into test22 values(@age)";
                using (SqlCommand cmd=new SqlCommand(sql,con))
                {
                    //这里如果用0的话，会调用sqlparameter类的另外一个重载
                    //SqlParameter(string parameterName, SqlDbType dbType)，所以需要把0显示转换为object
                    SqlParameter p1 = new SqlParameter("@age", 0);
                    cmd.Parameters.Add(p1);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}
