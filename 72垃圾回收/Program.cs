using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72垃圾回收
{
    class Program
    {
        //=====================复习=======================
        //垃圾回收
        //作用：提高内存利用率
        //什么样的对象才可以被垃圾回收？
        //1.引用类型
        //2.没有任何变量引用的对象
        //3.3代（减少了变量遍历范围）
        static void Main(string[] args)
        {

            IDisposable id = new IDisposable();
            //在id被垃圾回收之前要先调用Dispose（）方法来释放除内存外的其他资源。
            id.Dispose();

            //垃圾回收的目的：提高内存利用率 （CLR的一个核心功能 -- 垃圾回收）
            //垃圾回收器：只回收 托管堆中 的 内存资源，不回收其他资源。
            
            //M1();

            //1.
            Person p = new Person();
            p.Age = 18;
            
            //2.
            Person p1 = new Person();
            p = p1;//当执行完这句话后，一开始的p对象，已经没有任何变量指向了，所以这个时候，第一个p对象就可以被回收了。

            //3.
            Person p2 = new Person();
            //当对象没有变量指向的时候就可以被回收了。
            p2 = null;

            //4.
            List<Person> list = new List<Person>();
            Person p3 = new Person();
            list.Add(p3);
            p3 = null;//当执行完这句话的时候，Person对象依然不能被垃圾回收，虽然变量p3不指向Person对象了，但是还有一个List集合在引用着Person对象。所以Person依然不能被垃圾回收。

            //5.
            //手动调用垃圾回收。一般不需要手动调用垃圾回收，由系统自动调用。不要手动调用，因为垃圾回收有一系列的算法，需要移动对象等等，这时为了达到目的，需要暂停应用程序的已处理，这时如果频繁的调用垃圾回收反而会影响性能。
            GC.Collect();
            //垃圾回收机制：共3代，第一次所有的对象都在第0代，优先回收第0代，一直往1、2代移。
            //mark-and-compact（标记和压缩）垃圾回收采用代的概念，避免了每次垃圾回收都遍历所有的对象，减少了垃圾回收的时间。第0代的回收频率高，第1代次之，第2代再次。效果：越老的对象获得越长
            Console.ReadKey();
        }
        static void M1()
        {
            int n = 10;//n不会被垃圾回收，因为是值类型，它不在内存中。
            Console.WriteLine(n);
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
