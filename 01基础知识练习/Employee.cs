using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01基础知识练习
{
    public  class Employee:Person
    {
        public double Salary
        {
            get;
            set;
        }
        public override void SayHi()
        {
            Console.WriteLine("大家好，我的名字叫{0}，工资是：{1}",Name,Salary);
        }
    }
}
