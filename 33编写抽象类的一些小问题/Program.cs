using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33编写抽象类的一些小问题
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    #region 这样编写代码 没有提示
    //class Person
    //{
    //    类中成员如果不写访问修饰符默认为私有。
    //    abstract void SayHi();
    //    abstract void SayHello();
    //}
    //abstract class Student : Person
    //{

    //}
    #endregion

    #region 这样编写代码 有提示
    abstract class Person
    {
        public abstract void SayHi();
        public abstract void SayHello();
    }
    abstract class Student : Person
    {

    }
    #endregion

}
