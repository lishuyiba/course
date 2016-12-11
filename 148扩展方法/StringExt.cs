using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _148扩展方法
{

    //扩展方法
    //1.增加一个静态类
    public static class StringExt
    {
        //2.在静态类中增加一个静态方法
        //2.1关键字[this string] string表示要扩展的类
        public static bool IsEmail(this string str)
        {
            return Regex.IsMatch(str, @"^\w+@\w+\.\w+$");
        }


        //this Person per表示当前SayHi方法给Person类型扩展
        //string msg 表示SayHi方法自己的参数
        public static void SayHi(this Person per, string msg)
        {
            //扩展方法看起来像Person中德方法，其实根本不是Person类自己的成员，所以在扩展方法中也访问不到Person原来的私有成员
            //1.一般不建议使用扩展方法
            Console.WriteLine("我叫：{0}，我说：{1}", per.Name, msg);
        }

    }

}
