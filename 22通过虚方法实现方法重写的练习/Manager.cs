using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22通过虚方法实现方法重写的练习
{
    class Manager:Employee
    {
        public override void DaKai()
        {
            Console.WriteLine("经理每天早上7：30打卡。");
        } 
    }
}
