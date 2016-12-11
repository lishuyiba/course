using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 查看数据类型的大小
            //Console.WriteLine(sizeof(byte));
            //Console.WriteLine(sizeof(char));
            //Console.WriteLine(sizeof(short));
            //Console.WriteLine(sizeof(int));
            //Console.WriteLine(sizeof(long));
            //Console.WriteLine(sizeof(double));
            //Console.WriteLine(sizeof(bool)); 
            #endregion

            #region int与string完全不是同一个类型，内存上没有交集，也没有子父类关系，所以不能进行类型转换
            //int n = 10;
            //string s = (string)n; 
            #endregion

            //隐式类型转换  小 转 大
            //int n1 = 10;
            //double d = n1;
            //Console.WriteLine(d);

            ////显示类型转换  大 转 小
            //double d1 = 99.8;
            //int n2 = (int)d1;
            //Console.WriteLine(n2);

            //把字符串转换成数值类型  
            #region Parse 这样转换出错会报异常
            string n = "123";
            //转int
            Console.WriteLine(int.Parse(n));

            //转double
            Console.WriteLine(double.Parse(n));

            //转byte
            Console.WriteLine(byte.Parse(n));
            #endregion

            //把字符串转换成数值类型  
            #region TryParse 这样转换不会报异常
            string str = "123";
            int result;
            bool b = int.TryParse(str, out result);
            if (b)
            {
                Console.WriteLine("转换成功！");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("转换失败！");
                Console.WriteLine(result);
            }
            #endregion


            //Convert可以把任意类型转换为任意类型
            string s = "false";
            bool bo = Convert.ToBoolean(s);
            Console.WriteLine(bo);
            Console.ReadKey();


            //数组是引用类型
            int[] arr = { 10, 20, 30, 40 };

            //所有的引用类型都是继承自 Object

            //所有的值类型都是继承自 System.ValueType而System.ValueType又继承了Object




            Console.ReadKey();
        }
    }


}
