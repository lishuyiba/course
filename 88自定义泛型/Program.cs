using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88自定义泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            //T: Type parameters 其实就是一个占位符，将来用对应的类型来代替。
            //TKey,TValue,TOutput,TResult
            List<int> list = new List<int>();
            //list.Add(
            //Dictionary<

            //泛型目的：还是代码重用，在.net2.0版本才开始引入

            //int类型
            //MyList ml = new MyList();
            //Console.WriteLine(ml[4]);//访问索引器的下标

            //string类型
            //MyListString mls = new MyListString();
            //mls[0] = "sk";
            //mls[1] = "yzk";
            //Console.WriteLine(mls[1]);

            Console.WriteLine("================自定义泛型int===================");

            MyListGeneric<int> mlg = new MyListGeneric<int>();
            mlg[0] = 100;
            mlg[1] = 101;
            mlg[2] = 102;
            Console.WriteLine(mlg[2]);

            Console.WriteLine("==================自定义泛型string=================");

            MyListGeneric<string> mlgs = new MyListGeneric<string>();
            mlgs[0] = "yzk";
            mlgs[1] = "sk";
            Console.WriteLine(mlgs[1]);

            Console.WriteLine("================自定义泛型Person===================");

            Persom p1 = new Persom() { Name = "yzk", Age = 18 };
            Persom p2 = new Persom() { Name = "sk", Age = 19 };
            MyListGeneric<Persom> mlgPerson = new MyListGeneric<Persom>();
            mlgPerson[0] = p1;
            mlgPerson[1] = p2;
            Console.WriteLine(mlgPerson[1].Name);


            Console.ReadKey();
        }
    }

    /// <summary>
    /// int泛型
    /// </summary>
    class MyList
    {
        int[] arrInt = new int[] { 10, 20, 30, 40, 50, 60, 70 };
        public int this[int index]
        {
            get
            {
                return arrInt[index];
            }
            set
            {
                arrInt[index] = value;
            }
        }
    }

    /// <summary>
    /// string泛型
    /// </summary>
    class MyListString
    {
        string[] arrInt = new string[100];
        public string this[int index]
        {
            get
            {
                return arrInt[index];
            }
            set
            {
                arrInt[index] = value;
            }
        }
    }

    /// <summary>
    /// 自定义泛型
    /// </summary>

    //class MyListGeneric<T,K,V,Tot,T1>可以指定多个类型参数的，但是要用的时候也要传多个参数。
    class MyListGeneric<T>
    {

        #region 自定义数组长度
        //public MyListGeneric(int len)
        //{
        //    arr = new T[len];
        //}
        //private T[] arr; 
        #endregion

        T[] arr = new T[100];
        public T this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }

    /// <summary>
    /// 泛型的目的也是为了代码重用（算法重用）,代码结构，算法一摸一样，只是数据类型变了
    /// </summary>
    class Persom
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
    }
}
