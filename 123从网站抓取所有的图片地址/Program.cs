using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _123从网站抓取所有的图片地址
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost/";
            WebClient wc = new WebClient();
            string html = wc.DownloadString(url);
            //<img src="iis-8.png" alt
            //<img src="iis-8.png" alt="Microsoft
            string regImg = "<[i][m][g] src=\"(.+)\" alt=";
            MatchCollection matches= Regex.Matches(html, regImg);
            foreach (Match match in matches)
            {
                //Console.WriteLine(match.Groups[1].Value);
                string imgUrl = "http://localhost/"+match.Groups[1].Value;
                wc.DownloadFile(imgUrl,@"f:\image\"+Path.GetFileName(imgUrl));
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
