using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _90泛型方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //泛型方法 -- 用法
            Person p = new Person();
            p.SayHi<string>("hi"); //泛型方法，类本身不是泛型的，只有调用该方法的时候需要指定一下。
            Console.ReadKey();
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

        //泛型方法
        public void SayHi<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}
