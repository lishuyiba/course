using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _175Ado.net连接池
{
    class Program
    {
        static void Main(string[] args)
        {

            //启用连接池与禁用连接池为什么性能差距这么大 ？
            //1.当启用连接池后，看似是2000次的登陆与注销（连接打开与关闭），其实只有一次打开，当程序关闭后才会关闭，所以高性能。
            //2.而禁用连接池后，则是真正的打开关闭了2000次。


            //Ado.net连接池使用总结：
            //1.第一次打开连接会创建一个连接对象。
            //2.当这个连接关闭时（调用Close()方法时）会将当前那连接对象放入池中。
            //3.下一个连接对象，如果连接字符串与池中现有连接对象的连接字符串完全一致，则会使用池中现有连接，而不会重新创建一个。
            //4.只有对象调用Close()的时候才会放入池中，如果一个连接对象一直在使用，则下次再创建一个连接对象发现池中没有，也会再创建一个新连接对象。
            //5.在池中的连接对象，如果过一段时间没有被访问则自动销毁。

            //连接池缺点：
            //连接池始终保持与数据库服务器连接打开状态。
            

            //清空连接池
            //ClearAllPools()
            //ClearPppl()

            #region 启用连接池
            //string constr = "Data Source=lenovo-pc;Initial Catalog=ItCastCn;Integrated Security=True";
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            ////0.1111227秒
            //for (int i = 0; i < 2000; i++)
            //{
            //    using (SqlConnection con = new SqlConnection(constr))
            //    {
            //        con.Open();
            //        con.Close();
            //    }
            //}
            //watch.Stop();
            //Console.WriteLine(watch.Elapsed);
            //Console.WriteLine("连接打开了又关闭了。");
            //Console.ReadKey();
            #endregion

            #region 禁用连接池

            string constr = "Data Source=lenovo-pc;Initial Catalog=ItCastCn;Integrated Security=True;Pooling=false";

            //设置pooling连接池大小
            //SqlConnectionStringBuilder sb;
            //sb.MaxPoolSize//最大
            //sb.MinPoolSize//最小

            Stopwatch watch = new Stopwatch();
            watch.Start();
            //5.3834340秒
            for (int i = 0; i < 2000; i++)
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    con.Close();//其实是将连接对象放入了连接池中，放入池中以后其他对象就可以使用了。
                }
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            Console.WriteLine("连接打开了又关闭了。");
            Console.ReadKey();

            #endregion
        }
    }
}
