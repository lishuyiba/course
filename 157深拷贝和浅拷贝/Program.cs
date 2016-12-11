using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _157深拷贝和浅拷贝
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 浅拷贝
            //Person p1 = new Person();
            //p1.Name = "yzk";
            //p1.Age = 20;
            //p1.Email = "yzk@rupeng.com";
            //p1.DaiBu = new Car() { brand = "奥迪A2" };            

            ////================浅拷贝========================

            //Person p2 = new Person();
            //p2.Name = p1.Name;
            //p2.Age = p1.Age;
            //p2.Email = p1.Email;
            //p2.DaiBu = p1.DaiBu;

            ////c1和c2指向同一个对象
            //Car c1 = p1.DaiBu;
            //Car c2 = p2.DaiBu;

            #endregion

            #region 深拷贝

            //Person p1 = new Person();
            //p1.Name = "yzk";
            //p1.Age = 20;
            //p1.Email = "yzk@rupeng.com";
            //p1.DaiBu = new Car() { brand = "奥迪A2" };

            ////=================深拷贝================================
            //Person p2 = new Person();
            //p2.Name = p1.Name;
            //p2.Age = p1.Age;
            //p2.Email = p1.Email;
            //p2.DaiBu = new Car() { brand = p1.DaiBu.brand };


            ////这个根本不叫对象的拷贝
            ////对象的拷贝，无论是深拷贝还是浅拷贝都是又重新创建了一个对象。
            //Person p3 = p1;//这个根本没有重新创建对象。

            //Car c1 = p1.DaiBu;
            //Car c2 = p2.DaiBu;


            #endregion

            #region 请编程实现一个对象的深拷贝与浅拷贝

            #region 浅拷贝

            ////mc1和mc2的栈地址相同，堆地址不相同
            //MyClass mc1 = new MyClass();
            //mc1.Name = "yzk";
            //mc1.Age = 19;
            //mc1.MyCar = new Car() { brand = "捷安特" };

            //MyClass mc2 = mc1.QianKaoBei();

            //Car c1 = mc1.MyCar;
            //Car c2 = mc2.MyCar;

            #endregion

            #region 深拷贝

            MyClass mc1 = new MyClass();
            mc1.Name = "yzk";
            mc1.Age = 19;
            mc1.MyCar = new Car() { brand = "捷安特" };
            MyClass mc2 = mc1.QianKaoBei();
            Car c1 = mc1.MyCar;
            Car c2 = mc2.MyCar;

            Console.WriteLine("OK");
            Console.ReadKey();

            #endregion

            #endregion
           

        }
    }

    [Serializable]
    class MyClass
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public Car MyCar
        {
            get;
            set;
        }

        /// <summary>
        /// 实现一个浅拷贝
        /// </summary>
        public MyClass QianKaoBei()
        {
            //MemberwiseClone()这个方法就是把当前对象“浅拷贝”了一份
            return (MyClass)this.MemberwiseClone();
        }


        /// <summary>
        /// 实现一个深拷贝
        /// </summary>
        public MyClass ShenKaoBei()
        {
            //通过二进制序列化实现深拷贝
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, this);
                
                //设置Position回到一开始的位置。
                ms.Position = 0;

                //开始反序列化
                MyClass mcObj = (MyClass)bf.Deserialize(ms);
                return mcObj;
            }
        }



    }

    class Person
    {
        public Car DaiBu
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
    }

    [Serializable]
    class Car
    {
        public string brand
        {
            get;
            set;
        }
    }
}
