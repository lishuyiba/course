using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35抽象练习____鸭子
{
    abstract class Duck
    {
        public void Swin()
        {
            Console.WriteLine("鸭子水上漂。。。。。");
        }
        public abstract void Bark();
    }
    class RubberDuck : Duck
    {

        public override void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫。。。");
        }
    }
    class RealDuck : Duck
    {

        public override void Bark()
        {
            Console.WriteLine("真是鸭子嘎嘎叫。。。。");
        }
    }
}
