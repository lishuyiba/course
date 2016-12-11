using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34用代码来模拟计算机与移动存储设备数据的交换
{
    class UDisk:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘读取数据中。。。。。。");
        }

        public override void Write()
        {
            Console.WriteLine("U盘写入数据中。。。。。。");
        }
    }
}
