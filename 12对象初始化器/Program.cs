using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12对象初始化器
{
    class Program
    {
        static void Main(string[] args)
        {
            //对象初始化器（语法糖）
            //Person p = new Person() { Name="lsy",Age=18,Emial="lsyi@lsyi.com"};//对象初始化器
            //Console.WriteLine(p.Name);
            //Console.ReadKey();

            //集合初始化器
            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(20);

            List<int> list = new List<int>() { 10,20,30,40};//集合初始化器
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
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
        public string Emial
        {
            get;
            set;
        }
    }
}
