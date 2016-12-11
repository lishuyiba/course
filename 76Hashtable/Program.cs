using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 旧代码

            //Hashtable hash = new Hashtable();
            //Person ac = new Person() { Name = "安超" };
            //hash.Add("安超", ac);

            //Person hsd = new Person() { Name = "何圣东" };
            //hash.Add("何圣东", hsd);

            //Console.WriteLine(((Person)hash["安超"]).Name);
            //Console.ReadKey();

            #endregion


            #region 判断数组中是否存在某个元素

            //int[] arrInt = { 25, 125, 225, 325, 456, 567, 654 };
            //int number = 325;
            //bool b = false;
            //for (int i = 0; i < arrInt.Length; i++)
            //{
            //    if (number == arrInt[i])
            //    {
            //        b = true;
            //        break;
            //    }
            //}
            //if (b)
            //{
            //    Console.WriteLine("存在！");
            //}
            //else
            //{
            //    Console.WriteLine("不存在！");
            //}
            //Console.ReadKey();

            #endregion

            #region 键的地址是算出来的，不是遍历查找的，所以“高性能”
            ////键的地址是算出来的，不是遍历查找的，所以“高性能”
            //int[] arrInt = { 25, 125, 225, 325, 456, 567, 654 };
            //int number = 125;
            //int index = number / 100;
            //if (index < arrInt.Length)
            //{
            //    Console.WriteLine("存在该数据！");
            //    Console.WriteLine(arrInt[index]);
            //}
            //else
            //{
            //    Console.WriteLine("不存在该数据！");
            //}
            //Console.ReadKey(); 
            #endregion


            #region 遍历 Hashtable

            Hashtable table = new Hashtable();
            table.Add("ac","anchao");
            table.Add("hsd", "heshengdong");
            table.Add("ylr", "yanlianren");
            //键和值一起遍历
            //foreach (DictionaryEntry item in table)
            //{
            //    Console.WriteLine(item.Key+"  "+item.Value);
            //}
            //Console.ReadKey();

            //单独遍历键
            foreach (var item in table.Keys)
            {
                Console.WriteLine(item+"------>"+table[item]);//输出键和值
            }
            Console.WriteLine("=====================");
            //单独遍历值
            foreach (var item in table.Values)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            #endregion


            #region 查找是否存在元素
            //Hashtable hash = new Hashtable();
            //Person ac = new Person() { Name = "安超" };
            //hash.Add("安超", ac);

            //Person hsd = new Person() { Name = "何圣东" };
            //hash.Add("何圣东", hsd);

            //#region 查找是否存在元素
            //if (hash.ContainsKey("李智"))
            //{
            //    Console.WriteLine("包含！");
            //}
            //else
            //{
            //    Console.WriteLine("不包含！");
            //}
            //#endregion

            ////可以根据键来删除某个元素
            ////hash.Remove("安超");

            //Console.WriteLine(((Person)hash["安超"]).Name);
            //Console.ReadKey(); 
            #endregion
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
