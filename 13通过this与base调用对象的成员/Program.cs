using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13通过this与base调用对象的成员
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Name = "lsy";

            stu.Car = new MyCar();
            

            stu.Test();
            Console.ReadKey();
        }
    }

    class MyCar
    { 
        
    }

    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public double Salary
        {
            get;
            set;
        }

        public MyCar Car
        {
            get;
            set;
        }
    }

    class Student:Person
    {
        public double Score
        {
            get;
            set;
        }

        public void Test()
        {
            //Console.WriteLine(this.Name);
            Console.WriteLine(base.Name);

            //在一般情况下，如果子类继承了父类的成员
            //那么在子类中，通过this.成员或base.成员都是访问的一样的
            //除非父类中德成员子类继承后又重写了。
            MyCar c1 = base.Car;
            MyCar c2 = this.Car;
        }
    }
}
