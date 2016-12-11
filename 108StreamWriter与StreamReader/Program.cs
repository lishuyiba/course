using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _108StreamWriter与StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {

            #region StreamWriter演示

            //创建了一个写文本文件的文件流
            //using (StreamWriter sw=new StreamWriter(@"f:\writer.txt",true,Encoding.GetEncoding("gb2312")))
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        sw.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("OK");
            //Console.ReadKey();

            #endregion


            #region StreamReader演示

            using (StreamReader sr=new StreamReader(@"f:\writer.txt"))
            {
                //1.
                //while (!sr.EndOfStream)//只要没有读到文本文件流末尾，就继续循环
                //{
                //    Console.WriteLine(sr.ReadLine());
                //}

                //2.
                //string result = sr.ReadLine();
                //while (result!=null)
                //{
                //    Console.WriteLine(result);
                //    result = sr.ReadLine();
                //}

                //3.
                //string result;
                //while ((result=sr.ReadLine())!=null)
                //{
                //    Console.WriteLine(result);
                //}



            }
            Console.WriteLine("读取完成！");
            Console.ReadKey();

            #endregion

        }
    }
}
