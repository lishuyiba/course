using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37面向对象计算器
{
    public class Calculator
    {
        public int Number1
        {
            get;
            set;
        }
        public int Number2
        {
            get;
            set;
        }
        public int Add()
        {
            return Number1 + Number2;
        }
        public int Sub()
        {
            return Number1 - Number2;
        }
    }
}
