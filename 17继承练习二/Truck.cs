using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17继承练习二
{
    public class Truck:Vehicie
    {
        //通过base调用父类的构造函数
        public Truck(string brand,string color)
            :base(brand,color)
        {

        }

        public string Weight
        {
            get;
            set;
        }

        public void ZaiZhong()
        {
            Console.WriteLine("汽车：{0} 颜色：{1}   货车在拉货。。。",Brand,Color);
        }
    }
}
