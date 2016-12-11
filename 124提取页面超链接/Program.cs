using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _124提取页面超链接
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost/";
            WebClient wc = new WebClient();
            string html = wc.DownloadString(url);
            //<a href="http://go.microsoft.com/fwlink/?LinkID=209092" title="microsoft.com/web" >
            string regA = "<[a] href=\"[http://].+\" title .+[a]>";//匹配有问题，未完成！
            MatchCollection matches = Regex.Matches(html, regA);
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
