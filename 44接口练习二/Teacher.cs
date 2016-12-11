using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44接口练习二
{
    class Teacher:Person,IShouZuoYe
    {
        public override void Say()
        {
            Console.WriteLine("我是老师。");
        }

        public void ShouZuoYe()
        {
            Console.WriteLine("老师收作业。");
        }
    }
}
