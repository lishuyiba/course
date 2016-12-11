using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _106通过文件流将文件加密
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncryptFile(textBox1.Text.Trim(), textBox2.Text.Trim());
            MessageBox.Show("数据加密成功！");
        }
        private void EncryptFile(string source, string target)
        {
            //1.创建一个读取文件的流
            using (FileStream fsRead = new FileStream(source, FileMode.Open))
            {
                //2.创建一个写入文件的流
                using (FileStream fsWrite = new FileStream(target, FileMode.Create))
                {
                    //创建一个读取文件、写入文件的一个缓冲区
                    byte[] buffer = new byte[1024 * 1024 * 10];

                    //开始读取文件
                    long lenRead = fsRead.Length;
                    while (true)
                    {
                        //返回值r表示本次实际读取到的字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);

                        for (int i = 0; i < buffer.Length; i++)
                        {
                            buffer[i] =(byte)(byte.MaxValue - buffer[i]);
                        }

                        //将读取出来的buffer内容写入到fsWrite文件流中
                        if (r <= 0)//表示读取到了文件的末尾
                        {
                            //Console.WriteLine("文件读取到了结尾。");
                            break;
                        }
                        else
                        {
                            //如果r>0，则表示本次读取到了内容
                            fsWrite.Write(buffer, 0, r);

                            //方法一：
                            //long lenWrite = fsWrite.Length;
                            //double d = (double)lenWrite / lenRead;

                            //方法二：
                            //Position 属性表示当前流的位置。
                            double d = (double)fsWrite.Position / lenRead;
                            Console.WriteLine("拷贝进度:{0}%", d * 100);
                        }
                    }
                }
            }
        }
    }
}
