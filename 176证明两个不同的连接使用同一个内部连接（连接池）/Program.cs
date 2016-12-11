using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _176证明两个不同的连接使用同一个内部连接_连接池_
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "Data Source=lenovo-pc;Initial Catalog=ItCastCn;Integrated Security=True";

            //通过反射获取内部的私有成员“InnerConnection”
            PropertyInfo pinfo = typeof(SqlConnection).GetProperty("InnerConnection", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);


            SqlConnection con1 = new SqlConnection(constr);
            object obj1 = null;
            object obj2 = null;

            using (con1)
            {
                con1.Open();
                //获取第一个对象的InnerConnection
                obj1 = pinfo.GetValue(con1, null);
                con1.Close();
            }

            SqlConnection con2 = new SqlConnection(constr);
            using (con2)
            {
                con2.Open();
                //获取第二个对象的InnerConnection
                obj2 = pinfo.GetValue(con2, null);
                con2.Close();
            }

            if (obj1==obj2)
            {
                Console.WriteLine("使用同一个连接池。");
            }
            else
            {
                Console.WriteLine("不同一个连接池。");
            }

            Console.ReadKey();


        }
    }
}
