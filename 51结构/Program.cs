using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //结构与类的最大最大的区别
            //结构是：值类型。
            //类是:引用类型。
            
            //结构体
            //值类型：把数据直接存在栈上。（特点：拷贝了地址一个副本）
            //引用类型：栈上存了个地址指向实际对应的那个数据。（特点：拷贝栈里的那个地址，指向同一个堆里面的对象）

            //结构不能继承，但是可以实现接口
            //使用结构的时候可以new也可以不new
            Student stu = new Student();
            stu.name = "lsy";
            stu.age = 18;
            stu.Email = "lsy@sina.com";
            stu.SayHi();
            Console.WriteLine(stu.Email);
            Console.ReadKey();
        }
    }

    //如果需要面向对象的特性，如果存储的数据量比较大则使用 类(数据大)。
    //如果存储的数据量比较小，不需要面向对象特性则使用 结构（数据小）。
    struct Student //struct 结构关键字
    {
        public string name;
        public int age;
        public string Email
        {
            get;
            set;
        }
        public void SayHi()
        {
            Console.WriteLine("Hi~_^");
        }
    }
}
