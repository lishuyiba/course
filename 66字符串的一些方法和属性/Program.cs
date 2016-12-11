using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66字符串的一些方法和属性
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "I爱You";
            //Length属性指的是，字符串中字符的个数。
            //Console.WriteLine(str.Length);

            //string msg = null;
            //string msg = "";
            //用来判断字符串是否为null或者是空字符串。
            //无论字符串是null还是空字符串，返回至都是true
            //if (string.IsNullOrEmpty(msg))
            //{
            //    Console.WriteLine("字符串为null或者为空字符串！");
            //}
            //else
            //{
            //    Console.WriteLine("字符串不是空的！");
            //}

            //表示s1变量没有指向任何堆内存
            //string s1 = null;
            //表示s2指向了一个堆内存，这个堆中存储的是“空字符串”
            //string s2 = "";

            //他们指向的都是同一个堆。
            //string s1 = "";
            //由于具有字符串池的概念，所以写多个"" 也是指向同一个内存，所以""与string.Empty是一样的。
            //string s3 = "";
            //内部是一个静态只读的字符串字段，程序中共享一个内存。
            //string s2 = string.Empty;


            //判断字符串为空可以用msg==""也可以用msg.Length==0(字符串长度为0，就表示字符串为空)
            //string msg = "aa";
            //使用Length==0来判断字符串是否为空，不要用msg==""
            //if (msg=="")
            //{
            //    Console.WriteLine("是空字符串！");
            //}
            //else
            //{
            //    Console.WriteLine("不是空字符串！");
            //}


            #region 把字符串修改成大写 不能这样子修改
            //string msg = "abcdefg";
            //for (int i = 0; i < msg.Length; i++)
            //{
            //    //Console.WriteLine(msg[i]);
            //    //由于字符串是不可变性，并且，在字符串的索引器中实现的时候也只是实现了一个只读索引器（只有get），所以这里不能直接修改字符串的内容。
            //    //msg[i] = char.ToUpper(msg[i]);

            //} 
            #endregion

            #region ToCharArray
            //string msg = "abc";
            //ToCharArray()可以把一个字符串变成一个char数组，并且可以修改该数组。
            //char[] ch = msg.ToCharArray();
            //for (int i = 0; i < ch.Length; i++)
            //{
            //ch[i] =(char)(ch[i] + 1);
            // ch[i] = (char)ch[i];
            // }
            // Console.WriteLine(new string(ch)); 
            #endregion

            #region 比较两个字符串是否相同 
            
            //string s1 = "AA";
            //string s2 = "aa";
            //这里调用了==判断字符串是否相同，其实内部也是调用了Equals()方法。
            //是==实现了一个运算符重载而已！
            //if (s1.ToUpper() == s2.ToUpper())//忽略大小写（把s1和s2转换成大写）
            ////if (s1==s2)//区分大小写
            //{
            //    Console.WriteLine("相同！");
            //}
            //else
            //{
            //    Console.WriteLine("不相同！");
            //}

            #endregion

            #region Equals区分大小写

            //string s1 = "AA";
            //string s2 = "aa";
            ////if(s1.Equals(s2))//区分大小写
            //if(s1.Equals(s2,StringComparison.OrdinalIgnoreCase))//不区分大小写
            //{
            //    Console.WriteLine("相同！");
            //}
            //else
            //{
            //    Console.WriteLine("不相同！");
            //}

            #endregion


            #region IndexOf 判断一个字符串中是否含有某个字符

            //string msg = "我爱北京天安门，天安门上太阳升！";
            //在整个字符串msg中，找“天安门”第一次出现的索引位置。
            //如果在msg中没有找到对应的字符串，则返回-1

            //int index = msg.IndexOf("天安门");
            
            //从索引为10的字符串开始找“天安门”
            //int index = msg.IndexOf("天安门", 10);

            //Console.WriteLine(index);//输出 4


            #endregion

            #region LastIndexOf

            //string msg = "我爱北京天安门，天安门上太阳升！";
            ////在msg中，找“天安门”最后一次出现的索引位置，其他参数同IndexOf()
            ////int index = msg.LastIndexOf("天安门");//天安门最后一次出现的位置
            //int index = msg.LastIndexOf("天安门",5);
            //Console.WriteLine(index);

            #endregion

            #region Substring截取字符串

            //string msg = "我爱[某某某]哈哈哈哈哈。。。。。";
            //从索引为2的字符串开始截取（含），一直截取到最后。
            //msg = msg.Substring(2);
            //msg = msg.Substring(5, 3);//截取从第5个字符（含）开始往后的共3个字符。
            //msg = msg.Substring(3, 3);//表示，从索引为5的字符串开始截取（含），截取长度为3个字符。
            //Console.WriteLine(msg);//输出 [某某某]哈哈哈哈哈。。。。。

            #endregion

            #region Split

            //=====================1=========================
            //string teams = "公牛|小牛|快船|";
            //根据一个字符来分隔
            //string[] teamName = teams.Split('|');

            //=====================2=========================
            //string teams = "公牛NBA小牛NBA快船";
            ////根据一个字符串来分隔
            //string[] teamName = teams.Split(new string[]{"NBA"},StringSplitOptions.None);

            //=====================3=========================
            //string teams = "公牛NBA小牛NBA快船NBANBANBANBA洛杉矶湖人";
            ////去掉分隔后面的空实体
            //string[] teamName = teams.Split(new string[] { "NBA" }, StringSplitOptions.RemoveEmptyEntries);//去掉空格

            //=====================4=========================
            //string teams = "公牛NBA小牛NBA快船-休斯顿火箭=尼克斯";
            //当使用多个分隔符就需要传递一个字符串数组了
            //string[] teamName = teams.Split(new string[] { "NBA","-","=" }, StringSplitOptions.None);


            #endregion

            #region Join

            //Join方法把字符串数组中每个元素用指定的连接符链接起来最后得到一个完整的字符串

            //string teams = "公牛NBA小牛NBA快船-休斯顿火箭=尼克斯";
            //string[] teamName = teams.Split(new string[] { "NBA","-","=" }, StringSplitOptions.None);
            //string fullName = string.Join("--",teamName);
            //Console.WriteLine(fullName);
            //Console.ReadKey();

            #endregion

            #region Format

            //string.Format();通过占位符拼接字符串。
            //string.Format();方法可以将拼接完成的字符串返回。
            //string s = string.Format("a+{0}",10);

            #endregion

            #region Trim

            //string msg = "       传智播客.net培训（黑马）    ";
            //Console.WriteLine("============="+msg.Trim()+"=============");//去掉msg字符串两边的空格
            //Console.ReadKey();

            #endregion

            #region Replace 替换敏感词

            //string msg = "我爱领袖毛主席，伟大的领袖毛主席，伟大的共产党，带领我们。。。";
            //msg = msg.Replace("毛主席", "敏感词").Replace("共产党", "敏感词");
            ////msg = msg.Replace("共产党", "敏感词");
            //Console.WriteLine(msg);
            //Console.ReadKey();

            #endregion



        }
    }
}
