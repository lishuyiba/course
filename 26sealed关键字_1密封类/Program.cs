using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26sealed关键字_1密封类
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chinese chinese = new Chinese();
            //Console.WriteLine("====OK====");
            //Console.ReadKey();


            Person p = new BeiJingRen();
            p.SayHi();
            Console.ReadKey();

        }
    }
    #region 不能被继承模拟
    ////public sealed class Person//不能别继承
    //public class Person
    //{
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }
    //    public int Age
    //    {
    //        get;
    //        set;
    //    }
    //    public string Email
    //    {
    //        get;
    //        set;
    //    }



    //}
    //class Chinese : Person
    //{

    //} 
    #endregion
    class Person
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

        public virtual void SayHi()
        {
            Console.WriteLine("Hi in Person!");
        }
    }
    class Chinese : Person
    {
        //禁止子类重写该方法
        public sealed override void SayHi()
        {
            Console.WriteLine("Hi in Chinese!");
        }
    }
    class BeiJingRen : Chinese
    {
        //public override void SayHi()
        //{
        //    Console.WriteLine("Hi in BeiJingRen!");
        //}
    }

}
