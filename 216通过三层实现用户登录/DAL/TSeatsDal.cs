using _197通过MD5加密登陆;
using _216通过三层实现用户登录.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216通过三层实现用户登录.DAL
{
    /// <summary>
    /// 操作T_Seats表的数据访问层的类
    /// </summary>
    public class TSeatsDal
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="uid">用户登录名</param>
        /// <returns>返回model</returns>
        public TSeat GetUserByLoginId(string uid)
        {
            TSeat model = new TSeat();
            //根据用户名的uid（登录名）从数据库中获取该用户的信息
            string sql = "select * from T_Seats where CC_LoginId=@uid";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, new SqlParameter("@uid", uid)))
            {
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        model.AutoId = reader.GetInt32(0);
                        model.ErrorTimes = reader.GetInt32(4);
                        model.LockedTime = reader.IsDBNull(5) ? null : (DateTime?)reader.GetDateTime(5);
                        model.LoginId = reader.GetString(1);
                        model.LoginPwd = reader.GetString(2);
                        model.TestInt = reader.IsDBNull(6) ? null : (int?)reader.GetInt32(6);
                        model.UserName = reader.GetString(3);                        
                    }
                    else
                    {
                        //如果reader.Read()有数据，可是读取不到数据，则向外抛异常
                        throw new Exception("DataReader调用Read()方法时异常。");
                    }
                }
                else
                {
                    //如果用户不存在，给model赋值null
                    model = null;
                }
            }
            return model;
        }


        /// <summary>
        /// 验证旧密码是否正确
        /// </summary>
        /// <param name="autoId">用户Id</param>
        /// <param name="oldPwd">旧密码</param>
        /// <returns>返回ExecuteScalar执行结果</returns>
        public object ValidOldPassword(int autoId, string oldPwd)
        {
            string sql = "select count(*) from T_Seats where CC_AutoId=@autoId and CC_LoginPassword=@oldPwd";
            SqlParameter[] pms = new SqlParameter[] { 
                new SqlParameter("@autoId",autoId),
                new SqlParameter("@oldPwd",oldPwd)
            };
            return SqlHelper.ExecuteScalar(sql, CommandType.Text, pms);
        }


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="autoId">用户Id</param>
        /// <param name="newPwd">新密码</param>
        /// <returns>返回ExecuteNonQuery执行结果</returns>
        public int ChangePassword(int autoId, string newPwd)
        {
            //string sql = "select count(*) from T_Seats where CC_AutoId=@autoId and CC_LoginPassword=@oldPwd";
            string sql = "update T_Seats set CC_LoginPassword=@oldPwd where CC_AutoId=@autoId";
            SqlParameter[] pms = new SqlParameter[] { 
            new SqlParameter("autoId",autoId),
            new SqlParameter("oldPwd",newPwd)
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
        }

    }
}
