using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _161邮箱掩码
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入邮箱地址：");
                string email = Console.ReadLine();
                //将所有email中搜索到的匹配正则表达式字符串替换为Rlce方法处理返回值
                email = Regex.Replace(email, @"(\w+)(@\w+.\w+)", Rlce);
                Console.WriteLine(email);
                Console.ReadKey();
            }
        }

        private static string Rlce(Match match)
        {
            //遍历第1组的值
            StringBuilder sbResult = new StringBuilder();
            for (int i = 0; i < match.Groups[1].Value.Length; i++)
            {
                //把第1组的值追加 *
                sbResult.Append("*");
            }
            sbResult.Append(match.Groups[2].Value);
            return sbResult.ToString();
        }
    }
}
