using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191通过Ado.net实现事务
{
    class Program
    {
        //复习：
        //开打事务
        //begin tran

        //结束事务
        //1.commit
        //2.rollback


        static void Main(string[] args)
        {
            string constr = "Data Source=lenovo-pc;Initial Catalog=ItCastCn;Integrated Security=True";
            using (SqlConnection con=new SqlConnection(constr))
            {
                con.Open();
                string sql = "delete from tblstudent where stuId=4";
                //通过Connection创建一个事物对象
                SqlTransaction tran = con.BeginTransaction();                
                using (SqlCommand cmd=new SqlCommand(sql,con))
                {
                    cmd.Transaction = tran;
                    int r = cmd.ExecuteNonQuery();
                    Console.WriteLine("所影响的行数{0}",r);
                    //回滚事务。
                    tran.Rollback();
                    Console.WriteLine("回滚了。");
                    //提交事务。
                    //tran.Commit();
                    //Console.WriteLine("提交了。");                    
                }
            }
            Console.ReadKey();
        }
    }
}
