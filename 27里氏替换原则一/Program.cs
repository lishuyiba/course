using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27里氏替换原则一
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 旧代码
            //Chinese cn = new Chinese();
            ////当需要一个父类类型对象的时候，可以给一个子类类型的对象
            ////将cn传递给person类型，发生了隐式类型转换。
            //Do(cn);

            //Person p = new Person();
            ////当需要一个子类类型对象，给一个父类类型对象是不可以的。
            ////Do1(p);

            //int n = 10;
            //double d = n;//隐式是类型转换

            //Person p = new Person();
            ////Chinese cn = p;
            //Chinese cn = (Chinese)p;//强制类型转换
            //cn.Name = "lsy";

            //Chinese cn = new Chinese();
            //cn.ClassId = "001";
            ////把子类类型赋值给父类类型，发生了隐式类型转换
            //Person p = cn;
            ////把父类类型变量赋值给子类类型，需要显示类型转换
            ////前提是如果这个父类类型变量p中，指向的确实是一个子类对象，如果p指向的不是Chinese，则显示转换会报异常。（转换失败）
            //Chinese cn1 = (Chinese)p;
            //Console.WriteLine(cn1.ClassId);
            //Console.ReadKey();

            ////判断一个对象是否属于某个类型。
            //if (cn is Person)
            //{

            //}

            #region 类型转换一
            //Person p = new Chinese();
            //p.Age = 100;
            ////位了避免显示类型转换报异常，可以提前判断一下类型
            //if (p is Chinese)//这里进行一次类型验证
            //{
            //    //类型转换
            //    Chinese cn = (Chinese)p;//在类型转换的时候又进行了一次类型验证。
            //    Console.WriteLine(cn.Age);
            //}
            //else
            //{
            //    Console.WriteLine("类型不匹配！");
            //}
            //Console.ReadKey();
            #endregion

            #region 类型转换二

            ////Person p = new Person();
            //Person p = new Chinese();
            ////Chinese cn = (Chinese)p;
            ////当通过as进行类型转换的时候，如果转换失败也不报异常，只是返回null

            ////只进行一次类型验证
            //Chinese cn = p as Chinese;//推荐使用as进行类型转换。
            //Console.WriteLine(cn.Age);
            //Console.ReadKey();

            #endregion
            #endregion

            #region 验证某个对象是否为某个类型
            QinHuangDaoRen ren = new QinHuangDaoRen();
            //GetType()是通过反射实现的。
            Console.WriteLine(ren.GetType().ToString());
            Console.WriteLine(ren.GetType().BaseType.ToString());
            Console.WriteLine(ren.GetType().BaseType.BaseType.ToString());
            Console.WriteLine(ren.GetType().BaseType.BaseType.BaseType.ToString());
            Console.WriteLine(ren.GetType().BaseType.BaseType.BaseType.BaseType.ToString());

            //object是没有父类的，所以object的父类是null.
            //Console.WriteLine(ren.GetType().BaseType.BaseType.BaseType.BaseType.BaseType.ToString());
            Console.ReadKey();
            #endregion

        }

        static void Do(Person p)
        {
            Console.WriteLine(p.Name);
        }
        static void Do1(Chinese cn)
        {
            Console.WriteLine(cn.Name);
        }
    }
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
    }
    public class Chinese : Person
    {
        public string ClassId
        {
            get;
            set;
        }
    }

    public class HeBeiRen : Chinese
    {

    }
    public class QinHuangDaoRen : HeBeiRen
    {

    }
}
