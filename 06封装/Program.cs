using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06封装
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Age = 100;
            //Console.WriteLine(p.Age);
            //Console.ReadKey();


            //===================================
            ShowInfo("李树逸", 18, "男");
            Console.ReadKey();
        }

        static void ShowInfo(string name, int age, string gender)
        {
            Console.WriteLine("姓名：{0}，年龄：{1}，性别：{2}",name,age,gender);
        }
    }
}
