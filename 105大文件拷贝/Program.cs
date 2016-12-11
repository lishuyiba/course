using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105大文件拷贝
{
    class Program
    {
        static void Main(string[] args)
        {
            //要想使用using必须实现IDispose这个接口，否则会报错。
            //using (Person p = new Person())
            //{
            //    Console.WriteLine("执行了using方法。");
            //}
            //Console.WriteLine("OK");
            //Console.ReadKey();

            string source = @"D:\迅雷下载\iPhone3,1_4.3_8F190_Restore.ipsw";
            string target = @"d:\1\iPhone3,1_4.3_8F190_Restore.ipsw";
            Console.WriteLine("文件正在拷贝...");
            CopyFile(source, target);
            Console.WriteLine("文件拷贝完毕！");
            Console.ReadKey();

        }

        private static void CopyFile(string source, string target)
        {
            //1.创建一个读取文件的流
            using (FileStream fsRead = new FileStream(source, FileMode.Open))
            {
                //2.创建一个写入文件的流
                using (FileStream fsWrite = new FileStream(target, FileMode.Create))
                {
                    //创建一个读取文件、写入文件的一个缓冲区
                    byte[] buffer = new byte[1024 * 1024 * 10];

                    //开始读取文件
                    long lenRead = fsRead.Length;
                    while (true)
                    {
                        //返回值r表示本次实际读取到的字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);

                        //将读取出来的buffer内容写入到fsWrite文件流中
                        if (r <= 0)//表示读取到了文件的末尾
                        {
                            //Console.WriteLine("文件读取到了结尾。");
                            break;
                        }
                        else
                        {
                            //如果r>0，则表示本次读取到了内容
                            fsWrite.Write(buffer, 0, r);

                            //方法一：
                            //long lenWrite = fsWrite.Length;
                            //double d = (double)lenWrite / lenRead;

                            //方法二：
                            //Position 属性表示当前流的位置。
                            double d = (double)fsWrite.Position / lenRead;
                            Console.WriteLine("拷贝进度:{0}%",d*100);
                        }
                    }
                }
            }
        }
    }
    class Person : IDisposable
    {
        public string Name
        {
            get;
            set;
        }

        public void Dispose()
        {
            Console.WriteLine("调用了IDispose方法。");
        }
    }
}
