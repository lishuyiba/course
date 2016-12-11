using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80泛型集合_Dictionart
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary赋值取值

            //Dictionary<string, string> dict = new Dictionary<string, string>();
            ////赋值
            //dict.Add("yzk", "yangzhongke");
            //dict.Add("sk", "sukun");

            ////由于键不能重复，所以增加前先判断是否包含
            //if (!dict.ContainsKey("jiangkun"))
            //{
            //    dict.Add("jk", "jiangkun");
            //}

            ////取值
            //Console.WriteLine(dict.ContainsKey("jk"));//查找成功返回True
            //Console.WriteLine(dict["jk"]);
            //Console.ReadKey();

            #endregion


            Dictionary<Person, string> dict = new Dictionary<Person, string>();

            Person p1 = new Person() { Name="jk",Age=18};
            dict.Add(p1,p1.Name);

            //Console.WriteLine(dict[p1.Name].Age);

            //遍历键
            foreach (Person item in dict.Keys)
            {
                Console.WriteLine(item);
            }

            //遍历值
            foreach (string item in dict.Values)
            {
                Console.WriteLine(item);
            }

            foreach (KeyValuePair<Person,string> kv in dict)
            {
                Console.WriteLine("键：{0} 值：{1}",kv.Key,kv.Value);
            }

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
        public int Age
        {
            get;
            set;
        }
    }
}
