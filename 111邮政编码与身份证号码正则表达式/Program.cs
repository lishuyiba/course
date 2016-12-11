using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _111邮政编码与身份证号码正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("请输入邮政编码：");
            //    string postcode = Console.ReadLine();
            //    string reg = @"^\d{6}$";//验证6位邮政编码
            //    bool result = Regex.IsMatch(postcode, reg);
            //    if (result == true)
            //    {
            //        Console.WriteLine("正确！");
            //    }
            //    else
            //    {
            //        Console.WriteLine("错误！");
            //    }

            //}
            while (true)
            {
                Console.WriteLine("请输入身份证号码：");
                string postcode = Console.ReadLine();
                //^\d{15}$|^{15}$
                //^(\d{15}|\d{18})$
                string reg = @"^\d{15}$|^{15}$";//验证15位或者18位身份证号码 
                bool result = Regex.IsMatch(postcode, reg);
                if (result == true)
                {
                    Console.WriteLine("正确！");
                }
                else
                {
                    Console.WriteLine("错误！");
                }

            }
        }
    }
}
