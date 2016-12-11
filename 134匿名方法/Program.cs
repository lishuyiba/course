using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _134匿名方法
{
    #region 普通委托方法

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MyDelegate md = Test1;
    //        md();
    //        Console.ReadKey();
    //    }
    //    static void Test1()
    //    {
    //        Console.WriteLine("Test1");
    //    }
    //}
    //public delegate void MyDelegate();

    #endregion

    #region 匿名方法

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //把一个匿名方法赋值给了一个md委托变量（没有参数的匿名方法）
    //        MyDelegate md = delegate()
    //        {
    //            Console.WriteLine("Test1");
    //        };
    //        md();
    //        Console.ReadKey();
    //    }

    //}
    //public delegate void MyDelegate();

    #endregion

    #region 匿名方法（有参数）

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        YouDelegate yd = delegate(string message)
    //        {
    //            Console.WriteLine(message);
    //        };
    //        yd("有参数委托！");
    //        Console.ReadKey();
    //    }       
    //}
    //public delegate void YouDelegate(string msg);

    #endregion

    #region 匿名方法（带参数带返回值）

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        HisDelegate hd = delegate(int age)
    //        {
    //            age++;
    //            return age;
    //        };
    //        int s = hd(100);
    //        Console.WriteLine(s);
    //        Console.ReadKey();
    //    }
    //}
    //public delegate int HisDelegate(int age);

    #endregion

    #region lanbda表达式
    //lambda表达式的理解：lambda表达式其实就是个匿名方法，在linq编程下可以大量减少代码
    //linq（语言集成查询）
    //lambda其实就是一个匿名函数而已。
    //编译的时候会将lambda表达式编译成一个c#匿名方法
    //但是使用lambda表达式会在很多时候减少代码量。
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //MyDelegate md = () => { Console.WriteLine("aaaa"); };
            //md();

            //2.
            HisDelegate hd = x => { x = x + 1; return x; };
            int m = hd(10);
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
    public delegate void MyDelegate();
    public delegate int HisDelegate(int age);
    #endregion
}
