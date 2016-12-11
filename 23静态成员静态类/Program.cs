using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23静态成员静态类
{
    class Program
    {
        //1.调用静态方法的时候必须通过类名直接来调用，不能通过对象来调用。
        //2.也就是说，使用静态成员不需要实例化对象。
        //3.静态成员会在整个程序退出时，才释放资源，所以可以在整个应用程序中共享数据。
        //4.静态类里面所有成员都必须是静态的
        //5.静态类不能被实例化，不能被继承。
        //6.由于静态成员会在整个程序退出时，才释放资源，所以尽量避免写静态或静态属性，最好只写静态方法。
        //7.当给一个普通类添加静态字段后，系统会默认为该类生成静态构造函数[静态构造函数不能有访问修饰符、并且也不能带参数]
        //8.静态类的构造函数，只会在第一次使用静态类之前，执行，并且只会执行一次。静态构造函数不能有访问修饰符，不能有参数。
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            //实例成员，可以直接点出来。
            mc.M1();

            //调用静态成员，必须通过 类名.方法名
            MyClass.M2();


            Person p = new Person("lsy");

            //string live= Person.liveHome;
            Console.WriteLine("我叫：{0}，我生活在：{1}",p.Name,Person.liveHome);


            //1.什么情况下要将一个类标记为静态类
            //  一般情况是，当这个类是一个工具类，里面都是方法，为了让用户调用方便，不需要要实例化对象，这时可以将该类标记为static类
            //  此时该类中只能包含静态成员，不能包含实例成员。比如：Conver、Math、File、Console....
            //2.什么情况下需要在一个普通类中编写一个静态成员，而这个类不能标记为static
            //  当这个类需要被实例化的时候，如果这个类中有一个成员是所有对象都共享数据，这时可以将该类中的这个成员标记为静态的，但是这个类还是一个实例类。
            Account account = new Account();
            account.Name = "lsy";
            account.Id = 123;
            account.balance = 100000;
            Console.WriteLine(account.Id);
            Console.WriteLine(account.Name);
            Console.WriteLine(account.balance);
            Console.WriteLine(Account.lilv);


            
            

            Console.ReadKey();
        }
    }

    class MyClass
    {
        public void M1()
        {
            Console.WriteLine("M1");
        }

        public static void M2()
        {
            Console.WriteLine("普通类中的一个静态方法。。。 M2");
        }
    }
}
