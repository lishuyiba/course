using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79泛型集合
{
    class Program
    {
        
        //======================复习========================
        //ArrayList  类型：object 查找需要遍历
        //Hashtable  类型：Key(object),val(object) 根据键就可以查找到（比ArrayList快）

        //List<T>
        //Dictionary<K,V>

        static void Main(string[] args)
        {
            //微软在新建类的时候，默认倒入了using System.Collections.Generic;泛型集合的命名空间，所以建议大家以后都是用泛型集合。

            //通过泛型就可以限定集合中存储的数据类型
            List<int> list = new List<int>();
            //int n = 10;//这是一个类型
            //list<int>//这是一个类型
            //增加数据的时候必须是对应的数据类型
            list.Add(10);
            //list.Add("yzk");//报错，因为已经限制了int类型
            list.Add(20);
            list.Add(30);
            Console.WriteLine("========求最大最小值======");
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Average());
            Console.WriteLine("==========================");
            for (int i = 0; i < list.Count; i++)
            {
                //由于增加的时候是int类型，所以取值的时候，获取到的值直接激素和int类型，无需转换。
                Console.WriteLine(list[i]);
            }
            //返回值类型变成了整数数组
            //int[] arrList = list.ToArray();
            Console.ReadKey();

        }
    }
}
