using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70比较两个对象是否同一个对象
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 什么是同一个对象？

            //什么才是同一个对象？
            //栈中的变量如果指向的是同一块内存，这个时候才叫同一个对象。
            //判断堆地址是否相同？


            //1.
            //Person p1 = new Person();
            //p1.Name = "lsy";
            //p1.Age = 18;
            //p1.Email = "lsy@sina.com";

            ////2.
            //Person p2 = new Person();
            //p2.Name = "lsy";
            //p2.Age = 18;
            //p2.Email = "lsy@sina.com";//p1与p2是同一个对象吗？ No

            ////3.
            //Person p3 = new Person();
            //p3.Name = "sk";
            //p3.Age = 17;
            //p3.Email = "sk@sina.com";

            ////4.
            //Person p4 = new Person();
            //p4.Name = "yzk";
            //p4.Age = 17;
            //p4.Email = "yzk@sina.com";//p3与p4是同一个对象吗？No

            //p4 = p1;//判断对象是否同一个对象，可以通过==或者对象 Equals()方法。

            //#region 方法一：程序判断是否同一个对象？
            //if (p1.Equals(p2))
            //{
            //    Console.WriteLine("同一个对象。");
            //}
            //else
            //{
            //    Console.WriteLine("不是同一个对象。");
            //}
            //#endregion

            //#region 方法二：

            //if (p3 == p4)
            //{
            //    Console.WriteLine("是同一个对象");
            //}
            //else
            //{
            //    Console.WriteLine("不是同一个对象");
            //}

            //#endregion

            //Console.ReadKey();

            //p4 = p1;//p4与p1是同一个对象吗？ YES

            #endregion

            //char[] ch = new char[] { };
            //string s1 = new string(ch);
            //string s2 = new string(ch);//这里的s1与s2肯定是两个对象。
            ////if (s1==s2)//但是通过 == 判断的时候，结果却是返回相同。
            ////由于string类型重写了从Object累中继承下来的Equals方法，怎么重写呢?
            ////只要两个字符串中的字符完全相同就返回true或者两个字符串是同一个对象也返回true
            //if (s1.Equals(s2))//通过 Equals 判断的时候，结果却是返回相同。
            //{
            //    Console.WriteLine("是同一个对象");
            //}
            //else
            //{
            //    Console.WriteLine("不是同一个对象");
            //}


            //Person p1 = new Person();
            //p1.Name = "yzk";

            //Person p2 = new Person();
            //p2.Name = "yzk";
            ////if (p1.Equals(p2))
            //if(object.ReferenceEquals(p1,p2))//这个才是判断对象是否相等的[方法]
            //{
            //    Console.WriteLine("是同一个对象");
            //}
            //else
            //{
            //    Console.WriteLine("不是同一个对象");
            //}


            //int n = 10;
            //double d = 10;
            //Console.WriteLine(n.Equals(d));

            Console.ReadKey();

            //== 、Equals
            //由于Equals方法子类可以重写，所以通过Equals方法判断是否同一个对象已经不准确了。
            //所以判断两个对象是否同一个对象用;object.ReferenceEquals();
            
            
        }
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
        public string Email
        {
            get;
            set;
        }

        //public override bool Equals(object obj)
        //{
        //    return this.Name == ((Person)obj).Name;
        //}

    }
}
