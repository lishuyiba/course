using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62可变参数params
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = Add(10,20,30,30);

            //可变参数可以传1个值，也可以传多个参数，也可以不传参数。
            //如果不为可变参数传值，则可变参数的数值是一个长度为0的数组，但是，不是null
            //int sum = Add();

            //可变参数也可以传递一个数组进来。
            int[] arr = {1,2,3,4,5,6,7,8,9,10 };
            int sum = Add(arr);

            Console.WriteLine(sum);
            Console.ReadKey();
        }
        //static int Add(int n, int m)
        //{
        //    return n + m;
        //}

        static int Add(params int[] arrInt)
        {
            int sum = 0;
            //遍历用户传递的每个参数。
            for (int i = 0; i < arrInt.Length; i++)
            {
                //sum+=arrInt[i];
                sum = sum + arrInt[i];
            }
            return sum;
        }

        //当一个方法中有多个参数时，并且还包含可变参数时，可变参数只能放在参数列表的最后。
        static int Test(int age, string name, params int[] arrInt)
        {
            return 0;
        }

    }
}
