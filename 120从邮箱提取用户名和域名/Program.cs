using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _120从邮箱提取用户名和域名
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "lsy@163.com.cn";
            //string regEmail = @"([a-zA-Z0-9_\.]+)@([a-zA-Z0-9_\.]+)+";//自己写
            string regEmail = @"^([a-zA-Z0-9_\-]+)@([a-zA-Z0-9]+(\.[a-z-A-Z0-9]+)+)$";
            Match match = Regex.Match(email, regEmail);

            //foreach (Match mc in matches)
            //{
            //    Console.WriteLine("用户名："+mc.Groups[1].Value);
            //    Console.WriteLine("域名"+mc.Groups[2].Value);
            //}

            if (match.Success)
            {
                Console.WriteLine("用户名：" + match.Groups[1].Value);
                Console.WriteLine("域名" + match.Groups[2].Value);
            }

            Console.WriteLine("=======OK=======");
            Console.ReadKey();
        }
    }
}
