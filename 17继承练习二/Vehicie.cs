using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17继承练习二
{
    public class Vehicie
    {
        public Vehicie(string brand,string color)
        {
            this.Brand = brand;
            this.Color = color;
        }

        public string Brand
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }

        public void Run()
        {
            Console.WriteLine("汽车：{0} 颜色：{1}   汽车在行驶。。。",Brand,Color);
        }

    }
}
