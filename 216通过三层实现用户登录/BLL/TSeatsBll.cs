using _216通过三层实现用户登录.DAL;
using _216通过三层实现用户登录.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216通过三层实现用户登录.BLL
{
    /// <summary>
    /// 操作T_Seats表的业务逻辑层
    /// </summary>
    public class TSeatsBll
    {

        //这些业务逻辑层类、数据库层类都没有写成静态类，是因为以后要多态。静态类就不能“多态”了


        /// <summary>
        /// 验证用户登录的方法
        /// </summary>
        /// <param name="uid">用户的登录名</param>
        /// <param name="pwd">登陆密码</param>
        /// <param name="autoId">输出参数，记录用户主键Id</param>
        /// <param name="realName">输出参数，记录用户真实姓名</param>
        /// <returns></returns>
        public LoginResult UserLoginValidate(string uid, string pwd, out int autoId, out string realName)
        {
            TSeatsDal dal = new TSeatsDal();
            autoId = -1;
            realName = null;
            TSeat model = dal.GetUserByLoginId(uid);
            if (model == null)
            {
                return LoginResult.UserNotExists;
            }
            else if (model.LoginPwd == CommonHelper.Md5Encrypt(pwd))
            {
                autoId = model.AutoId;
                realName = model.UserName;
                return LoginResult.LoginSuccessful;
            }
            else
            {
                return LoginResult.ErrorPassword;
            }
        }


        /// <summary>
        /// 修改密码的操作
        /// </summary>
        /// <param name="autoId"></param>
        /// <param name="oldPwd"></param>
        /// <param name="newPwd"></param>
        /// <param name="newPwd1"></param>
        /// <returns></returns>
        public ChangePasswprdResult ChangePassword(int autoId, string oldPwd, string newPwd, string newPwd1)
        {
            //1.先校验是否为空
            if (string.IsNullOrEmpty(oldPwd) || string.IsNullOrEmpty(newPwd) || string.IsNullOrEmpty(newPwd1))
            {
                //返回必填值[1]
                return ChangePasswprdResult.NullValue;
            }
            else if (newPwd != newPwd1)
            {
                //表示用户该填的文本框都填了（没有空值了）
                //返回两次输入的密码不一致[2]
                return ChangePasswprdResult.DiffPwd;
            }
            else if (!ChkOldPwd(autoId, oldPwd))//再校验旧密码是否正确
            {
                //返回旧密码不正确[3]
                return ChangePasswprdResult.OldPwdError;
            }
            else
            {
                //在这里才开始执行修改密码操作
                TSeatsDal dal = new TSeatsDal();
                int r = dal.ChangePassword(autoId, CommonHelper.Md5Encrypt(newPwd));
                if (r>0)
                {
                    return ChangePasswprdResult.OK;
                }
                else
                {
                    return ChangePasswprdResult.Failed;
                }
            }

            //2.再校验两次输入的新密码是否一致

            //3.校验旧密码是否正确

            //4.更新密码
        }


        /// <summary>
        /// 校验旧密码是否正确
        /// </summary>
        /// <param name="autoId"></param>
        /// <param name="oldPwd"></param>
        /// <returns></returns>
        public bool ChkOldPwd(int autoId, string oldPwd)
        {
            TSeatsDal dal = new TSeatsDal();
            int r = Convert.ToInt32(dal.ValidOldPassword(autoId, CommonHelper.Md5Encrypt(oldPwd)));
            if (r > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
