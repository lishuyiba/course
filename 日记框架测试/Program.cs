using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 日记框架测试
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.启动Main方法额时候记录日记
            Log("============用户在："+DateTime.Now.ToString() + "启动了Main==============");

            Log("声明了一个int类型的变量n");
            //int n = 10;
            SayHi();
            Console.WriteLine("OK");
            Console.ReadKey();
        }
        static void SayHi()
        {
            Console.WriteLine("Hi");
        }
        static void Log(string msg)
        {
            //1.读取配置文件中用户指定的dll文件
            string dll = ConfigurationManager.AppSettings["DllPath"];
            //获取应用程序当前绝对路径
            Assembly asm = Assembly.LoadFile(Path.GetFullPath(dll));
            string className = ConfigurationManager.AppSettings["ClassName"];
            Type type = asm.GetType(className);
            MethodInfo method = type.GetMethod(ConfigurationManager.AppSettings["MethodName"]);
            if (method!=null)
            {
                method.Invoke(Activator.CreateInstance(type),new object[]{msg});
            }
        }
    }
}
