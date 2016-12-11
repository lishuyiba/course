using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11通过this调用自己的构造函数
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Person
    {

        public Person(string name,int age,string email,double salary)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.Salary = salary;
        }

        //this作用1：在当前类的构造函数后面通过 ：this 来调用当前类自己的其他构造函数
        public Person(string name)
            :this(name,0,null,0)
        {
            //this.Name = name;
        }

        public Person(string name,int age)
            :this(name,age,null,0)
        {
            //this.Name = name;
            //this.Age = age;
        }

        public Person(string name,string email)
            :this(name,0,email,0)
        {
            //this.Name = name;
            //this.Email = email;
        }



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
        public string Email
        {
            get;
            set;
        }
        public double Salary
        {
            get;
            set;
        }
    }
}
