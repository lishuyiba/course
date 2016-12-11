using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _196MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入一个字符串：");
            //string msg = Console.ReadLine();
            //string md5 = Md5Encrypt(msg);
            //Console.WriteLine(md5);
            //Console.WriteLine("ok");
            //Console.ReadKey();

            #region MyRegion

            Console.WriteLine("请输入一个文件路径：");
            string path = Console.ReadLine();
            string md5 = Md5EncryptFromFile(path);
            Console.WriteLine(md5);
            Console.ReadKey();

            #endregion

        }

        /// <summary>
        /// 计算文件MD5
        /// </summary>
        private static string Md5EncryptFromFile(string path)
        {
            MD5 md5 = MD5.Create();
            using (FileStream fs=File.OpenRead(path))
            {
                byte[] md5Buffer = md5.ComputeHash(fs);
                md5.Clear();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < md5Buffer.Length; i++)
                {
                    sb.Append(md5Buffer[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// 计算字符串MD5
        /// </summary>
        private static string Md5Encrypt(string msg)
        {
            //创建一个MD5对象
            MD5 md5 = MD5.Create();

            //2.把字符串变为一个byte[]
            //对于中文或者某些字符，采用不同的编码生成的byte[]是不一样的，所以造成了采用不同编码生成的md5值不一样的情况。
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);

            //3.将一个byte[]通过MD5计算得到一个新的byte[]，新的byte[]就是计算后的MD5值
            byte[] md5Buffer = md5.ComputeHash(buffer);
            
            //释放资源
            md5.Clear();


            //4.将计算后的结果直接显示为字符串
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < md5Buffer.Length; i++)
            {
                //x表示16进制，2表示保留一位整数前面的0，比如：7 -> 07
                //x2：把每个数字转换为16进制，并保留两位数字。
                sb.Append(md5Buffer[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
