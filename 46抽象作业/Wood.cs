using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46抽象作业
{
    class Wood:BuHuiJiao,ISwim
    {
        public override void NOHuiJiao()
        {
            Console.WriteLine("不会叫的木鸭子。");
        }

        public void Swim()
        {
            Console.WriteLine("会漂的木鸭子。");
        }
    }
}
