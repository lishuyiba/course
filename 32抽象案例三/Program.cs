using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32抽象案例三
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            circle.GetArea();
            circle.GetZhouChang();
            Console.WriteLine("圆的面积："+circle.GetArea());
            Console.WriteLine("圆的周长：" + circle.GetZhouChang());

            Shape Square = new Square(2, 2);
            Square.GetArea();
            Square.GetZhouChang();
            Console.WriteLine("矩形的面积：" + Square.GetArea());
            Console.WriteLine("矩形的周长：" + Square.GetZhouChang());

            Shape Rectangle = new Rectangle(2, 2);
            Rectangle.GetArea();
            Rectangle.GetZhouChang();
            Console.WriteLine("正方形的面积：" + Rectangle.GetArea());
            Console.WriteLine("正方形的周长：" + Rectangle.GetZhouChang());

            Console.ReadKey();

        }
    }
}
