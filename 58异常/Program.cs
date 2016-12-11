using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58异常
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.语法错误，语法错误一般编辑器会帮我们解决。

            //2.逻辑错误，编译没问题，执行不报异常，就是结果不对。
            //int n1 = 100;
            //int n2 = 200;
            //int sum = n1 - n2;
            //Console.WriteLine(sum);//把+号，写成了-号。逻辑错误

            //3.异常，在运行时发生不可预知的错误，叫异常。异常一般会导致程序崩溃。
            //Person p = new Person();
            //p = null;
            //p.Name = "yzk";
            //Console.WriteLine(p.Name);//空指针异常，未将对象引用设置到对象的实例
            //Console.ReadKey();

            //int n = 10;
            //int m = 0;
            //int sum = n / m;
            //Console.WriteLine(sum);//报异常：试图除以零。除数不能为0
            //Console.ReadKey();

            //string str = "abcd";
            //int n = Convert.ToInt32(str);//异常，输入字符串的格式不正确
            //Console.WriteLine(n);
            //Console.ReadKey();

            string str = "123";
            try
            {
                //把可能发生异常的代码用try块包围起来。
                //当程序在某条代码发生异常后，会直接跳转到catch块中，当前代码后面的代码都不会被执行。
                Console.WriteLine("程序开始执行！");
                Console.WriteLine("**********************！");
                int n = Convert.ToInt32(str);//异常，输入字符串的格式不正确
                Console.WriteLine(n);
                Console.WriteLine("**********************！");

            }
            catch (Exception)
            {
                //catch块中的代码，只有在程序发生异常后才会执行，如果程序不发生异常，则不执行catch块中的代码。
                //只有当try快中发生异常后，程序才会跳转到catch块中执行。
                Console.WriteLine("程序崩溃了！");
            }
            finally
            {
                //1.在finally块中的代码，即便某些异常没有被捕获，程序崩溃了，也要执行。
                //2.即便在try块中，有return语句，finally块中的代码还是会被执行。

                //因为finally中的代码无论程序是否发生异常都会被执行，所以一般会把一些释放内存，释放资源的代码放到finally块中，这样会保证最后这些代码一定会被执行。
                Console.WriteLine("此语句，无论是否发生异常都会被执行。");
            }

            Console.ReadKey();

        }
    }
    class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
}
