using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46抽象作业
{
    class Program
    {
        static void Main(string[] args)
        {
            ISwim isrubber = new Rubber();
            isrubber.Swim();
            HuiJiao hjrubber = new Rubber();
            hjrubber.YESHuiJiao();

            ISwim iswood = new Wood();
            iswood.Swim();
            BuHuiJiao bhwood = new Wood();
            bhwood.NOHuiJiao();

            ISwim isrealduck = new RealDuck();
            isrealduck.Swim();
            HuiJiao hjrealduck = new RealDuck();
            hjrealduck.YESHuiJiao();


            Console.ReadKey();
        }
    }
}
