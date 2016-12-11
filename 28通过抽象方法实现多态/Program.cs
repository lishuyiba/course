using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28通过抽象方法实现多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Chinese cn = new Chinese();

            //抽象类是不能被实例化的。（抽象类的作用是为了让继承）
            //Person p = new Person();

        }
    }
    
    /// <summary>
    /// 这个类也必须标记为abstract（抽象）中。
    /// 抽象成员必须写在抽象类中，不能写在一个实例中。
    /// </summary>
    public abstract class Person
    {
        //表示自动属性
        public string Name
        {
            get;
            set;
        }

        //表示抽象属性，没有任何实现（不要与自动属性）
        //可以包含抽象方法、属性、索引器、事件。[其实这几个最后都是方法]
        public abstract int Age
        {
            get;
            set;
        }

        //1.抽象成员必须标记为abstract，并且不能有任何方法体。（不能有任何实现）
        //2.抽象方法必须在抽象类中。
        //3.抽象成员访问修饰符不能是private
        //4.抽象类不能被实例化。
        //5.子类继承抽象后，必须把父类中的所有抽象成员重写。（除非子类也是一个抽象类，则可以不重写）
        //6.抽象类中可以包含实例成员。
        //7.抽象类是有构造函数的，虽然不能被实例化。

        //===========================================
        //一、如果父类中的方法有默认的实现，并且父类需要被实例化，这时可以考虑将父类定义成一个普通类，用虚方法来实现多态。
        //二、如果父类中的方法没有默认实现，父类也不需要被实例化，则可以将该类定义为抽象类。
        public abstract void Show();
    }

    /// <summary>
    /// 父类中的抽象成员，子类继承以后必须重写（例外：除非子类也是一个抽象类）
    /// </summary>
    public class Chinese : Person
    {

        public override void Show()
        {
            Console.WriteLine("我是中国人！！");
        }

        public override int Age
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    /// <summary>
    /// 抽象类中
    /// </summary>
    public abstract class Japanese : Person
    { 
        
    }
}
