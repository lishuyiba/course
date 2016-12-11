using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16继承练习
{
    public class Daughter:Father
    {
        //女儿类
        //构造函数，采用base继承了父类的构造函数。
        public Daughter(string lastName, double property, BloodType type)
            : base(lastName, property, type)
        {

        }

        public void Dance()
        {
            Console.WriteLine("女儿类，跳舞方法！");
        }
    }
}
