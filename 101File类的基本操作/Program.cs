using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _101File类的基本操作
{
    class Program
    {
        static void Main(string[] args)
        {

            //File.ReadAllLines(@"f:\1.txt");//读取文本中的所有行，返回一个数组
            //File.ReadAllText(@"f:\1.txt");//读取所有文本
            //File.ReadAllBytes(@"f：\1.txt");//无论文本文件还是其他的文件，都读取到内存中，一个Bytes数组方式来读取的。

            //对应的Wrte方法
            //File.WriteAllLines(@"f:\1.txt");
            //File.WriteAllText(@"f:\1.txt");
            //File.WriteAllBytes(@"f:\1.txt");
            //File.AppendAllText(@"f:\1.txt");//追加，在不覆盖原来的内容情况下追加。

            //1.File类来判断文件是否存在？
            //if (File.Exists(@"f:\1.txt"))
            //{
            //    Console.WriteLine("文件存在！");
            //}
            //else
            //{
            //    Console.WriteLine("文件不存在！");
            //}
            ////如果文件不存在也不报异常
            //File.Delete(@"f:\1.txt");
            //Console.WriteLine("删除成功！");


            //2.拷贝文件
            //File.Copy(@"f:\1.txt", @"d:\1.txt");
            //Console.WriteLine("拷贝完成！");

            //File.Copy(@"f:\1.txt", @"d:\1.txt",true);//如果加true，则会覆盖掉原来的文件
            //Console.WriteLine("拷贝完成！");

            //3.剪切文件
            //File.Move(@"f:\1.txt", @"f:\1\1.txt");
            //Console.WriteLine("剪切成功！");

            //4.创建文件
            File.Create(@"f:\1\2.txt");
            Console.WriteLine("创建成功！");

            Console.ReadKey();

            
        }
    }
}
