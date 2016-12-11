using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91泛型约束
{
    class Student
    { 
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person<Student, int, Car, Car, int, Student> p1 = new Person<Student, int, Car, Car, int, Student>();
            //p1.Age = "18";//报错，因为已经约束了类型
        }
    }

    class Person<T, T1,TC,TK,TV,TU>
        where T1 : struct//约束了T1必须是值类型
        where T : class//约束了T必须是引用类型
        where TC:new() //约束了这个类型必须带有一个无参数的构造函数[要求：1.构造函数不能为私有，2.类型不是抽象的]
        where TK:Car //这里约束了TK类型，必须是Car类型或者是Car类型的子类
        where TV:IComparable //约束了TV必须是实现IComparable接口的类型。
        where TU:T //约束了TU必须是T的子类。或者是T类型

    {
        public T Name
        {
            get;
            set;
        }
        public T1 Age
        {
            get;
            set;
        }
        public TC Car
        {
            get;
            set;
        }
    }
    class Car
    {
        public Car()
        {
            this.Brand = "捷安特";
        }

        public Car(string brand)
        {
            this.Brand = brand;
        }

        public string Brand
        {
            get;
            set;
        }
    }
}
