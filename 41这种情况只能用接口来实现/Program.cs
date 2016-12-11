using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41这种情况只能用接口来实现
{
    class Program
    {
        //1.在多继承的情况下，不能用类只能用接口。
        //2.这几个同类型但是没有同一个父类时，也只是用接口。
        static void Main(string[] args)
        {
            //小鸟在飞
            IFlyable birdfly = new Brid();
            birdfly.Fly();

            //飞机在飞
            IFlyable planefly = new Plane();
            planefly.Fly();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("吃东西。");
        }
    }
    //当多个类型，都具有某个或某几个功能时（方法），但是这几个类型又分属于不同的系列（这几个类型没有共同的父类，这时就不能用抽象类了）
    //所以这时，为了实现多态就可以考虑把这几个类型共有的方法提取到一个接口中，让这几个类型分别实现接口
    class Brid:Animal,IFlyable
    {

        public void Fly()
        {
            Console.WriteLine("小鸟在飞。");
        }
    }

    class Plane:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("飞机在飞。");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }
}
