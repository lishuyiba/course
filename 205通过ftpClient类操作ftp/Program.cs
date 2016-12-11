using Lvl.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _205通过ftpClient类操作ftp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 下载
            FtpClient fc = new FtpClient("127.0.0.1", "admin", "1");
            //fc.RemotePath = "/";
            bool b = fc.Download("1.jpg", @"f:\4.jpg");
            if (b)
            {
                Console.WriteLine("下载成功！");
            }
            else
            {
                Console.WriteLine("下载失败！");
            }
            Console.ReadKey(); 
            #endregion


            #region 上传

            //FtpClient fc = new FtpClient("127.0.0.1", "admin", "1");
            ////fc.MakeDirectory("xxx");
            //FileInfo file = new FileInfo(@"D:\ItCastCnDir\1.jpg");
            //fc.Upload(file, "5.jpg");
            //Console.WriteLine("上传完毕！");
            //Console.ReadKey();

            #endregion
        }
    }
}
