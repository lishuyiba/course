using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _110正则表达式
{
    class Program
    {
        /// <summary>
        /// 正则表达式是对文本、字符串操作的。
        /// 
        /// ========================规则=======================================
        /// 
        /// 
        /// 
        /// 
        /// 1>  .   匹配除\n以外的任意单个字符。
        /// 2>  []  匹配括号中的任意一个字符。
        /// 3>  |   将两个匹配条件进行逻辑“或”运算。[要么是左边的要么是右边的]
        /// 4>  ()  将()之间括起来的表达式定义为“组”，并且将匹配这个表达式的字符保存到一个临时区域
        ///         这个元字符在字符串提取的时候非常有用。把一些字符表示为一个整体。 
        ///         改变优先级、定义提取组 两个作用。
        ///        
        /// 5>  *   限定符，匹配0至多个在它之前的子表达式。和通配符*没关系。
        /// 6>  +   限定符，匹配前面的子表达式一次或多次，和*对比（0到多次）。
        /// 7>  ?   匹配前面的子表达式0次或1次。
        /// 8> {n}  匹配确定的n次。
        /// 9> {n,} 至少匹配n次。
        ///10> {n,m}最少匹配n次且最多匹配m次。
        ///
        /// 
        ///11>  ^   匹配一行的开始。[以什么开头]
        ///12>  ^   另外一种意思：非
        ///13>  $   匹配行结束符。
        ///14> ^abc 匹配一个正则表达式的开始。
        ///15> 888$ 匹配一个正则表达式的结束。
        /// 
        ///16>  \d  表示0-9 比如：a\d{5}z 表示a到z之间0到9可以出现5次。
        ///17>  \D  表示除0-9以外(跟\d相反)。
        ///18>  \s  表示空格符、换行符、Tap制表符等等。
        ///19>  \S  表达非空白符
        ///20>  \w  匹配字母或数字或下划线或汉字，即能组成单词的字符除%&#@$等字符。
        ///22>  \W  非\w ，等同与[^\w]%
        ///
        /// 
        /// 
        /// 
        /// </summary>
       
        static void Main(string[] args)
        {
            //在.net中使用正则表达式的时候就用Regex这个类。
            //Regex.IsMatch();//判断一个字符串是否匹配某个正则表达式。
            //Regex.Match();//从某个字符串中提取匹配正则表达式的某个子字符串（只能提取一个）。
            //Regex.Matches();//字符串提取，可以提取所有匹配的字符串。
            //Regex.Replace();//字符串替换，把所有匹配正则表达式的字符串替换成对应的字符串。

            #region Regex.IsMatch()

            //1.
            //string reg = "^a.+b$";
            //bool b = Regex.IsMatch("axxx.b", reg);//匹配
            //Console.WriteLine(b);
            //Console.ReadKey();


            //2.
            //Console.WriteLine(Regex.IsMatch("bbbbg","^.*g$"));//True
            //Console.WriteLine(Regex.IsMatch("gb","^.*g$"));//True
            //Console.WriteLine(Regex.IsMatch("gege","^b.g$"));//False


            //3.1
            //string regexp = @"\d{6}";
            //string msg = "100094";
            //Console.WriteLine(Regex.IsMatch(msg,regexp));//True
            //Console.ReadKey();


            //3.2
            //string regexp = @"\d{6}";
            //string msg = "中关村软件园100094，哈和厚黑！";
            ////这时返回的结果是True ，因为正则表达式中没有写开始“^”和结束“$”
            ////所以，IsMatch()方法在msg这个字符串中，只要找到任何一个与regexp匹配的字符串就返回True
            //Console.WriteLine(Regex.IsMatch(msg, regexp));//True
            //Console.ReadKey();


            //3.3
            //string regexp = @"^\d{6}$";//这时表示这个字符串必须与该正则表达式完全匹配。
            //string msg = "中关村软件园100094，哈和厚黑！";          
            //Console.WriteLine(Regex.IsMatch(msg, regexp));//False ，因为有开始“^”和结束“$”。
            //Console.ReadKey();


            //4.1
            //string regexp = "z|food";//只要任意地方出现z或者food就为True [因为没写开始“^”和结束“$”]
            //while (true)
            //{
            //    Console.WriteLine("请输入一个字符串：");
            //    string msg = Console.ReadLine();
            //    Console.WriteLine(Regex.IsMatch(msg, regexp));
            //}


            //4.2
            //string regexp = "^z|food$";//以z开头后面跟什么都行、以food结尾前面跟什么都行
            //while (true)
            //{
            //    Console.WriteLine("请输入一个字符串：");
            //    string msg = Console.ReadLine();
            //    Console.WriteLine(Regex.IsMatch(msg, regexp));
            //}


            //4.3
            //string regexp = "^(z|food)$";//只有z或者food为True，其他都为False
            //while (true)
            //{
            //    Console.WriteLine("请输入一个字符串：");
            //    string msg = Console.ReadLine();
            //    Console.WriteLine(Regex.IsMatch(msg, regexp));
            //}


            //==============================总结==================================
            //1. z|food
            //表示z或者food，不表示zood，但是，由于该正则表达式没有写^和$。所以在整个字符串中，只要有任意一个位置出现z或者food都返回True

            //2. ^z|food$
            //表示以z开头的任意字符串或者以food结尾的任意字符串都返回True。
            //原因是：“|”的优先级最低，所以上边的表达式其实就是相当于：(^z)|(food$)

            //3. ^(z|f)ood$
            //这个才表示要么是zood要么是food，只能匹配这两个。

            //^zood$|^food$ 与^z|food$不一样，^z|food$表示z……或者……food

            //====================================================================
            #endregion


            

        }
    }
}
