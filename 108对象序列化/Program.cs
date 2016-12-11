using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _108对象序列化
{
    class Program
    {
        //为什么要序列化？
        //方面存储和信息交换
        //序列化： 对象-->byte[]
        //作用：
        //1.直接存储对象
        //2.在网络中可以直接发送对象信息。


        //现在要想存储sly这个对象，只能将[“时绿艳”，16，“sly@126.com”]这些数据存储起来。
        //下次再用这些数据的时候，必须重新创建一个对象，然后这个对象属性的值来源于上一个对象。

        //思考：能不能直接把sly这个对象存储起来，这样的话，下次使用的时候直接拿来就是一个对象，不需要重新创建。
        static void Main(string[] args)
        {
            Person sly = new Person();
            sly.Name = "时绿艳";
            sly.Age = 16;
            sly.Email = "sly@126.com";
            sly.MyCar = new Car("QQ");



            //对象序列化的步骤：
            //1.创建二进制对象序列化器
            BinaryFormatter bf = new BinaryFormatter();

            //2.创建流
            using (FileStream fs = new FileStream("Person.bin", FileMode.Create))
            {
                //3.开始执行序列化
                bf.Serialize(fs, sly);//将对象sly，序列化到fs文件流中，最终sly就保存到了Person.bin文件中。
            }





            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }

    //Person类型要想被序列化
    //1.必须Person类型本身是可序列化的（Person类型标志为可序列号）[Person]
    //2.类中所有的字段属性的类型也必须标志为可序列化的 [Car]
    //3.当前类型的所有父类也必须标志为可序列化 [ShengWu]

    [Serializable]
    public class ShengWu
    {
        public void Say()
        {
            Console.WriteLine("新陈代谢！！！");
        }
    }

    [Serializable]
    public class Person:ShengWu
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }


        private Car _myCar;

        internal Car MyCar
        {
            get { return _myCar; }
            set { _myCar = value; }
        }

    }


    //2.
    [Serializable]
   public class Car
    {

        public Car(string brand)
        {
            this.Barnd = brand;
        }

        private string _barnd;
        public string Barnd
        {
            get
            {
                return _barnd;
            }
            set
            {
                _barnd = value;
            }
        }
    }
}
