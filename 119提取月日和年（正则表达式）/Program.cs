using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _119提取月日和年_正则表达式_
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = "June      26      ,       1995        ";
            string regDate = @"^([a-zA-Z]+)\s*(\d{1,2})\s*,\s*(\d{4})\s*$";
            MatchCollection matches = Regex.Matches(date, regDate);
            foreach (Match mc in matches)
            {
                Console.WriteLine(mc.Groups[1].Value);
                Console.WriteLine(mc.Groups[2].Value);
                Console.WriteLine(mc.Groups[3].Value);
            }
            Console.WriteLine("=====OK=====");
            Console.ReadKey();
        }
    }
}
