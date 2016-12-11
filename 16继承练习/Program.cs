using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Son son = new Son("lsy", 1000000000, BloodType.AB);
            son.PlayGame();
            Console.ReadKey();
        }
    }
    

}
