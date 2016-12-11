using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64ref和0ut练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 通过ref修改两个变量。
            //int m1 = 10;
            //int m2 = 20;
            //Swap(ref m1, ref m2);
            //Console.WriteLine("m1:{0} m1:{1}", m1, m2);
            //Console.ReadKey(); 
            #endregion

            #region 判断用户名和密码
            Console.WriteLine("请输入用户名：");
            string uid = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string pwd = Console.ReadLine();
            string msg;
            bool isOK = ValidUserLogin(uid, pwd,out msg);
            Console.WriteLine("用户登录状态：{0} 提示信息：{1}",isOK,msg);
            Console.ReadKey();

            #endregion

        }

        private static bool ValidUserLogin(string uid, string pwd,out string msg)
        {
            #region 老版本
            //if (uid=="admin"&&pwd=="8888")
            //{
            //    return true;   
            //}
            //else
            //{
            //    return false;
            //} 
            #endregion

            msg = string.Empty;
            bool b = false;
            if (uid=="admin"&&pwd=="888888")
            {
                b = true;
                msg = "登陆成功！";
            }
            else if (uid=="admin"&&pwd!="888888")
            {
                msg = "密码错误！";
            }
            else
            {
                msg = "用户名或密码错误！";
            }
            return b;

        }

        static void Swap(ref int n1, ref int n2)
        {
            int tmp = n1;
            n1 = n2;
            n2 = tmp;
        }

    }
}
