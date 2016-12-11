using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46抽象作业
{
    class RealDuck:HuiJiao,ISwim
    {
        public override void YESHuiJiao()
        {
            Console.WriteLine("会叫的真实鸭子。");
        }

        public void Swim()
        {
            Console.WriteLine("会游泳的真实鸭子。");
        }
    }
}
