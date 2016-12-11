using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73若引用
{
    class Program
    {
        //若引用一般用在 那些创建比较耗时的对象。

        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 100;
            p = null;

            //当执行完p=null的时候，如果再想用p一开始指向的对象new Person();就不可能了。

            //若引用:
            Person p1 = new Person();
            p1.Age = 18;

            //Person p2 = p1;//“强引用”垃圾回收不能回收该对象。

            WeakReference wk = new WeakReference(p1);//若引用，垃圾回收可以回收该对象。

            p1 = null;//当执完这句话的时候。1.垃圾回收可以去回收p对象。2.通过若引用还可以访问到p

            //如果显示回收一下，则若引用就被回收了。
            GC.Collect();

            object pnew = wk.Target;
            //if (wk.IsAlive)
            //{
            //    object pp = wk.Target;
            //}
            if (pnew != null)
            {
                Console.WriteLine(((Person)pnew).Age);
            }
            else
            {
                Console.WriteLine("对象已经被回收！");
            }

            Console.ReadKey();
        }
    }
    class Person
    {
        public int Age
        {
            get;
            set;
        }
    }
}
