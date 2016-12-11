using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _107StreamWtiter和StreamReader职工工资文件翻倍练习
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("Salary1.txt"))
            {
                using (StreamWriter sw=new StreamWriter("Salary2.txt"))
                {
                    string result;
                    while ((result = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(result);

                        //对每一行进行处理（工资翻倍）
                        string[] parts = result.Split('|');//去除“|”
                        parts[1] = (Convert.ToInt32(parts[1]) * 2).ToString();//工资翻倍
                        string newLine = string.Join("|", parts);//将parts[0]和parts[1]用“|”链接起来
                        Console.WriteLine(newLine);
                        sw.WriteLine(newLine);//
                    }
                }
                
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
