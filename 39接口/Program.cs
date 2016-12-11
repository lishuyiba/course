using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.子类继承抽象类，实现接口
            //2.接口的成员不能有实现，接口不能实例化
            //3.接口不能有访问修饰符，隐式公开public
            //4.接口中可以有属性、方法、索引器（都是方法），但不能有字段。
            //5.接口中所有成员必须被子类中全部实现。


            //============================================
            //
            //     接口 --> 抽象类 --> 父类 --> 具体类
            //
            //============================================

            IFIyable p = new Person();
            p.Fly();

            Console.ReadKey();
        }
    }
}
