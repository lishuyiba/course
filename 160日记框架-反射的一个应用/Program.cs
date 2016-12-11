using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160日记框架_反射的一个应用
{
    class Program
    {
        static LoggerClass logger = new LoggerClass();
        static void Main(string[] args)
        {
            logger.Log("==========Main函数启动时间："+DateTime.Now.ToString()+"===========");
            logger.Log("用户在：" + DateTime.Now.ToString() + "时间调用了Say()方法。");
            Console.WriteLine("OK");
            Console.ReadKey();
        }
        static void SayHi()
        {
            Console.WriteLine("SayHi");
        }
    }
    public class LoggerClass
    {
        public void Log(string msg)
        {
            using (StreamWriter sw = File.AppendText(@"f:\logger.txt"))
            {
                sw.WriteLine(msg);
            }
        }
    }
}
