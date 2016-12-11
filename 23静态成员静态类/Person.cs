using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23静态成员静态类
{
    class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get;
            set;
        }
        public static string liveHome = "地球";
    }
}
