using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习一：“abc”-- “cba”

            //Console.WriteLine("请输入一个字符串:");
            //string msg= Console.ReadLine();
            #region 方法一(遍历字符串 倒叙输出)
            //for (int i = msg.Length-1; i >=0; i--)
            //{
            //    Console.WriteLine(msg[i]);               
            //} 
            //Console.ReadKey();

            #endregion

            #region 方法二（把字符串转换成数组，再反转输出）

            //char[] ch = msg.ToCharArray();
            //for (int i = 0; i < ch.Length/2; i++)
            //{
            //    char tmp = ch[i];
            //    ch[i] = ch[ch.Length - 1 - i];
            //    ch[ch.Length - 1 - i] = tmp;
            //}
            //string str = new string(ch);
            //Console.WriteLine(str);
            //Console.ReadKey();

            #endregion

            #endregion

            #region 练习二：返序输出一句英文

            //Console.WriteLine("请输入英文句子：");
            //string stat = Console.ReadLine();
            //string[] words = stat.Split(' ');
            ////循环单词数组
            //for (int i = 0; i < words.Length; i++)
            //{
            //    //把每个单词都反转
            //    words[i] = WordReverse(words[i]);
            //}
            ////用Join空格连接起来
            //Console.WriteLine(string.Join(" ",words));
            //Console.ReadKey();

            #endregion

            #region 练习三：从日期字符串中把年月日分别提取出来

            //Console.WriteLine("请输入日期：格式：xxxx年xx月xx日");
            //string date = Console.ReadLine();
            //string [] parts= date.Split('年','月','日');
            //Console.WriteLine("年：{0} 月：{1} 日：{2}",parts[0],parts[1],parts[2]);
            //Console.ReadKey();

            #endregion

            #region 练习四：把csv文件中的联系人姓名和电话显示出来
            
            //如果要读取的文件在bin\Debug路径下，代码可以这样写。
            //string[] lines = File.ReadAllLines("info.csv", Encoding.Default);
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    //将所有的 "\"" 替换成 空格 ""
            //    //string text = lines[i].Replace("\"", "");
            //    string[] parts=lines[i].Split(',');
            //    Console.WriteLine("姓名：{0} 电话：{1}",parts[0]+parts[1],parts[2]);
            //}
            //Console.ReadKey();
            
            #endregion

            #region 练习五: 123-456----789------123-----2把类似的字符串中的重复符号去掉，即得到123-456-789-123-2

            //string msg = "123-456----789------123-----2";
            //string[] numbers = msg.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //msg = string.Join("-", numbers);
            //Console.WriteLine(msg);
            //Console.ReadKey();

            #endregion

            #region 练习六: 从文件路径中提取文件名（包括后缀）       
            
            //方法一 截取文件名
            //string filePath = @"F:\info.csv";
            //Console.WriteLine(Path.GetFileName(filePath));
            
            //方法二 截取文件名
            //string filePath = @"F:\Substring\LastIndexOf\info.csv";
            //string fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);
            //Console.WriteLine(fileName);

            //Console.ReadKey();

            #endregion

            #region 练习七: ”192.168.10.5[port=21,type=ftp]“截取ip、端口号、服务，如果没有提供ftp服务则默认为http

            ////string s1 = "192.168.10.5[port=21,type=ftp]";
            ////string s1 = "192.202.168.23[port=1433,type=SQL Server]";
            //string s1 = "192.202.168.23[port=1433]";
            //string ip = string.Empty;//定义ip
            //string port = string.Empty;//定义端口
            //string servers = "http";//默认服务类型为http

            //ip = s1.Substring(0, s1.IndexOf("["));//截取ip

            ////判断字符串是否包含“,type=”
            //if (s1.Contains(",type="))
            //{
            //    //表示用户输入带服务类型
            //    //ip = s1.Substring(0, s1.IndexOf("["));//截取ip
            //    port = s1.Substring(s1.IndexOf("=")+1, s1.IndexOf(",")-s1.IndexOf("=")-1);//截取端口
                
            //    //方法一
            //    //servers = s1.Substring(s1.IndexOf("type=")+5, s1.IndexOf("]")-s1.IndexOf("type=")-5);//截取服务类型

            //    //方法二
            //    servers = s1.Substring(s1.LastIndexOf("=")+1, s1.Length - 1 - s1.LastIndexOf("=") - 1);

            //    Console.WriteLine("此服务带服务类型\nip为:{0} 服务端口：{1} 提供的服务类型：{2}",ip,port,servers);
            //}
            //else
            //{
            //    //表示用户输入不带服务类型
            //    port = s1.Substring(s1.IndexOf("=") + 1, s1.Length - 1 - s1.IndexOf("=") - 1);
            //    Console.WriteLine("此服务不带服务类型\nip为：{0} 服务端口:{1} 默认的服务类型：{2}",ip,port,servers);
            //}
            //Console.ReadKey();

            #endregion

            #region 练习八：求员工工资文件中，员工的最高工资、最低工资、平均工资

            string[] lines = File.ReadAllLines("Salary.txt",Encoding.Default);

            //假定第一行数据的工资是最高的工资
            string maxName = lines[0].Split('=')[0];//声明用户名，用于存储最高工资人的姓名
            double maxSalary = double.Parse(lines[0].Split('=')[1]);//声明工资变量，用于存储最高工资

            //假设第一个人的工资最低
            string minName = lines[0].Split('=')[0]; ;
            double minSalary = double.Parse(lines[0].Split('=')[1]);
            double sum = 0;
            int count = 0;
            
            for (int i = 0; i < lines.Length; i++)
            {
                //判断Salary里面是否有空行
                if (!string.IsNullOrEmpty(lines[i]))
                {
                    count++;//累加人数

                    string[] parts = lines[i].Split('=');
                    double _salary = Convert.ToDouble(parts[1]);
                    sum += _salary;

                    //计算最高工资
                    if (_salary > maxSalary)
                    {
                        //如果工资比maxSalary还大，则记录当前的工资姓名
                        maxSalary = _salary;
                        maxName = parts[0];
                    }
                    //计算最高工资
                    if (_salary < minSalary)
                    {
                        minSalary = _salary;
                        minName = parts[0];
                    }
                }               
            }
            Console.WriteLine("工资最高的人是：{0} 工资：{1}", maxName, maxSalary);
            Console.WriteLine("工资最低的人是：{0} 工资：{1}",minName,minSalary);
            Console.WriteLine("平均工资是：{0}",sum/count);//总工资除以人数
            Console.ReadKey();


            #endregion

        }

        //将传递进来的单词p中的每个字符都反转
        private static string WordReverse(string p)
        {
            char[] ch = p.ToCharArray();
            for (int i = 0; i < ch.Length/2; i++)
            {
                char tmp = ch[i];
                ch[i] = ch[ch.Length - 1 - i];
                ch[ch.Length - 1 - i] = tmp;
            }
            return new string(ch);
        }
    }
}
