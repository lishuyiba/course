using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35抽象练习____鸭子
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck rubberduck = new RubberDuck();
            rubberduck.Swin();
            rubberduck.Bark();

            Duck realduck = new RealDuck();
            realduck.Swin();
            realduck.Bark();

            Console.ReadKey();
        }
    }
}
