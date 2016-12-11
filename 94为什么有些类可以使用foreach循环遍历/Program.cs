using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94为什么有些类可以使用foreach循环遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.可以遍历
            ArrayList arrlist = new ArrayList() { 10, 20, 30, 40, 50 };
            foreach (object item in arrlist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================================");

            //2.可以遍历
            string[] names = { "a", "b", "c" };
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================================");

            //3.可以遍历
            List<string> list = new List<string>() { "乔丹", "可比", "詹姆斯" };
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================================");

            //4.不可以遍历，需要自己写一个遍历的方法
            Person p = new Person();
            p[0] = "奇瑞QQ";
            p[1] = "infiniti";
            p[2] = "阿斯顿马丁";

            //for (int i = 0; i < p.Cout; i++)
            //{
            //    Console.WriteLine(p[i]);
            //}

            //任何类型，只要想使用foreach遍历，就必须在当前类型中存在public IEnumberable GetEnumerator()方法
            //一般情况我们会通过实现IEnumberable接口，来创建该方法。  

            //foreach (string item in p)
            //{
            //    Console.WriteLine(item);
            //}

            #region 其实foreach就是这样实现的

            IEnumerator etor = p.GetEnumerator();
            while (etor.MoveNext())
            {
                string str = etor.Current.ToString();
                Console.WriteLine(str);
            }

            #endregion


            Console.ReadKey();
        }
    }
    class Person : IEnumerable
    {
        private List<string> listCar = new List<string>();

        /// <summary>
        /// 只读属性
        /// </summary>
        public int Cout
        {
            get
            {
                return this.listCar.Count;
            }
        }

        /// <summary>
        /// 索引器
        /// </summary>
        public string this[int index]
        {
            get
            {
                return listCar[index];
            }
            set
            {
                //listCar[index] = value;
                if (index >= listCar.Count)
                {
                    listCar.Add(value);
                }
                else
                {
                    listCar[index] = value;
                }
            }
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

        //这个方法的作用不是用来遍历的，而是用来获取一个对象，这个对象才是用来遍历的。
        public IEnumerator GetEnumerator()
        {
            return new PersonEnumerator(listCar);
        }
    }

    //这个类型的作用就是用来遍历Person中List集合的。
    public class PersonEnumerator : IEnumerator
    {

        public PersonEnumerator(List<string> _cars)
        {
            cars = _cars;
        }
        //这个字段中存储的就是Person对象中的cars集合
        private List<string> cars;

        private int index = -1;

        #region 由接口生成
        //表示获取当前正在遍历的那个对象
        public object Current
        {
            get
            {
                if (index<0)
                {
                    return null;
                }
                return cars[index];
            }
        }

        public bool MoveNext()
        {
            index=index+1;
            if (index>=cars.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            index = -1;
        }
        #endregion
    }
}
