using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211递归案列
{
    class Program
    {
        static void Main(string[] args)
        {
            //T1();
            //Console.ReadKey();

            //M1(0);
            //Console.ReadKey();

            #region 计算1-100之间所有整数的和（使用循环）

            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    //sum = sum + i;
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            #endregion


            #region 计算1-100之间所有整数的和（使用递归）

            //int sum = GetSum(100);
            //Console.WriteLine(sum);
            //Console.ReadKey();

            #endregion

            //1 1 2 3 5 8 13 21 34 55 89  .......  后一个数是前两个数的和
            //菲薄纳妾 fibonacci            

            int r= Foo(11);
            Console.WriteLine(r);
            Console.ReadKey();

        }

        public static int Foo(int i)
        {
            if (i==0)
            {
                return 0;               
            }
            else if (i<2)
            {
                return 1;
            }
            else
            {
                return Foo(i - 1) + Foo(i - 2);
            }
        }

        private static int GetSum(int n)
        {
            if (n==1)
            {
                return 1;
            }
            else
            {
                return n + GetSum(n - 1);
            }
        }

        #region 递归案例2
        private static void M1(int n)
        {
            Console.WriteLine("A" + n);
            n++;
            if (n < 3)
            {
                M1(n);
            }
            Console.WriteLine("B" + n);
        }
        //A0A1A2B3B2B1 
        #endregion

        #region 递归案例1
        static int index = 0;
        private static void T1()
        {
            Console.WriteLine("A");
            if (index < 3)
            {
                index++;
                T1();
            }
            Console.WriteLine("B");
        }
        //AAAABBBB 
        #endregion


    }
}
