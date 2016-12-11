using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17继承练习二
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicie vehicie = new Vehicie("奔驰", "绿色");
            vehicie.Run();

            Truck truck = new Truck("卡车", "红色");
            truck.ZaiZhong();

            Car car = new Car("奥迪", "灰色");
            car.ZaiKe();
            Console.ReadKey();
        }
    }
}
