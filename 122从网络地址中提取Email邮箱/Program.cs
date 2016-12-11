using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _122从网络地址中提取Email邮箱
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost/";
            WebClient wc = new WebClient();
            string html = wc.DownloadString(url);
            string reg = @"\d+";//提取了网站所有的数字
            MatchCollection matches = Regex.Matches(html, reg);
            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
