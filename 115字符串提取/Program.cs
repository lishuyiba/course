using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _115字符串提取
{
    class Program
    {
        static void Main(string[] args)
        {


            //========================Regex.Match()==================================

            ////1.字符串提取，提取下列字符串中的所有数字。
            //string msg = "大家好2呀，hello，2010年10月10日是个好日子。嗯，9494.吼吼！886.";
            ////编写一个符合数字的正则表达式
            ////在做字符串提取的时候[一般]都不加^和$
            ////字符串提取，是在原来的字符串中只要找到一部分匹配就可以提取了，所以不能加^和$，如果加了，就表示要与原字符串完全匹配。
            //string regNumber = @"\d+";
            ////表示返回一个提取的结果。
            ////Regex.Match（）只能提取字符串中的第一个匹配的结果。
            //Match match = Regex.Match(msg, regNumber);
            //Console.WriteLine(match.Value);
            //Console.ReadKey();



            //=========================Regex.Matches=================================
            //2.
            string msg = "大家好2呀，hello，2010年10月10日是个好日子。嗯，9494.吼吼！886.";
            string regNumber = @"\d+";
            MatchCollection matches = Regex.Matches(msg, regNumber);
            //因为Regex.Matches返回的是一个集合，所以要遍历才能打印
            foreach (Match mt in matches)
            {
                Console.WriteLine(mt.Value);
            }
            Console.ReadKey();



        }
    }
}
