using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39接口
{
    public interface IFIyable
    {
        //1.接口只能包含方法（方法、属性、索引器、事件）。
        //2.接口中的方法也不能有任何实现（就像抽象方法一样，直接加个分号）。
        //3.接口中的成员不能有任何访问修饰符（public也不可以），默认为public。
        //4.接口不能被实例化。
        void Fly();

        string Name
        {
            get;
        }
    }

    //实现接口的类，必须实现接口中所有成员
    class Person:IFIyable
    {

        public void Fly()
        {
            Console.WriteLine("人在飞。。。。");
        }

        public string Name
        {
            get
            {
                return "超人";
            }
        }
    }
}
