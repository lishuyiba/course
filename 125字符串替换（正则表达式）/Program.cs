using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _125字符串替换_正则表达式_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 字符串替换

            //1.把多个空格变成一个空格
            //string msg = "     我     爱   北京    天安门！   ";
            //string[] parts = msg.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            //msg= string.Join(" ", parts);
            //Console.WriteLine(msg);
            //Console.ReadKey();


            //2.把多个空格变成一个空格（正则表达式）
            //string msg = "     我     爱   北京    天安门！   ";
            //msg = Regex.Replace(msg, @"\s+", " ");
            //Console.WriteLine(msg);
            //Console.ReadKey();


            //3.将连续的“-”都替换成一个“-”
            //string msg = "234--234------------------34-----------55";
            //msg = Regex.Replace(msg, "-+", "-");//\-+或者-+
            //Console.WriteLine(msg);
            //Console.ReadKey();

            #endregion

            #region 替换使用提取组 -- 中奖用户手机

            //string msg = "中奖的用户手机号码：13811112222，13833334444，13855556666";
            //msg = Regex.Replace(msg, @"(\d{3})(\d{4})(\d{4})", "$1****$2");
            //Console.WriteLine(msg);
            //Console.WriteLine("OK");
            //Console.ReadKey();

            #endregion


            #region “我的生日是05/21/2010耶”转换为“我的生日是2010-05-20耶”

            //string msg = "我的生日是05/21/2010耶";
            //msg = Regex.Replace(msg, @"(\d{2})/(\d{2})/(\d{4})", "$3-$1-$2");
            //Console.WriteLine(msg);
            //Console.ReadKey();

            #endregion

            #region 把“http://www.test.com”转换为“<a href="http://www.test.com">http://www.test.com</a>”

            string url = "Website 1: http://www.test.com Website 2:http://www.baidu.cn";
            url = Regex.Replace(url, @"([a-zA-Z]+://[a-zA-Z\.\-\?&/=]+(\.[a-zA-Z\.\-\?&/=]+)+)", "<a href=\"$1\">$1</a>");
            Console.WriteLine(url);
            Console.ReadKey();

            #endregion






        }
    }
}
