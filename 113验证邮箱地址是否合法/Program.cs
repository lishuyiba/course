using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _113验证邮箱地址是否合法
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入邮箱：");
                string email = Console.ReadLine();
                //afaefeafe @ efeafeafe .com .cn
                string reg = @"^[a-zA-Z0-9][a-zA-Z0-9_\.]+@[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)+$";
                //string reg = @"^[a-zA-Z0-9][a-zA-Z0-9_\.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
                Console.WriteLine(Regex.IsMatch(email,reg));
            }
        }
    }
}
