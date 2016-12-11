using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _96目录操作____Directory类
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory
            //创建“1”这个文件夹
            //Directory.CreateDirectory(@"f:\test\1");

            //创建目录
            //for (int i = 0; i < 100; i++)
            //{
            //    Directory.CreateDirectory(@"f:\test\" + i);
            //}
            //Console.WriteLine("ok");

            //获取当前目录下的所有的直接子目录
            //string[] dirs = Directory.GetDirectories(@"c:\");
            //foreach (var item in dirs)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("=======================================");
            //=========文件夹重载===========  获取当前目录含有“I”的文件夹。
            //string[] dirs = Directory.GetDirectories(@"c:\","*I*",SearchOption.TopDirectoryOnly);
            //foreach (var item in dirs)
            //{
            //    Console.WriteLine(item);
            //}


            //获取当前目录的所有文件。
            //============文件重载===============  获取当前目录含有后缀“.txt”的文件名。
            //string[] files = Directory.GetFiles(@"f:\","*.txt*",SearchOption.TopDirectoryOnly);
            //foreach (var item in files)
            //{
            //    Console.WriteLine(item);
            //}

            //判断某个目录是否存在某个文件夹
            //string path = @"f:\test";
            //if (Directory.Exists(path))
            //{
            //    Console.WriteLine("存在test目录！");
            //}
            //else
            //{
            //    Console.WriteLine("不存在test目录！");
            //}

            //删除f：\test1目录
            //如果不存在则删除的时候报异常，所以一般删除前都会加一个Diretory.Exists()判断目录是否存在。
            //Directory.Delect(路径)，这个重载，只能删除空目录，如果目录不为空，则报异常。
            //Directory.Delete(path);//只能删除空目录
            //Directory.Delete(path, true);//空目录或非空目录都会删除。true:表示，将当前目录及里面的所有内容都删除
            //Console.WriteLine("删除成功！");

            //文件移动操作
            //Directory.Move(@"f:\a\abc.txt", @"f:\b\abc.txt");//文件名也要写，否则会报异常。
            //Console.WriteLine("OK");

            //文件夹重命名
            //Directory.Move(@"f:\a", @"f:\abc");
            //Console.WriteLine("OK");

            //把一个文件夹当作一个对象来使用。
            //DirectoryInfo dirInfo = new DirectoryInfo(@"f:\abc");
            ////通过dirInfo对象，就可以获取f:\abc下所有的文件与文件夹
            //FileInfo[] fileinfo = dirInfo.GetFiles();
            //DirectoryInfo[] dinfos = dirInfo.GetDirectories();
            //Console.WriteLine("OK");


            Console.ReadKey();
        }
    }
}
