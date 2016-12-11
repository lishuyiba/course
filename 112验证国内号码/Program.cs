using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _112验证国内号码
{
    class Program
    {
        static void Main(string[] args)
        {
            //string reg = @"a.b";//ab之间可以是任意的单个字符

            //正则表达式中的转义符也是“\”，如果要出现一个字符，这个字符又是“元字符”，这时为了系统不认为是“元字符”，就需要将元字符“转义”。（在“元字符”前面加反斜杠“\”）
            //string reg = @"a\.b";//ab之间必须是一个“.”
            //Console.WriteLine(Regex.IsMatch("a.b",reg));
            //Console.ReadKey();

            //string reg = @"^\d{3,4}";// 区号，3位或者4位
            //string reg = @"^\d{3,4}\-?";//“\”表示转义横杠，“?”表示可有可无
            //string reg = @"^\d{3,4}\-?\d{7,8}";//区号后面可以是7位或者8位
            //string reg = @"((^\d{3,4}\-?\d{7,8})|(\d{5}))$";//有的区号可能是5位
            string reg = @"^((\d{3,4}\-?\d{7,8})|(\d{5}))$";
            while (true)
            {
                Console.WriteLine("请输入电话号码：");
                string phone = Console.ReadLine();
                Console.WriteLine(Regex.IsMatch(phone,reg));
            }

        }

        public static string Rege { get; set; }
    }
}
