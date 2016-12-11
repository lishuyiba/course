using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10继承中得构造函数问题
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("李树逸",18,100);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Score);
            Console.ReadKey();
        }
    }

    class Person
    {
        //修正错误方法1：在父类中增加一个无参数的构造函数。
        //               这时子类的构造函数就可以找到父类中得无参数构造函数了。
        public Person()
        {

        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name)
        {
            this.Name = name;
            this.Age = 0;
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
    }
    //1.继承的时候，构造函数不能被继承。
    //2.子类的构造函数会默认去调用父类中的无参数的构造函数
    class Student : Person
    {
        //修正方法2：不能修改父类，而是在子类的构造函数后面通过：base()，显示的去调用父类的某个构造函数

        public Student(string name,int age,double score)
            :base(name,age)//base的作用1：在子类中调用父类的构造函数。
        {
            //this.Name = name;
            //this.Age = age;
            this.Score = score;
        }

        public double Score
        {
            get;
            set;
        }
    }
    class Teacher : Person
    {
        public Teacher(string name, int age, double salary)
            :base(name)
        {
            //this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }

        public double Salary
        {
            get;
            set;
        }
    }
}
