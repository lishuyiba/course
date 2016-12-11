using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17继承练习二
{
    public class Car:Vehicie
    {
        //通过base调用父类的构造函数
        public Car(string brand,string color)
            :base(brand,color)
        {

        }
        public int Passenger
        {
            get;
            set;
        }

        public void ZaiKe()
        {
            Console.WriteLine("汽车：{0} 颜色：{1}   载客。。。",Brand,Color);
        }
    }
}
