using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _202关于sp_reset_connection存储过程
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=lenovo-pc;Initial Catalog=ItCastCn;Integrated Security=True";

            //获取类型中的私有成员
            PropertyInfo pInfo = typeof(SqlConnection).GetProperty("InnerConnection", BindingFlags.NonPublic | BindingFlags.Instance);

            object obj1 = null;
            object obj2 = null;

            using (SqlConnection con=new SqlConnection(constr))
            {
                //获取第一个con中的InnerConnection属性的值。
                obj1 = pInfo.GetValue(con, null);

                con.Open();
                using (SqlCommand cmd=new SqlCommand("select * from TblStudent",con))
                {
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            Console.WriteLine("=================================OK====================================");
            using (SqlConnection con = new SqlConnection(constr))
            {

                //获取第二个con中的InnerConnection属性的值。
                obj2 = pInfo.GetValue(con,null);

                con.Open();
                using (SqlCommand cmd = new SqlCommand("select * from TblStudent", con))
                {
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            Console.WriteLine("=================================OK====================================");

            //比较obj1和obj2
            #region Equals 这种比较方法不准确，因为Equals可以被重写
            //if (obj1.Equals(obj2))
            //{
            //    Console.WriteLine("相同对象");
            //}
            //else
            //{
            //    Console.WriteLine("不相同对象");
            //} 
            #endregion


            #region ReferenceEquals 用这种方法比较
            if (object.ReferenceEquals(obj1, obj2))
            {
                Console.WriteLine("相同对象");
            }
            else
            {
                Console.WriteLine("不相同对象");
            }  
            #endregion


            Console.ReadKey();
        }
    }
}
