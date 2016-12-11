using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref和out
{
    class Program
    {
        #region ref

        static void Main(string[] args)
        {
            #region ref
            ////某人的基本工资是1000块。
            //int salary = 1000;
            //M1(ref salary);
            //M2(ref salary);
            //M3(ref salary);
            //Console.WriteLine(salary); 
            #endregion

            #region out

            //ref主要是把一个值，带进去，再带出来。
            //out主要是把一个值返回。

            int x = 10;
            //int s = 99;
            int s;//由于out参数在方法中肯定被赋值了，所以，这里s可以不赋值。
            bool b = IsGreaterThanFive(x,out s);
            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.ReadKey();

            #endregion



            Console.ReadKey();
        }

        #region 只能返回一个参数
        //static bool IsGreaterThanFive(int n)
        //{
        //    if (n>5)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //} 
        #endregion

        /// <summary>
        /// 这个方法的作用是判断传递进来的参数是否大于5
        /// 当一个方法同时要返回多个值的时候，可以考虑使用out
        /// </summary>
        /// <param name="n"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        static bool IsGreaterThanFive(int n,out int val)
        {
            //即使在传递out参数时，赋值了，也不能用。
            //Console.WriteLine(val);
            //1.out参数，在方法中必须赋值。
            val = n - 5;

            if (n > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 1.计算奖金
        /// </summary>
        /// <param name="s"></param>
        static void M1(ref int s)
        {
            //在这些方法中直接使用了传递进来的参数s，在s原有值的基础上，再修改。
            //由于在这些方法中一开始就有可能使用参数s，所以在参数s传进来之前必须声明并赋值。
            s = s + 2000;
        }

        /// <summary>
        /// 2.全勤奖
        /// </summary>
        /// <param name="s"></param>
        static void M2(ref int s)
        {
            s += 1000;
        }

        /// <summary>
        /// 3.迟到
        /// </summary>
        /// <param name="s"></param>
        static void M3(ref int s)
        {
            s = s - 20 * 100;
        }

        #endregion
    }
}
