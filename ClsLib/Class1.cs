using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLib
{
    public class Class1
    {
        //可以声明一个字段，也可以当作参数来传递。
        public WriteTimeToDevDelegate WriteTime;

        public void Dosth()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("===========================================");
            Console.WriteLine("===========================================");
            Console.WriteLine("===========================================");
            Console.WriteLine("===========================================");

            //由于这里对于时间的操作，不同的用户操作方式不一样，所以这里的代码不能写死，如果写死了，则任何用户调用时都是执行同样的操作。
            //Console.WriteLine(System.DateTime.Now.ToString("当前时间：yyy-mm-dd-hh:mm:ss"));

            //File.WriteAllText(@"time.txt", System.DateTime.Now.ToString("当前时间：yyy-mm-dd-hh:mm:ss"));

            //为了不让这里的代码写死，所以可以在这里调用一个方法，但是这个方法中的代码不确定。这个方法中的代码由将来的调用者来决定。
            //由于这里的代码是不确定的，可变的。所以需要这里用一个，将来用户传递给这个变量什么代码，就执行什么代码。
            //因为大段代码都会用方法封装起来，所以这里最好是能直接传递一个方法过来。

            //委托作用：可以在某个代码内部，嵌入一段外部代码，相当于：注入
            //一般在调用委托前，或者在触发事件前，都要判断一下委托变量或者事件是否为null，如果不为null，再调用，如果为null，则不调用。
            if (WriteTime != null)
            {
                WriteTime();
            }


            Console.WriteLine("===========================================");
            Console.WriteLine("===========================================");
            Console.WriteLine("===========================================");
            Console.WriteLine("===========================================");
            Console.WriteLine("===========================================");
        }
    }
}
