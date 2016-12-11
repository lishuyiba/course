using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46抽象作业
{
    public class Rubber:HuiJiao,ISwim
    {
        public override void YESHuiJiao()
        {
            Console.WriteLine("会叫的橡皮鸭子。");
        }

        public void Swim()
        {
            Console.WriteLine("会漂的橡皮鸭子。");
        }
    }
}
