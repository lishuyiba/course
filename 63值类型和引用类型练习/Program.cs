using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63值类型和引用类型练习
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = { 1,2,3};
            M1(arrInt);
            Console.WriteLine(arrInt[0]);//输出 1
            Console.ReadKey();
        }

        private static void M1(int[] arrInt)
        {
            arrInt=new int[3];
            arrInt[0] = arrInt[0] + 1;
        }
    }
}
