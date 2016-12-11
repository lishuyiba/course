using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104字符串到byte数组与byte数组到字符串之间的转换
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "我爱北京天安门";
            
            //把msg转换为byte字节数组
            byte[] byts = System.Text.Encoding.UTF8.GetBytes(msg);

            //再把byte数组转换为一个字符串
            string msgNew = System.Text.Encoding.UTF8.GetString(byts);

            Console.WriteLine(msgNew);
            Console.ReadKey();



        }
    }
}
