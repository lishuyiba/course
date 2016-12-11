using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _204通过WebClient操作FTP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FTP下载
            //WebClient wc = new WebClient();
            //wc.Credentials = new NetworkCredential("admin", "1");
            //wc.DownloadFile("ftp://127.0.0.1/1.jpg", @"f:\1.jpg");
            //Console.WriteLine("OK");
            //Console.ReadKey();
            #endregion

            #region FTP上传

            WebClient wc = new WebClient();
            wc.Credentials = new NetworkCredential("admin", "1");
            wc.UploadFile("ftp://127.0.0.1/2.jpg", @"f:\1.jpg");
            Console.WriteLine("OK");
            Console.ReadKey();

            #endregion

        }
    }
}
