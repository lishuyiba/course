using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103文件流的基本操作
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 通过文件流读取磁盘上的文件

            ////1.创建文件流
            //FileStream fsRead = new FileStream("1.txt", FileMode.Open);

            ////2.创建缓冲区
            //byte[] byts = new byte[fsRead.Length];

            ////3.开始读取
            //int r = fsRead.Read(byts, 0, byts.Length);

            ////4.关闭文件流、释放资源
            //fsRead.Close();
            //fsRead.Dispose();

            //string msg = System.Text.Encoding.UTF8.GetString(byts);
            //Console.WriteLine(msg);

            //Console.WriteLine("OK");
            //Console.ReadKey();

            #endregion


            #region 通过文件流写入文件

            //string msg = "我的名字叫中国。";

            ////1.创建文件流
            //FileStream fs = new FileStream(@"f:\myFileStream.txt", FileMode.OpenOrCreate);            

            ////2.创建byte[]
            //byte[] byts = System.Text.Encoding.UTF8.GetBytes(msg);

            ////3.将byts中的内容写入文件中
            //fs.Write(byts, 0, byts.Length);

            ////4.关闭文件流
            //fs.Flush();//把缓冲区的数据写入到文件中。
            //fs.Close();
            //fs.Dispose();

            //Console.WriteLine("写入成功！");
            //Console.ReadKey();
            
            #endregion


            #region using 建议使用这种方式写入文件

            //using (FileStream fs=new FileStream())
            //{
            //    fs.Read
            //}
            

            #endregion
        }
    }
}
