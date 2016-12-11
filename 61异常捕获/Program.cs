using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    NewMethod();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);//是指：捕获“throw new Exception("哈哈，出错了吧！");”这里的异常信息
            //    Console.WriteLine(ex.InnerException.ToString());//是指：捕获“throw new Exception(ex);”这里的信息
            //}
            //Console.ReadKey();

            #region 如果throw自己写异常，可以这样写
            Console.WriteLine("请输入您的名字：");
            string name= Console.ReadLine();
            if (name=="lsy")
            {
                throw new Exception("有异常，扛不住！");
            }
            else
            {
                Console.WriteLine("哈哈，没异常。");
            }
            #endregion

        }

        private static void NewMethod()
        {
            //这种写法只能在catch块中用。
            //throw;
            try
            {
                int n = 10;
                int m = 0;
                int s = n / m;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("===========================");
                Console.WriteLine(ex.Source);
                Console.WriteLine("===========================");
                Console.WriteLine(ex.StackTrace);
                throw new Exception("哈哈，出错了吧！", ex);
            }
        }
    }
}
