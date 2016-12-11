using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _95文件操作1____Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            //path类中的方法，基本都是对字符串的操作，与实际文件都没有关系。

            //1.
            //string path = @"F:\Substring\LastIndexOf\info.csv";
            ////这里只是把字符串“F:\Substring\LastIndexOf\info.csv”的后缀改成了“F:\Substring\LastIndexOf\info.jpg”
            ////只是修改了字符串，与实际存储在磁盘上的文件没有任何关系。
            //path = Path.ChangeExtension(path, ".jpg");
            //Console.WriteLine(path);


            //2.将两个路径连接起来，可以处理末尾的 \ 问题。
            //string s1 = @"c:\a\";
            //string s2 = @"b.txt";
            ////string s3 = s1 + s2;
            //string s3 = Path.Combine(s1, s2);
            //Console.WriteLine(s3);
            //Console.ReadKey();

            //3.获取路径中的文件名
            //string s1 = @"F:\Substring\LastIndexOf\info.csv";            
            //Console.WriteLine(Path.GetFileName(s1));

            //4.获取路径的目录（不包括文件名）
            //Console.WriteLine(Path.GetDirectoryName(s1));

            //5.获取文件名，不包含扩展名
            //Console.WriteLine(Path.GetFileNameWithoutExtension(s1));

            //6.获取扩展名
            //Console.WriteLine(Path.GetExtension(s1));

            //7.读取文本
            //string txt = File.ReadAllText("a.txt");
            //Console.WriteLine(txt);

            //8.获取相对路径对应的绝对路径。
            //Console.WriteLine(Path.GetFullPath("a.txt"));
            //Console.WriteLine(Path.GetFullPath("../../../../../../../../../a.txt"));

            //9.获取当前用户的临时目录。
            //Console.WriteLine(Path.GetTempPath());
           
            //10.
            //获取随机文件名，并在临时目录下创建这个文件
            //Console.WriteLine(Path.GetTempFileName());
            ////获取随机文件名（也可以用作文件夹名）
            //Console.WriteLine(Path.GetRandomFileName());

           

            Console.ReadKey();
        }        
    }
}
