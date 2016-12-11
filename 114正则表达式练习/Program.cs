using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _114正则表达式练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 验证IP地址

            //while (true)
            //{
            //    Console.WriteLine("请输入IP地址：");
            //    string ip = Console.ReadLine();
            //    //192.168.1.100
            //    //string reg = @"^[0-9]{0,3}\.[0-9]{0,3}\.[0-9]{0,3}\.[0-9]{0,3}$";
            //    string reg = @"^\d{1,3}(\.\d{1,3}){3}$";
            //    Console.WriteLine(Regex.IsMatch(ip, reg));

            //}

            #endregion

            #region 验证日期

            //while (true)
            //{
            //    Console.WriteLine("请输入日期：");
            //    string date = Console.ReadLine();
            //    //string reg = @"^\d{4}\-\d{1,2}\-\d{1,2}$";
            //    //2008-08-08
            //    string reg = @"^\d{4}\-\d{1,2}\-\d{1,2}$";
            //    Console.WriteLine(Regex.IsMatch(date, reg));

            //}

            #endregion

            #region 验证合法的URL地址

            //while (true)
            //{
            //    Console.WriteLine("请输入URL：");
            //    string url = Console.ReadLine();
            //    //http://www.abc.com
            //    string reg = @"^[a-zA-Z]+://.+$";               
            //    Console.WriteLine(Regex.IsMatch(url, reg));

            //}

            #endregion

            #region 验证用户输入的数字是否大于10并且小于20的数字

            //while (true)
            //{
            //    Console.WriteLine("请输入数字：");
            //    string number = Console.ReadLine();
            //    string reg = @"^((1[1-9])|(2[0-9]))$";//大于10并且小于30的数字
            //    //string reg = @"^[1][1-9]$";
            //    Console.WriteLine(Regex.IsMatch(number, reg));

            //}

            #endregion
        }
    }
}
