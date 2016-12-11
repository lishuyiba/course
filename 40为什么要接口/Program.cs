using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40为什么要接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //体现了接口的多态。
            IPlayBasketball p = new Student();
            p.KouLan();

            
            Console.ReadKey();
        }
    }
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
    class NBAPlayer
    {
        public void KouLan()
        {
            Console.WriteLine("灌篮!");
        }
    }

    
    //public class Student : Person
    //{ 

    //}

    //1.类不能多继承，所以在某些情况下，只能用接口来代替，因为接口可以多实现
    //2.接口的主要目的：为了实现多态。
    //3.当一个类同时继承某个类，并且也实现了某些接口的时候，必须要将继承的类写在第一个 
    public interface IPlayBasketball
    {
        void KouLan();
    }

    

    public class Student : Person,IPlayBasketball
    {

        public void KouLan()
        {
            Console.WriteLine("学生在灌篮！");
        }
    }

    public class Teacher : Person,IPlayBasketball
    {

        public void KouLan()
        {
            Console.WriteLine("老师在灌篮！");
        }
    }
    public class Dog:IPlayBasketball
    {

        public void KouLan()
        {
            Console.WriteLine("狗狗在灌篮！");
        }
    }
}
