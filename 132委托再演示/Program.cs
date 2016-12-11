using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _132委托再演示
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodDelegate md = M1;
            MethodDelegate md = new MethodDelegate(M1);
            //md();这种调用方法，其实内部编译的时候还是调用了委托对象的Invoke()方法。
            md.Invoke();//当调用了Invoke()方法的时候就相当于调用了委托中存储的那些方法。
            Console.ReadKey();
        }
        static void M1()
        {
            Console.WriteLine("这是一个M1方法。");
        }
    }
    delegate void MethodDelegate();
}
