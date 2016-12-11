using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131委托
{
    class Program
    {
        //======================复习====================
        //一、委托理解：
        //1.数据类型。
        //2.并且还是引用类型。
        //3.使用委托的时候必须new一个对象。即便看到的代码没有new委托对象，编译器也会在编译时帮我们new赋值给委托的方法，其实是存储在委托对象中的。
        //通过委托可以访问到[访问修饰符]限制的代码。
        //可以把静态方法或者私有方法赋值给委托变量，赋值后，自要能用到该委托的地方就能使用该方法，打破了访问修饰符的限制。
        
        //二、委托使用步骤：
        //1.定义一个委托类型
        //  public delegate void WeiTuoDelegate();
        //2.声明一个委托变量
        //  WeiTuoDelegate wd=new WeiTuoDelegate(方法名);
        //3.调用委托
        //  if(wd!=null)
        //  {
        //      wd();
        //      wd.Invoke();
        //  }

        //三、什么情况下使用委托？委托有什么用？
        //当一个类型中需要嵌入一段代码，但是这段代码具有不确定性，是根据使用这个类型的用户来确定的，这种情况下就可以在该类型中使用一个委托
        //保证在某种情况下会调用该委托，这时，用户将对象的方法传递给该委托，则就会调用这个方法。
        
        //四、为什么要这样做？
        //因为让编写类的人可以先写好类，然后用类的人可以随意扩张里面的内容。
        //自定义控件中的事件会使用大量的委托（写事件的时候会用到委托）


        //定义委托：
        //1.使用delegate关键字
        //2.这个委托将来要存储的方法如果没有返回值，那么委托也要定义成void ，如果没有参数那么将来传递的方法也不能有参数
        //3.委托是一种数据类型，用的时候需要传递一个变量。


        public delegate void MethodDelegate();

        static void Main(string[] args)
        {
            //int n = 10;
            //Person就是一个数据类型，使用的时候需要实例化一个Person类型的对象来使用，通过class关键字定义
            //Person p = 10;
            //委托也是一样的，也是一个数据类型，使用的时候也需要new一个对象，通过detegate关键字定义委托。         

            //Test(M1);            

            //委托作为参数进行普通变量赋值
            //这只是一个简化的语法，其实编译器在编译的时候也帮我们new了一个委托对象。
            //MethodDelegate myMethod = M2;
            //myMethod(); 


            //也可以通过 new一个委托对象，将M2传递进去
            MethodDelegate my1 = new MethodDelegate(M2);
            my1();

            Console.ReadKey();

        }

        static void Test(MethodDelegate canshu)
        {
            canshu();
        }

        static void M2()
        {
            Console.WriteLine("这是M2方法！");
        }

        static void M1()
        {
            Console.WriteLine("这个是M1方法！");
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
