using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _86泛型集合____练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习一：将int数组中的奇数放到一个新的int数组中返回

            //List<int> listarrInt = new List<int>();

            //int[] arrInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //for (int i = 0; i < arrInt.Length; i++)
            //{
            //    if (arrInt[i] % 2 != 0)
            //    {
            //        //判断是否奇数，如果是加到listarrInt集合中。
            //        listarrInt.Add(arrInt[i]);
            //    }
            //}

            ////int[] nums = listarrInt.ToArray();
            ////Console.WriteLine(string.Join(" ", nums));

            ////所有的奇数都放到arrOdd数组中
            //int[] arrOdd = listarrInt.ToArray();
            //for (int i = 0; i < arrOdd.Length; i++)
            //{
            //    Console.WriteLine(arrOdd[i]);
            //}

            //Console.ReadKey();

            #endregion

            #region 练习二：从一个整数的List<int>中取出最大数（找最大值），别用max方法

            //List<int> listInt = new List<int>() { 10, 12, 14, 16, 23, 56 };
            ////Console.WriteLine(listInt.Max());
            ////int max = 0;
            //int maxValue = listInt[0];//假设集合里面的第一个元素是最大值
            //for (int i = 0; i < listInt.Count; i++)
            //{                
            //    if (listInt[i]>maxValue)
            //    {
            //        maxValue = listInt[i];
            //    }                
            //}
            //Console.WriteLine(maxValue);
            //Console.ReadKey();

            #endregion

            #region 练习三：把123转换为;壹贰叁。 Dictionary<char,char>
            //Console.WriteLine("请输入一个数字：");
            //string number = Console.ReadLine();

            ////========================创建字典===========================
            //string str = "1壹 2贰 3叁 4肆 5伍 6陆 7柒 8捌 9玖 0零";
            //string[] parts = str.Split(' ');
            //Dictionary<char, char> dict = new Dictionary<char, char>();
            //for (int i = 0; i < parts.Length; i++)
            //{
            //    dict.Add(parts[i][0], parts[i][1]);//[键、值] 第i个元素第0个键 第i个元素第1个值
            //}
            ////===========================================================

            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < number.Length; i++)
            //{
            //    sb.Append(dict[number[i]]);//根据用户输入的阿拉伯数字再对照dict字典拼接字符串
            //}
            //Console.WriteLine(sb.ToString());
            //Console.ReadKey();

            #endregion

            #region 练习四：计算字符串中每个字符出现的次数（面试题）

            //string msg = "Welcome to China world";
            //msg = msg.ToUpper();//不区分大小写
            //Dictionary<char, int> dict = new Dictionary<char, int>();

            ////统计每个字符出现的次数
            //for (int i = 0; i < msg.Length; i++)
            //{
            //    //判断是否是字母，是字母才统计。
            //    if (char.IsLetter(msg[i]))
            //    {
            //        if (dict.ContainsKey(msg[i]))
            //        {
            //            dict[msg[i]]++;//判断当前字典集合是否有该键，如果有则累加
            //        }
            //        else
            //        {
            //            dict.Add(msg[i], 1);//如果不存在，把它增加新字符
            //        }                    
            //    }                
            //}
            //foreach (KeyValuePair<char,int> kv in dict)
            //{
            //    Console.WriteLine("字符：{0} 出现了{1}次。",kv.Key,kv.Value);
            //}
            //Console.ReadKey();

            #endregion

            #region 练习五：日期转换

            //Console.WriteLine("请输入一个日期：");
            string date = "二零一二年十二月二十一日";
            date = ConvertDateToNumber(date);
            Console.WriteLine(date);
            Console.ReadKey();
            #endregion


        }

        private static string ConvertDateToNumber(string date)
        {
            //==================构建字典============================
            Dictionary<char, char> dict = new Dictionary<char, char>();
            string ziDian = "零0 一1 二2 三3 四4 五5 六6 七7 八8 九9";
            string[] parts = ziDian.Split(' ');//去除字符串的 空格
            for (int i = 0; i < parts.Length; i++)
            {
                dict.Add(parts[i][0], parts[i][1]);//把第一个作为键 第二个作为值
            }
            //======================================================


            StringBuilder sb = new StringBuilder();
            //循环用户输入的日期中的每个char
            for (int i = 0; i < date.Length; i++)
            {

                if (dict.ContainsKey(date[i]))//如果字典包含，则直接翻译
                {
                    sb.Append(dict[date[i]]);
                }
                else if (!dict.ContainsKey(date[i]) && date[i] != '十')//判断年月日
                {
                    sb.Append('-');//如果是年月日，则替换成“-”
                }
                else
                {
                    #region 如果单前的字符是“十”
                    //========================"十"的四种情况==========================
                    //1.*月十日 
                    //2.*月十三日
                    //3.*月二十三日
                    //4.*月三十日

                    if (!dict.ContainsKey(date[i - 1]) && !dict.ContainsKey(date[i + 1]))
                    {
                        sb.Append("10");
                    }
                    else if (!dict.ContainsKey(date[i - 1]) && dict.ContainsKey(date[i + 1]))
                    {
                        sb.Append("1");
                    }
                    else if (dict.ContainsKey(date[i - 1]) && dict.ContainsKey(date[i + 1]))
                    {
                        //这是“十”不需要翻译
                    }
                    else if (dict.ContainsKey(date[i - 1]) && !dict.ContainsKey(date[i + 1]))
                    {
                        sb.Append("0");
                    }
                    //================================================================ 
                    #endregion
                }
            }

            return sb.ToString().TrimEnd('-');//TrimEnd清除最后一个字符
        }
    }
}
