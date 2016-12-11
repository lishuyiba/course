using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _169ExecuteScalar方法使用
{

    //获取insert插入语句返回自动编号
    //insert into TblClass values('黑马四期','正在热招中...');select @@identity
    
    //insert into TblClass output inserted.tclassid values('黑马五期','正在热招中...')
    //执行任何sql语句其实调用Command对象的ExecuteNonQuery()、ExecuteScalar()、ExecuteReader()都可以，只不过是执行对应的语句如果选择对了方法会使用起来更合适。

    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=LENOVO-PC;Initial Catalog=ItCastCn;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                //string sql = "select * from TblClass";
                string sql = "select tClassName,tClassDesc from TblClass";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    //int obj =Convert.ToInt32( cmd.ExecuteScalar());//结果：1
                    object obj = cmd.ExecuteScalar();//结果：黑马二期
                    Console.WriteLine(obj);
                }
            }
            Console.ReadKey();
        }
    }
}
