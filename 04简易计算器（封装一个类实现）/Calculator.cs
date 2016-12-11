using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04简易计算器_封装一个类实现_
{
    public class Calculator
    {
        public Calculator(double txtNum1,double txtNum2)
        {
            this.Number1 = txtNum1;
            this.Number2 = txtNum2;
        }

        public double Number1
        {
            get;
            set;
        }
        public double Number2
        {
            get;
            set;
        }

        public double Add()
        {
            return Number1 + Number2;
        }
        public double Sub()
        {
            return Number1 - Number2;
        }
    }
}
