using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using _108对象序列化;


namespace _109反序列化
{
    class Program
    {
        /// <summary>
        /// 反序列化需要原来的程序集才能返回创建对象。
        /// </summary>
        static void Main(string[] args)
        {
            //反序列化步骤：
            //1.创建二进制序列化器（格式化器）
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Person.bin", FileMode.Open))
            {
                //2.开始反序列化
                //在执行反序列化的时候，由于要对Person.bin中是存储的是原来Person类型序列化后的结果，所以要对Person.bin反序列化时，需要Person类所在的程序集。

                //问题：为什么反序列化的时候需要原来定义Person类的那个程序集？
                //反序列化的时候，要返回一个对象，这个对象必须是根据原来Person所在的程序集才能创建，也就是说Person.bin中包含的仅仅是一些数据，根据这些数据是无法在内存中创建对象的
                //只能是根据原来Person类型的程序集来创建对象，然后把Person.bin中的数据一一对应进行赋值。
                //object obj = bf.Deserialize(fs);

                //对象序列化，只是对 对象的一些状态信息进行序列化（比如：字段）
                //对于方法之类的根本不进行序列化，也就是说Person.bin中包含字段名和字段值，根本没有方法信息。但是反序列化的时候，返回的是一个对象，那么只根据这些字段信息是无法创建对象的，
                //所以这个时候需要先根据原来的程序集获取Person类型，然后再内存中创建一个Person对象，然后再把反序列化得到的字段信息赋值给这个Person对象。
                Person per = (Person)bf.Deserialize(fs);
                Console.WriteLine("Name:{0} Age:{1}",per.Name,per.Age);
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
