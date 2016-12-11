using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163连接数据库
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 连接数据库 方式一
            ////链接字符串server=.;database=bbs;uid=sa;pwd=sa;

            ////使用sql server身份验证方式
            ////string constr = "Data Source=LENOVO-PC;Initial Catalog=School;User Id=sa;Password=sa";

            ////使用windows身份验证方式
            //string constr = "Data Source=LENOVO-PC;Initial Catalog=School;Integrated Security=True";

            ////根据连接字符串，创建连接对象
            //SqlConnection con = new SqlConnection(constr);

            ////这句话才是去连接数据库的操作，如果失败也是这句话报异常
            //con.Open();
            //Console.WriteLine("打开成功！");
            //con.Close();
            //con.Dispose();
            //Console.WriteLine("成功关闭！");
            //Console.ReadKey(); 
            #endregion

            #region 连接数据库 方式二（使用using连接，免得手动去关闭数据库）

            //string constr = "Data Source=LENOVO-PC;Initial Catalog=School;Integrated Security=True";
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    //事件状态发生改变时的事件
            //    con.StateChange += con_StateChange;
            //    con.Open();
            //    //con.Open(); //连接对象不能重复打开
            //    //if判断一下是否已经打开
            //    if (con.State == System.Data.ConnectionState.Closed)
            //    {
            //        con.Open();
            //    }
            //    //con.Close();//可以重复关闭
            //    //Console.WriteLine("连接已打开！");
            //}
            //Console.ReadKey(); 
            #endregion



            //复习：

            //1.创建连接字符串
            //1.1集成验证
            //string constr"Data Source=要连接服务器+实例名;Initial Catalog=要访问的数据库;Integrated Security=True";

            //2.创建SqlConnection连接对象
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    //3.创建Command对象
            //    string sql = "xxxxxxxx";
            //    using (SqlCommand cmd = new SqlCommand(sql, con))//sql:语句  con：要连接到哪一台服务器执行语句
            //    {
            //        con.Open();
            //        cmd.ExecuteNonQuery();//insert、delete、update ,所影响的行数，执行其他语句返回值都是-1
            //        cmd.ExecuteScalar();//返回单个结果。
            //        cmd.ExecuteReader();//查询多行多列结果的时候用，返回值SqlDataReader
            //    }

            //}


        }

        //连接的状态改变事件
        static void con_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            Console.WriteLine(e.CurrentState.ToString());
        }
    }
}
