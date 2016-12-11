using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09继承
{
    public class Person : SuperMan
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
        public string Gender
        {
            get;
            set;
        }
    }
    public class SuperMan
    {
        public void Fly()
        {
            Console.WriteLine("超人会飞！");
        }
    }
    public class SuperMan2
    {
        public void Fly()
        {
            Console.WriteLine("超人会飞！");
        }
    }
}
