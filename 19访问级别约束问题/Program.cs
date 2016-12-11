using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19访问级别约束问题
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //1.在没有写访问修饰符的时候，自动默认为internal
    //2.类的访问修饰符只能是public或者是internal
    #region 继承，这样声明类是不可以的，因为子类的访问修饰符不能大于父类
    //class Person
    //{
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }
    //}
    //public class Student : Person
    //{ 

    //}
    #endregion

    #region 可访问性不一致，方法的参数和返回值的类型必须与方法本身的修饰符一致。

    //class Person
    //{
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }
    //}

    //public class MyClass//这里添加了public后会报错
    //{
    //    //要求方法参数的访问级别与方法本身的访问级别一致。
    //    public void Do(Person p)
    //    {
    //        Console.WriteLine(p.Name);
    //    }
    //}

    #endregion

    #region 访问行不一致，属性的访问级别与属性的类型访问级别

    //这样也会报错，因为方法Mc的返回值类型是MyClass类，而MyClass类的类型是internal，而Mc所在的类是public，所以这样声明会造成属性的访问级别与属性的类型访问级别不一致。
    //
    //class MyClass
    //{ 
        
    //}

    //public class Person
    //{
    //    public MyClass Mc
    //    {
    //        get;
    //        set;
    //    }
    //}

    #endregion

}
