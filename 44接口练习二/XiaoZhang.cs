using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44接口练习二
{
    class XiaoZhang:Person,IBuShouYeZuo
    {

        public override void Say()
        {
            Console.WriteLine("我是校长。");
        }

        public void BuShouZuoYe()
        {
            Console.WriteLine("校长不收作业。");
        }
    }
}
