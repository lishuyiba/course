using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _116从html中提取所有的Email
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //string file = File.ReadAllText("360.html");
            ////string regEmail = @"[a-zA-Z0-9_\-\.]+@[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)+";
            //string regEmail = @"([a-zA-Z0-9_\-\.])+@([a-zA-Z0-9]+)(\.[a-zA-Z0-9]+)+";//提取组
            //MatchCollection mc = Regex.Matches(file, regEmail);
            //foreach (Match match in mc)
            //{
            //    //Console.WriteLine(mt.Value);
            //    Console.WriteLine(match.Groups[0].Value);
            //    Console.WriteLine(match.Groups[1].Value);
            //    Console.WriteLine(match.Groups[2].Value);
            //    Console.WriteLine(match.Groups[3].Value);
            //}
            //Console.WriteLine("Email总数：" + mc.Count);
            //Console.ReadKey();
            #endregion


            string file = File.ReadAllText("360.html");
            //string regEmail = @"[a-zA-Z0-9_\-\.]+@[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)+";
            //提取组
            string regEmail = @"([a-zA-Z0-9_\-\.])+@([a-zA-Z0-9]+)(\.[a-zA-Z0-9]+)+";
            //match.Groups[0].Value 存储的值与match.Value中存储的值是一样的。
            //match.Groups[1].Value 存储用户名
            //match.Groups[2].Value 存储邮箱提供商
            //match.Groups[3].Value 存储后缀
            MatchCollection mc = Regex.Matches(file, regEmail);
            int count_163 = 0;
            int count_qq = 0;
            int count_sohu = 0;
            foreach (Match match in mc)
            {
                //通过match.Group[]来获取提取组。
                //注意：第0组存储的是完整匹配字符串，要获取提取组应该从索引1开始。
                switch (match.Groups[2].Value)
                {
                    case"163":
                        count_163++;
                        break;
                    case"qq":
                        count_qq++;
                        break;
                    case"sohu":
                        count_sohu++;
                        break;
                }
            }
            Console.WriteLine("Email总数：" + mc.Count);
            Console.WriteLine("网易邮箱用户人数：{0}",count_163);
            Console.WriteLine("qq邮箱用户人数：{0}",count_qq);
            Console.WriteLine("sohu邮箱用户人数：{0}",count_sohu);
            Console.ReadKey();
            
        }
    }
}
