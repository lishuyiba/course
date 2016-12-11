using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _152隐式类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //原本不能这样赋值
            //隐式类型转换
            //Person p = 10;

            //显示类型转换(强转)
            Person p = (Person)10;
        }
    }
    class Person
    {
        public int Age
        {
            get;
            set;
        }

        //自动帮我们转换了
        //public static implicit operator Person(int d)
        //{
        //    return new Person() { Age = d };
        //}

        ///需要显示转换了一下
        public static explicit operator Person(int d)
        {
            return new Person() { Age = d };
        }
    }
}
