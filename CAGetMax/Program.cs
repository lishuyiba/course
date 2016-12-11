using ClsMaxLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAGetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 求年龄中最大值

            //int[] arrAge = { 16, 17, 18, 19, 20 };
            //Class1 c1 = new Class1();
            //int maxAge = c1.GetMax(arrAge);
            //Console.WriteLine(maxAge);
            //Console.WriteLine("OK");
            //Console.ReadKey();

            #endregion

            #region 求姓名中的最大值[姓名中字符多的]

            //Class1 c1 = new Class1();
            //string[] names = { "zhangsan", "lisi", "wangwu", "yangzhongke", };
            //string maxName = c1.GetMaxString(names);
            //Console.WriteLine(maxName);
            //Console.WriteLine("OK");
            //Console.ReadKey();

            #endregion

            #region 求最大的人

            //Person[] pers = { 
            //                    new Person(){Age=18,name="sk"},                              
            //                    new Person(){Age=19,name="yp"},
            //                    new Person(){Age=20,name="xhf"},
            //                    new Person(){Age=8,name="yxl"},
            //                };
            ////求Person中最大的人；
            ////1.年龄最大的人
            //Class1 c1 = new Class1();
            //Person pmax = c1.GetMaxPerson(pers);
            //Console.WriteLine("年龄最大的人是：{0} 年龄：{1}",pmax.name,pmax.Age);
            //Console.WriteLine("OK");


            ////2.姓名中字符书最多的。






            //Console.ReadKey();

            #endregion

            #region 通过委托实现通过的比较方法
            //======================年龄最大值===============================

            //object[] objAge = { 10, 11, 23, 89, 34, 56 };
            //Class1 c1 = new Class1();
            //object obj = c1.GetMaxObject(objAge, compareAge);
            //Console.WriteLine(obj.ToString());
            //Console.ReadKey();

            //======================求字符串的长度============================

            //object[] objs = { "jk", "sk", "yangzhongke" };
            //Class1 c1 = new Class1();
            //object obj = c1.GetMaxObject(objs, getMaxStringName);
            //Console.WriteLine(obj);
            //Console.ReadKey();

            //======================对Person求最大值===========================
            
            //Person[] objs = { 
            //                    new Person(){Age=18,name="sk"},                              
            //                    new Person(){Age=19,name="yp"},
            //                    new Person(){Age=20,name="xhf"},
            //                    new Person(){Age=8,name="yxl"},
            //                };
            //Class1 c1 = new Class1();
            //object obj = c1.GetMaxObject(objs, ComparePerson);
            //Console.WriteLine(((Person)obj).Age);
            //Console.ReadKey();



            #endregion

        }

        //对Person求年龄最大值
        static int ComparePerson(object max, object obj)
        {
            Person pmax = (Person)max;
            Person pobj = (Person)obj;
            return pmax.Age - pobj.Age;

        }


        //年龄最大值
        static int CompareAge(object max, object obj)
        {
            int n1 = Convert.ToInt32(max);
            int n2 = Convert.ToInt32(obj);
            return n1 - n2;
        }

        //求字符串的长度
        static int getMaxStringName(object max, object obj)
        {
            //string s1 = Convert.ToString(max);
            //string s2 = Convert.ToString(obj);
            //return s1.Length - s2.Length;
            return max.ToString().Length - obj.ToString().Length;
        }
    }

}
