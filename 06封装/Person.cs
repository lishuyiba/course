using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06封装
{
    public class Person
    {
        private int _age;
        public int Age
        {
            get 
            {
                return _age;
            }
            set
            { 
                _age = value;
            }
        }
    }
}
