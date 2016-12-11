using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07把一个方法的多参数封装成一个对象
{
    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.Name = "李树逸";
            obj.Age = 18;
            obj.Gender = "男";
            ShowInfo(obj);
            Console.ReadKey();
        }

        static void ShowInfo(Person per)
        {
            Console.WriteLine("姓名：{0}，年龄:{1},性别：{2}",per.Name,per.Age,per.Gender);
        }
    }
}
