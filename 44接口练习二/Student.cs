using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44接口练习二
{
    class Student:Person,IShouZuoYe
    {

        public override void Say()
        {
            Console.WriteLine("我是学生。");
        }

        public void ShouZuoYe()
        {
            Console.WriteLine("学生收作业。");
        }
    }
}
