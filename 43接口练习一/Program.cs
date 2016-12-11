using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43接口练习一
{
    class Program
    {
        static void Main(string[] args)
        {
            //父类
            BirdEat be1 = new Sparrow();
            be1.Eat();

            //接口
            IBridFly ibridfly = new Sparrow();
            ibridfly.Fly();

            BirdEat be2 = new Ostrich();
            be2.Eat();

            BirdEat be3 = new Penguin();
            be3.Eat();

            BirdEat be4 = new Parrot();
            be4.Eat();
            IBridFly be5 = new Parrot();
            be5.Fly();

            Console.ReadKey();

        }
    }

    public abstract class BirdEat
    {
        public abstract void Eat();
    }

    public interface IBridFly
    {
        void Fly();
    }

    public class Sparrow : BirdEat, IBridFly
    {


        public void Fly()
        {
            Console.WriteLine("麻雀会飞！");
        }

        public override void Eat()
        {
            Console.WriteLine("麻雀会吃！");
        }
    }
    public class Ostrich : BirdEat
    {

        public override void Eat()
        {
            Console.WriteLine("鸵鸟只会吃，不会飞！");
        }
    }
    public class Penguin : BirdEat
    {

        public override void Eat()
        {
            Console.WriteLine("企鹅只会吃，不会飞！");
        }
    }
    public class Parrot : BirdEat, IBridFly
    {

        public override void Eat()
        {
            Console.WriteLine("鹦鹉会吃！");
        }
        //实现接口的时候直接写方法就可以了，不需要override关键字
        public void Fly()
        {
            Console.WriteLine("鹦鹉会飞！");
        }
    }
}
