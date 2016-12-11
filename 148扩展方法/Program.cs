using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _148扩展方法
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 验证邮箱是否合法
            //string email = "zxh@itcast.cn";
            //bool b = ChkEmail(email);
            //Console.WriteLine(b);
            //Console.ReadKey(); 
            #endregion

            #region string 扩展方法

            //string email = "zxh@itcast.cn";
            //Console.WriteLine(email.IsEmail());
            //Console.ReadKey(); 

            #endregion

            #region Person 扩展方法

            //Person p1 = new Person();
            //p1.Name = "zxh";
            //p1.SayHi("今天是个好日子");
            //Console.ReadKey();

            #endregion

        }
        static bool ChkEmail(string email)
        {
            return Regex.IsMatch(email, @"^\w+@\w+\.\w+$");
        }
    }
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
    }
}
