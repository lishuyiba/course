using _197通过MD5加密登陆;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215通过三层实现年龄自动增长.DAL
{

    /// <summary>
    /// 这个类是对MyStudent表执行增删改查
    /// </summary>
    public class MyStudentDal
    {
        /// <summary>
        /// 数据访问层的方法注意：
        /// 1.那些sql语句，访问数据库的类，只能出现在这一层。
        /// 2.数据访问层职责一定要单一，不要做过多的操作。
        /// 3.将传过来的参数，直接在数据库中执行对应的sql语句，然后把返回的结果直接原封不动的返回给调用者，这里不要加额外的其他判断。
        /// </summary>
        /// <param name="fid">传进来的id</param>
        /// <returns>直接返回执行的结果</returns>
        public int IncAgeById(int fid)
        {
            string sql = "update MyStudent set fage=fage+1 where fid=@id";
            SqlParameter p1 = new SqlParameter("@id", fid);
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, p1);
        }
    }
}
