using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56引用传递_值类型与引用类型
{
    class Program
    {
        static void Main(string[] args)
        {


            //值传递：传递的是栈中的内容
            //ref引用传递：传递的是栈本身的地址

            //对于值类型来说，栈中存储的就是直接使用的数据。
            //对于引用类型来说，栈中存储的就是栈中对象的地址。

            //参数传递的时候：
            //1〉值传递，传递的是栈中保存的数据。
            //2〉引用传递，传递的是栈本身的地址。


            //按引用传递，传递的是值类型
            int n = 10;
            M1(ref n);//ref表示引用传递
            Console.WriteLine(n);


            Person p = new Person();
            p.Name = "jk";
            M2(ref p);
            Console.WriteLine(p.Name);



            Console.ReadKey();
        }

        static void M1(ref int a)
        {
            a = a + 1;
        }
        static void M2(ref Person per)
        {
            per = new Person();
            per.Name = "sk";
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
