using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75集合
{
    class Program
    {
        //1.ArrayList
        //.Count属性，表示实际的元素个数
        //.Capactiy属性，表示当前集合的容量.Capactiy的容量是每次翻倍扩展的。
        //.Add(object)向集合众增加元素

        //2.Remove() 根据对象来删除
        //3.RemoveAt() 根据索引来删除
        static void Main(string[] args)
        {
            #region 旧代码

            //ArrayList arrList = new ArrayList();
            ////获得集合中实际存储的数据的个数，类似于数组的Length
            //Console.WriteLine(arrList.Count);
            //arrList.Add(10);
            //arrList.Add("yzk");
            //arrList.Add(9.9);

            ////Count是集合中实际的元素的个数，每次删除或增加Count都会被改变
            //arrList.RemoveAt(0);
            //arrList.RemoveAt(0);
            //arrList.RemoveAt(0);

            //arrList.Add(10);
            //arrList.Add("yzk");
            //arrList.Add(9.9);
            //arrList.Add(10);
            //arrList.Add("yzk");
            //arrList.Add(9.9);
            //arrList.Add(10);
            //arrList.Add("yzk");
            //arrList.Add(9.9);
            //arrList.Add(10);
            //arrList.Add("yzk");
            //arrList.Add(9.9);
            ////遍历删除8个元素
            //for (int i = 0; i < 8; i++)
            //{
            //    arrList.RemoveAt(i);
            //}
            ////将总容量“收缩”为实际容量
            //arrList.TrimToSize();

            //Console.WriteLine(arrList.Count);//实际个数
            //Console.WriteLine(arrList.Capacity);//容量
            //Console.ReadKey();

            #endregion

           
            Person p = new Person();
            p.Name = "jk";

            string[] names = { "yzk","sk","jk"};

            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("yzk");
            list.Add(p);
            list.Add(names);

            //=============删除元素============
            //1.根据索引来删除
            //list.RemoveAt(2);

            Person p1 = p;
            //删除的时候，是判断的p1与集合中的那个p是否为同一个对象，如果是同一个对象，则能删除，否则不能删除。
            list.Remove(p1);

            string s1 = new string(new char[]{'a','b','c'});
            string s2 = new string(new char[]{'a','b','c'});
            list.Add(s1);//添加的是s1

            for (int i = 0; i < list.Count; i++)
            {
                //list[i]获取每个元素。
            }

            list.Remove(s2);//s2没有添加到list，但是也可以把s2删除了。

            Console.ReadKey();



        }
    }
    class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
}
