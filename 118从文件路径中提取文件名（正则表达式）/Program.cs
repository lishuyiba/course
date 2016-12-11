using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _118从文件路径中提取文件名_正则表达式_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Program Files\Lenovo\Energy Management\TurnOnODD.exe";
            string regPath = @"^.+\\(.+)\.[a-zA-Z]+$";
            Match match = Regex.Match(path, regPath);
            if (match.Success)
            {
                Console.WriteLine(match.Groups[1].Value);
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
