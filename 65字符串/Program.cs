using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65字符串
{
    class Program
    {
        //vs2010下查看栈地址用 * +变量名 ，不能查看堆地址
        //vs2012下查看栈地址和堆地址用 & +变量名


        //字符串特性：
        //1.不可变性
        //2.字符串池
        //3.字符串留用

        //Length() 获取字符串的字符个数
        //IsNullOrEmpty() 静态方法，判断为null或者为""
        //ToCharArray() 可以把一个字符串变成一个char数组，并且可以修改该数组。
        //ToLower() 小写
        //ToUpper() 大写
        //Equals() 比较两个字符串是否相同，忽略大小写的比较。
        //IndexOf() 在字符串中找第一次出现的某个字符（如果没有找到对应的数据，返回-1）
        //LastIndex() 找最后一次出现的某个字符
        //Substring() 截取字符串
        //Split() 去掉指定的分隔符
        //Join() 把字符串数组中每个元素用指定的连接符链接起来最后得到一个完整的字符串
        //Format() 通过占位符莱拼接字符串
        //Trim() 去掉两边的空格
        //Replace() 替换敏感词
        



        static void Main(string[] args)
        {
            #region 字符串不可变性
            #region 没有转换成大写
            //string msg = "Welcome to China.";
            //msg.ToUpper();
            //Console.WriteLine(msg);
            //Console.ReadKey(); 
            #endregion

            #region 转换成大写
            //string msg = "Welcome to China.";
            ////字符串的不可变性。由于字符串是不可变的，所以每次修改字符串都是创建了一个单独的字符串副本（又拷贝了一个字符串。）
            //msg = msg.ToUpper();
            //Console.WriteLine(msg);
            //Console.ReadKey(); 
            #endregion
            #endregion

            #region 字符串池

            //当程序中有多个相同的字符串常量时，这时，这些字符串都是指向内存中的同一个字符串，这个特性叫做：字符串池。
            //之所以字符串池不会造成程序的混乱，是因为字符串具有 字符串不可变性。
            //string s1 = "Hello";
            //string s2 = "Hello";
            //string s3 = "H";
            //string s4 = "ello";
            //string s5 = s3 + s4;
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.ReadKey();

            /*通过调试即时窗口可以看到：s1和s2栈不一样，内存地址是一样的。
             &s1
                0x05a0ee48
                          s1: 0x00000000
             &s2
                0x05a0ee44
                          s2: 0x00000000
             */

            #endregion

            #region 字符串留用

            //string s1 = "a";
            //string s2 = "b";
            //string s3 = "c";

            //s4与s5这两个字符串中的内容虽然一样，但是在内存中是两块内存。
            //string s4 = s1 + s2 + s3;
            //string s5 = s1 + s2 + s3;
            //Console.ReadKey();//光标在这里，直接按F10  就可以启动调试到光标这一行就停止执行。

            //string x1 = "a";
            //string x2 = "bc";
            //string x3 = "c";

            //string s4 = string.Intern(s1 + s2 + s3);
            //string s5 = string.IsInterned(x1 + x2);
            /*通过即使窗口可以看到 字符串留用的堆地址一样。
             &s4
                0x04d7e8a4
                    s4: 0x00000000
             &s5 
                0x04d7e8a0
                    s5: 0x00000000
            */
            //Console.ReadKey();

            #endregion


            string s1 = "a";
            s1 = s1 + "b";
            s1 = s1 + "c";
            Console.WriteLine(s1);
            Console.ReadKey();

        }
    }
}
