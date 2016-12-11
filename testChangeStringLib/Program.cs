using ChangeStringLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testChangeStringLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();            
            string[] names = { "Bob", "Chris", "James", "Steve", "Jhoney" };

            //把字符串都变成大写
            //c1.ChangeString(names, ChangeStringToUpper);

            //把字符串的两端都加一个五角星
            c1.ChangeString(names, ChangeStringAddWjx);

            //遍历每一个数组
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }

        //左边和右边添加*
        static string ChangeStringAddWjx(string msg)
        {
            return "*" + msg + "*";
        }

        //转换大写
        static string ChangeStringToUpper(string msg)
        {
            return msg.ToUpper();
        }
    }
}
