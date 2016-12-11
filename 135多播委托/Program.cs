using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _135多播委托
{
    public delegate void MyDelegate();

    public delegate int YourDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //MyDelegate md = new MyDelegate(M1);
            //md += M2;
            //md += M3;
            //md += M4;
            //md += M5;
            ////多播委托中方法调用的顺序与增加方法时顺序是一致的。
            ////但是，不要依赖于这个顺序。
            //md();
            //Console.ReadKey();


            //2.
            //YourDelegate yd = new YourDelegate(T1);
            //yd += T2;
            //yd += T3;
            //yd += T4;
            //多播委托中，如果要是有返回值，只会得到最后一个方法调用的返回结果。
            //int x = yd();
            //Console.WriteLine(x);
            //Console.ReadKey();


            //3.==================多播委托调用时，获取每个委托的返回值=============
            //YourDelegate yd = new YourDelegate(T1);
            //yd += T2;
            //yd += T3;
            //yd += T4;
            ////通过遍历，调用委托中的每个方法，实现获取每个方法返回值。
            ////通过调用GetInvocationList（）方法，返回当前委托中所有的方法。
            ////返回值类型是一个Delegate数组（委托数组）
            ////所有定义的委托都是继承自抽象类MulticastDelegate而MulticastDelegate又继承自Delegate类（abstract）
           
            ////多播委托内部是将绑定在当前维多对象上的每个方法，都替换为一个委托对象，并且存储在了一个叫_invocationList的object数组中。
            ////然后当调用委托的时候，其实就是循环遍历_invocationList数组，并且调用其中的每一个委托。
            //Delegate[] delegates = yd.GetInvocationList();
            //foreach (Delegate delegateItem in delegates)
            //{
            //    YourDelegate ydelegate = (YourDelegate)delegateItem;
            //    int n = ydelegate();
            //    Console.WriteLine(n);
            //}
            //Console.ReadKey();


            //4.==============多播委托中德异常问题===========
            MyDelegate md = new MyDelegate(M1);
            //多播委托中，如果其中每个方法执行时发生了异常，则后续的方法不再执行。
            md += M3;
            md += M4;
            md = md + M2;
            md += M5;

            //去掉M4这个方法
            md = md - M4;

            //使用委托时，如果不是用+=而是直接使用=赋值，会将前面绑定的其他方法（委托）覆盖掉。
            md = M6;

            //多播委托中也是只能存储同一类型的委托。
            //md = md + T1;

            md();
            Console.ReadKey();
            



        }

        static int T1()
        {
            return 1;
        }
        static int T2()
        {
            return 2;
        }
        static int T3()
        {
            return 3;
        }
        static int T4()
        {
            return 4;
        }

        static void M1()
        {
            Console.WriteLine("方法1");
        }
        static void M2()
        {
            Console.WriteLine("方法2");
        }
        static void M3()
        {
            Console.WriteLine("方法3");
        }
        static void M4()
        {
            throw new Exception("我挂了！");
            //Console.WriteLine("方法4");
        }
        static void M5()
        {
            Console.WriteLine("方法5");
        }
        static void M6()
        {
            Console.WriteLine("我是M6");
        }
    }
}
