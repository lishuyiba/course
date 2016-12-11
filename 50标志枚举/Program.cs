using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _50标志枚举
{
    class Program
    {
        static void Main(string[] args)
        {
            //GoodPeople lyh = GoodPeople.白 | GoodPeople.富 | GoodPeople.高 | GoodPeople.美 | GoodPeople.帅;
            //#region 判断lyh的枚举中是否具有 白 这一项
            //if ((lyh & GoodPeople.白) == GoodPeople.白)
            //{
            //    Console.WriteLine("小伙子很白！");
            //}
            //else
            //{
            //    Console.WriteLine("不白！");
            //} 
            //#endregion
            //Console.WriteLine(lyh);
            //Console.ReadKey();

            #region 判断一个文件是否隐藏
            FileInfo info = new FileInfo(@"info.txt");
            if ((info.Attributes&FileAttributes.Hidden)==FileAttributes.Hidden)
            {
                Console.WriteLine("文件不是隐藏的！");
            }
            else
            {
                Console.WriteLine("文件是隐藏的！");
            }
            Console.ReadKey();
            #endregion


        }

        [Flags]//标志枚举，加上这个特性后枚举类型.ToString()返回的就是文字类型，不是数字了。
        public enum GoodPeople
        { 
            高=1,
            富=2,
            帅=4,
            白=8,
            美=16,
        }
    }
}
