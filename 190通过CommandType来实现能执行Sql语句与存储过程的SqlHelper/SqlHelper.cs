using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _185通过SqlHelper实现增删查改
{
    /// <summary>
    /// 在参数加上CommandType type以后，这时该sqlHelper就既可以执行存储过程，也可以执行sql语句了。
    /// </summary>
    public static class SqlHelper
    {
        //获取配置文件中的连接字符串
        private static readonly string constr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

        /// <summary>
        /// 执行insert、delete、update的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql,CommandType type, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {                
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = type;
                    con.Open();
                    //如果pms为null，则调用cmd.Parameters.AddRange(pms)会报错。
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// 执行sql语句，返回单个值
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        /// <param name="pms">sql语句中的参数</param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql,CommandType type, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = type;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }


        /// <summary>
        /// 执行sql语句返回一个DataReader
        /// 当返回DataReader的时候，注意：
        /// 1.Connection不能关闭
        /// 2.DataReader不能关闭
        /// 3.Command对象执行ExecuteReader()的时候需要传递一个参数commandBehavior.CloseConnection
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql,CommandType type, params SqlParameter[] pms)
        {
            SqlConnection con = new SqlConnection(constr);
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    cmd.CommandType = type;
                    con.Open();
                    //当调用ExecuteReader()方法的时候，如果传递一个commandBehavior.ColseConnection参数，则表示将来用户关闭reader的时候，系统会自动将Connection也关闭掉。
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    return reader;
                }
            }
            catch
            {
                //如果连接为不为空，则关闭连接、释放资源
                if (con!=null)
                {
                    con.Close();
                    con.Dispose();
                }
                throw;
            }
        }


        /// <summary>
        /// 封装一个返回DataTable的方法。
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string sql,CommandType type, params SqlParameter[] pms)
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, constr);
            if (pms!=null)
            {
                sqlAdapter.SelectCommand.Parameters.AddRange(pms);
            }
            DataTable dt = new DataTable();
            sqlAdapter.SelectCommand.CommandType = type;
            sqlAdapter.Fill(dt);
            return dt;
        }





    }





}
