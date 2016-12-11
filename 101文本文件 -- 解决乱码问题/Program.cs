using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101文本文件____解决乱码问题
{
    class Program
    {
        static void Main(string[] args)
        {
            //由于计算机区域语言和微软VS文本编码的不同，为了中文不乱码，所以要加上Encoding.Default
            //Encoding.Default表示采用计算机默认的“区域和语言选项”中的编码格式
            //由于我们使用的计算机都是简体中文的，所以在使用计算机上默认新建的文本文件如果保存时编码显示为ANSI，则表示简体中文。
            //string txt = File.ReadAllText("1.txt",Encoding.Default);

            //第二个参数到底采用什么编码，要看文本文件存储的时候采用的时候什么编码。
            //string txt=File.ReadAllText("1.txt",Encoding.GetEncoding("gb2312"));//获取到简体中文
            //Console.WriteLine(txt);

            //查看VS支持哪个国家的编码

            EncodingInfo[] info = System.Text.Encoding.GetEncodings();//获取支持的文本文件国家
            List<string> list = new List<string>();
            for (int i = 0; i < info.Length; i++)//遍历的是info
            {
                list.Add(info[i].CodePage + "\t" + info[i].DisplayName + "\t" + info[i].Name);

            }
            File.WriteAllLines(@"f:\encodings.txt", list.ToArray());
            Console.WriteLine("OK");



            Console.ReadKey();
        }
    }
}
