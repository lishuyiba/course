using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34用代码来模拟计算机与移动存储设备数据的交换
{
    class Program
    {
        static void Main(string[] args)
        {
            UDisk u = new UDisk();
            HardDisk d = new HardDisk();
            MP3 mp3 = new MP3();
            Computer computer = new Computer();

            computer.Disk = d;
            computer.ReadData();
            computer.WirteData();
            Console.ReadKey();
        }
    }
}
