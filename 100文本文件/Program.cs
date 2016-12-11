using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100文本文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生乱码的原因（只有文本文件才会乱码）
            //文本文件存储时采用的编码与读取时采用的编码不一致，就会造成乱码问题，如果出现乱码一般就是编码的问题。
            //解决：采用统一的编码

            //文件编码
            //ASCII：英文码表，每个字符占一个字节
            //GB2312：兼容ASCII，包含中文。每个英文占一个字节（正数），中文占两个字节（负数）
            //GBK;简体中未能，兼容GB2312，包含更多汉字。英文占1个字节（正数），中文占两个（1个负数，1个可正可负）
            //Biq5：繁体中文
            //Unicode：国际码表，中文英文都占2个字节
            //UTF-8：国家码表，英文占1个字符，中文占3个字符
        }
    }
}
