using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216通过三层实现用户登录.Model
{
    /// <summary>
    /// 用来封装T_Seats表中的一条数据的类型
    /// </summary>
    public class TSeat
    {
        //CC_AutoId, CC_LoginId, CC_LoginPassword, CC_UserName, CC_ErrorTimes, CC_LockDataTiem, CC_TestInt
        public int AutoId
        {
            get;
            set;
        }
        public string LoginId
        {
            get;
            set;
        }
        public string LoginPwd
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// 出错的次数
        /// </summary>
        public int ErrorTimes
        {
            get;
            set;
        }

        /// <summary>
        /// 最后一次错误登录的时间
        /// 因为CC_LockDataTiem在数据库中允许为空，所以要写成可空值类型DateTime?
        /// </summary>
        public DateTime? LockedTime
        {
            get;
            set;
        }

        /// <summary>
        /// 就是一个整形测试
        /// 因为CC_TestInt在数据库中允许为空，所以要写成可空值类型int?
        /// </summary>
        public int? TestInt
        {
            get;
            set;
        }
    }
}
