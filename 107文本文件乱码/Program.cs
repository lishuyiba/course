using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _107文本文件乱码
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过判断文件的前几个字节就能判断文本的编码。
            byte[] byts1 = File.ReadAllBytes("1.txt");
            byte[] byts2 = File.ReadAllBytes("2.txt");
            byte[] byts3 = File.ReadAllBytes("3.txt");

            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
