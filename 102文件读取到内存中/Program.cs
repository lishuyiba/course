using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102文件读取到内存中
{
    class Program
    {
        static void Main(string[] args)
        {

            //byte[] byts = File.ReadAllBytes(@"f:\迅雷下载\产科男医生\[迅雷免费高清下载].产科男医生__第1集__720P高清.xv");
            //Console.WriteLine("ok");

            //源文件路径
            string source = @"f:\VS2010 sp1补丁 完整版离线包VS2010SP1dvd1.iso";

            //目标文件路径
            string target = @"f:\vs2010.iso";

            CopyFile(source, target);

            Console.ReadKey();

        }

        /// <summary>
        /// 大文件拷贝（使用文件流）
        /// </summary>
        private static void CopyFile(string source, string target)
        {
            //文件流使用的步骤：
            //1.创建一个文件流
            FileStream fs = new FileStream(source, FileMode.Open);

            //读或写
            //1个byte表示1个字节，然后表示8个bit即，8位。
            //byte[] byts = new byte[1024 * 1024 * 5];

            //2.每次读取内容都要放到缓冲区中。
            byte[] byts = new byte[fs.Length];

            //第一个参数:byts表示要将文件中的字节读取到该数组中。
            //第二个参数：从文件中读取的字节，要放到byts这个数组中，从第几个索引开始放。
            //第三个参数：这次最多读取多少个字节。
            //返回值r表示本次实际读取到了多少个字节。
            int r = fs.Read(byts, 0, byts.Length);

            //3.文件流使用完毕以后，记得关闭，并且释放非托管资源，调用了Dispose();
            fs.Close();
            fs.Dispose();


        }
    }
}
