using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _92装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //装箱：将 [值类型] 转换为 [引用类型] 的过程叫装箱。
            //拆箱：将 [引用类型] 转换为 [值类型] 的过程叫拆箱。
            
            //1.
            //int n = 10;
            //object o = n;//发生装箱  值类型 --> 引用类型
            //int m =(int)o;//发生拆箱 引用类型 --> 值类型

            //2.
            //发生了类型转换，但是绝对不叫装箱和拆箱
            //由于字符串类型与int类型在内存上根本不存在“交集”，也根本无法发生类型转换
            //而object与int则可以发生转换，因为任何类型都是继承自object类型。
            //int n = 10;
            //string s1 = Convert.ToString(n);
            ////也不是拆箱
            //int m = int.Parse(s1);

            //3.
            //int n = 100;
            //object obj = n;//装修
            ////double d = (double)obj;//发生拆箱 报错！ 
            ////注意：装箱的时候，使用什么类型来装箱，拆箱的时候还是必须使用对象的类型来拆箱。
            //double d = (int)obj;//正确
            //Console.WriteLine(d);
            //Console.ReadKey();

            //4.
            //由于int32是结构，结构是值类型
            //由于int32还是实现了Icomparable接口，所以可以在int32和IComparable之间发生类型转换
            //又由于接口是引用类型，所以int32到IComparable发生了装箱，IComparable到int32发生了拆箱
            //int n1 = 10;
            //IComparable com = n1;//发生装箱
            //int m = (int)com;//发生拆箱
            //Console.WriteLine(m);
            //Console.ReadKey();

            //5.
            //int n = 10;
            //object obj = n;//装箱
            //int m = (int)obj;//拆箱
            //Console.WriteLine(m);
            //Console.ReadKey();

            //6.
            //Person p = new Person();//这个叫隐式转换，不叫装箱
            //Student stu = new Student();//这个叫显示转换，不叫拆箱

            //7.
            //string s1 = "a";
            //string s2 = "b";
            //int n3 = 10;
            //double d4 = 99.9;
            //string result = string.Concat(s1, s2, n3, d4);
            //Console.WriteLine(result);
            //Console.ReadKey();

        }
    }
}
