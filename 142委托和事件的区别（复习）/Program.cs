using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _142委托和事件的区别_复习_
{
    class Program
    {
        static void Main(string[] args)
        {
            //委托和事件的区别：
            //1.委托和事件没有可比性，因为委托是类型，事件是对象（委托是数据类型，事件相当于是委托的一个变量，他们是没有什么太大的可比性的）
            //委托可以在外部调用，可以用“=”来赋值
            //事件只能在定义事件类内部来调用，可以用“+=”或者“-=”来赋值。
        }
    }
}
