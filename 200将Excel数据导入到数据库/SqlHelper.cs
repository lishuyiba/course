using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _197通过MD5加密登陆
{
    public static class SqlHelper
    {
        private static readonly string constr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

        public static int ExecuteNonQuery(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //同一个参数不能让多个Command对象来使用，如果必须让多个Command对象使用同一组参数的话，那么每个Command对象使用完毕后都需要“cmd.Parameters.Clear();”清空一下。
                    #region 第一种使用参数方式
                    //cmd.CommandType = cmdType;
                    //if (pms != null)
                    //{
                    //    cmd.Parameters.AddRange(pms);
                    //};
                    //con.Open();
                    //return cmd.ExecuteNonQuery(); 
                    #endregion

                    #region 第二种使用参数方式

                    cmd.CommandType = cmdType;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    };
                    con.Open();
                    int r= cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return r;

                    #endregion
                }
            }
        }

        public static object ExecuteScalar(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = cmdType;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static SqlDataReader ExecuteReader(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            SqlConnection con = new SqlConnection(constr);
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = cmdType;
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    return reader;
                }
            }
            catch (Exception)
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                }
                throw;
            }
        }

        public static DataTable ExecuteDataTable(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, constr))
            {
                DataTable dt = new DataTable();
                adapter.SelectCommand.CommandType = cmdType;
                if (pms != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                    adapter.Fill(dt);
                }
                return dt;
            }                                                            
        }


    }
}
