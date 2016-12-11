using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            //private
            //protected
            //internal
            //protected internal
            //public
        }
    }
    class MyClass:Person
    {
        public MyClass()
        {
            //name = "子类的内部访问，因为MyClass类继承了Person类";
        }
    }
}
