using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34用代码来模拟计算机与移动存储设备数据的交换
{
    class Computer
    {
        public MobileStorage Disk
        {
            get;
            set;
        }
        public void ReadData()
        {
            Disk.Read();
        }
        public void WirteData()
        {
            Disk.Write();
        }
    }
}
