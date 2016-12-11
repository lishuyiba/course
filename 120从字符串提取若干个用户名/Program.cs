using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _120从字符串提取若干个用户名
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "大家好。我们是s.h.e。我是s。我是h。呜呜。我是杨中科。我是苏坤。fffff";
            string regName = "我是(.+?)。";
            MatchCollection matches = Regex.Matches(str, regName);
            foreach (Match item in matches)
            {
                if (item.Success)
                {
                    Console.WriteLine(item.Groups[1].Value);
                    Console.WriteLine("================================");
                }
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
