using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170执行插入语句返回自动编号
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=LENOVO-PC;Initial Catalog=ItCastCn;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = string.Format("insert into TblClass output inserted.tclassid values('{0}','{1}')", "黑马6期", "太遥远了。。。");
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    
                    //这个类型转换叫做“拆箱”，如果装箱时不是int类型，就报错。
                    //int obj = (int)cmd.ExecuteScalar();object --> int 显示转换

                    //推荐使用下面这种类型转换。适用范围更广一些，这种转换可以把"9"转换为int类型。
                    int obj = Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine(obj);
                }
            }
            Console.ReadKey();
        }
    }
}
