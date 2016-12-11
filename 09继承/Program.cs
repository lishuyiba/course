using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teacher teacher = new Teacher();
            ////teacher.Name;//继承了person类后可以new出姓名

            //Student student = new Student();
            ////student.Name;//继承了person类后可以new出姓名

            //1.C#中任何一个类都是继承自Object类。
            //2.如果一个类没有显示继承自任何类，则默认继承自Object类。

            //3.如果显示的指定了当前类继承自某个类，则将覆盖默认继承的Object类
            //4.==== 继承的传递性==== 
            //  SuperMan继承了Object，这时，SuperMan类中就有了从Object类中继承下来的4个方法ToString()、GetType()、GetHashCode()、Equals()。
            //  然后Person又继承了SuperMan，这时，Person会将SuperMan中的那4个方法继承下来。
            //  由于这4个方法是在Object中的，所以相当于Person类间接从Object类中继承下来了成员。
            //  这个就叫继承的传递性
        }
    }
}
