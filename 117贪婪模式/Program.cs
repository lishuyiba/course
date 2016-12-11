using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _117贪婪模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //提取英文
            //当正则表达式提取的时候，如果1个字符也能匹配，多个字符也能匹配，这时，会按照使用最多字符的方式来匹配，这个就叫贪婪模式。
            //当终止贪婪模式后会按照最小的方式来匹配。
            //string str = "啊哈哈hello word！嘎嘎";
            //string regStr = "[a-zA-Z]+";//“？”用来终止贪婪模式的（在限定符后面）输出hello
            ////string regStr = "[a-zA-Z]+?";//“？”用来终止贪婪模式的（在限定符后面）输出 h
            //Match match = Regex.Match(str, regStr);
            //Console.WriteLine(match.Value);
            //Console.ReadKey();

            #region 贪婪模式
            ////正则表达式采用 贪婪模式，尽可能多的匹配。
            //string str = "1111。11。111。11111。";//打印：1111。11。111。11111。
            ////因为.+要尽可能多的匹配。所以会认为“1111。11。111。11111。”，都是.+匹配的结果，但是由于正则表达式的中最后一个“。”
            ////所以如果要将.+匹配了所有的字符，则最后的“。”无法找到匹配，正则表达式会尽可能的找到匹配，所以会将“。”尝试给正则表达式
            ////的最后一个字符“。”来匹配，然后把前面的所有字符都用.+来匹配。
            //string regStr = ".+。";
            //Match match = Regex.Match(str, regStr);
            //Console.WriteLine(match.Value);
            //Console.ReadKey(); 
            #endregion

            #region 终止贪婪模式

            string str = "1111。11。111。11111。";
            //
            string regStr = ".+?。";//?终止贪婪模式
            Match match = Regex.Match(str, regStr);
            Console.WriteLine(match.Value);//打印：1111。，因为.+?表示贪婪模式，所以只能提取出来第一个1，但是后面还有一个“。”，所以为了匹配“。”只能再向后搜索3个1，然后找到“。”，所以就是1111。
            Console.ReadKey();

            #endregion

        }
    }
}
