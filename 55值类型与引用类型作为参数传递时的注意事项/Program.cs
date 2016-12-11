using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55值类型与引用类型作为参数传递时的注意事项
{
    class Program
    {
        static void Main(string[] args)
        {
            //（值传递）值类型与引用类型作为参数传递时的注意事项

            //========================1========================
            int x = 10;
            M1(x);
            Console.WriteLine(x);//输出  10

            //=======================2========================
            Person p1 = new Person();
            p1.Name = "yzk";
            M2(p1);
            Console.WriteLine(p1.Name); //输出 jk

            //========================3==========================
            Person pp1 = new Person();
            pp1.Name = "罗永浩";
            M3(pp1);
            Console.WriteLine(pp1.Name);//输出 罗永浩

            //=========================4==========================
            Person yzk = new Person();
            yzk.Name = "yzk";
            M4(yzk);
            Console.WriteLine(yzk.Name);//输出 jk

            //===========================5==========================
            Person p2 = new Person();
            p2.Name = "yzk";
            M5(p2);
            Console.WriteLine(p2.Name);//输出 yzk

            //==========================6=============================
            Person p3 = new Person();
            p3.Name = "yzk";    
            M6(p3);
            Console.WriteLine(p3.Name);//输出 jk

            Console.ReadKey();

        }
        static void M1(int n1)
        {
            n1 = n1 + 1;
        }

        static void M2(Person p11)
        {
            p11.Name = "jk";
        }

        static void M3(Person px)
        {
            Person p2x = new Person();
            px = p2x;
            px.Name = "sk";
        }

        static void M4(Person per)
        {
            per.Name = "jk";
            Person p = new Person();
            per = p;
            per.Name = "sk";
        }

        static void M5(Person p1)
        {
            p1 = new Person();
            p1.Name = "jk"; 
        }

        static void M6(Person p1)
        {
            p1.Name = "jk";
            p1 = new Person();
            p1.Name = "sk";
        }
    }
    class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
}
