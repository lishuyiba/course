using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216通过三层实现用户登录.BLL
{
    /// <summary>
    /// 登录返回结果枚举
    /// </summary>
    public enum LoginResult
    {
        UserNotExists,//用户名不存在
        LoginSuccessful,//登录成功
        ErrorPassword//密码错误
    }


    public enum ChangePasswprdResult
    { 
        NullValue,//不能为空值
        DiffPwd,//两次新密码不同
        OldPwdError,//旧密码错误
        OK,//修改成功
        Failed//修改失败
    }

}
