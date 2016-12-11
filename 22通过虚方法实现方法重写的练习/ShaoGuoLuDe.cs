using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22通过虚方法实现方法重写的练习
{
    class ShaoGuoLuDe:Employee
    {
        public override void DaKai()
        {
            Console.WriteLine("晚上12：00打开。");
        }
    }
}
