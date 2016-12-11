using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34用代码来模拟计算机与移动存储设备数据的交换
{
    class MP3:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3读取数据中。。。。。");
        }

        public override void Write()
        {
            Console.WriteLine("MP3写入数据中。。。。。");
        }
        public void PlayMusic()
        {
            Console.WriteLine("音乐播放中。。。。。");
        }
    }
}
