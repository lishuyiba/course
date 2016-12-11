using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01基础知识练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.1交换两个变量

            //int num1 = 10;
            //int num2 = 20;

            //int tmp;
            //tmp = num1;
            //num1 = num2;
            //num2 = tmp;
            //Console.WriteLine("num1={0},num2={1}",num1,num2);
            //Console.ReadKey();

            #endregion

            #region 1.2交换两个变量（不能声明第三个变量）
            //int num1 = 10;
            //int num2 = 20;
            //num1 = num1 + num2;
            //num2 = num1 - num2;
            //num1 = num1 - num2;
            //Console.WriteLine("num1={0},num2={1}",num1,num2);
            //Console.ReadKey();
            #endregion

            #region 1.3求两个数的最大值(用方法实现)
            //int num1, num2;
            //Console.WriteLine("输入第一个数：");
            //num1 =Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("输入第二个数：");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //int max = GetMaxVal(num1,num2);
            //Console.WriteLine("最大值是："+max);
            //Console.ReadKey();
            #endregion

            #region 1.4求1-100之间所有奇数的和
            //int sum = GetSum(100);
            //Console.WriteLine(sum);
            //Console.ReadKey();
            #endregion

            #region 1.5求数组中的最大值
            //int[] arrInt = new int[] {200,120,90,180,110 };
            ////当编译器想告诉你一些什么东西的时候
            ////按住 shift+alt+F10 然后按shift+M 即可生成该方法的存根
            //int max = GetMaxFromArray(arrInt);
            //Console.WriteLine(max);
            //Console.ReadKey();
            #endregion

            #region 1.6日期转换，将“2014年6月6日”转换成“二零一四年六月六日”
            //string date = "2014年6月6日";
            //date = ConvertDateToCn(date);
            //Console.WriteLine(date);
            //Console.ReadKey();
            #endregion

            #region 1.7测试
            //Employee emp = new Employee();
            //emp.Name = "李树逸";
            //emp.Age = 18;
            //emp.Gender = "男";
            //emp.Salary = 100000;
            //emp.SayHi();
            //Console.ReadKey();
            #endregion
        }

        #region 将“2014年6月6日”转换成“二零一四年六月六日” +string ConvertDateToCn(string date)
        private static string ConvertDateToCn(string date)
        {
            char[] ch = date.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                switch (ch[i])
                {
                    case '0':
                        ch[i] = '零';
                        break;
                    case '1':
                        ch[i] = '一';
                        break;
                    case '2':
                        ch[i] = '二';
                        break;
                    case '3':
                        ch[i] = '三';
                        break;
                    case '4':
                        ch[i] = '四';
                        break;
                    case '5':
                        ch[i] = '五';
                        break;
                    case '6':
                        ch[i] = '六';
                        break;
                    case '7':
                        ch[i] = '七';
                        break;
                    case '8':
                        ch[i] = '八';
                        break;
                    case '9':
                        ch[i] = '九';
                        break;
                }
            }
            return new string(ch);
        }
        #endregion

        #region 求数组中的最大值 +int GetMaxFromArray(int[] arrInt)
        private static int GetMaxFromArray(int[] arrInt)
        {
            int max = arrInt[0];
            for (int i = 0; i < arrInt.Length; i++)
            {
                if (arrInt[i] > max)
                {
                    max = arrInt[i];
                }
            }
            return max;
        }
        #endregion

        #region 定义一个方法，用来计算两个数的最大值 +int GetMaxVal(int n1,int n2)
        static int GetMaxVal(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
        #endregion

        #region 求1-100之间所有奇数的和 +int GetSum(int targetNum)
        /// <summary>
        /// 计算1-targetNum的奇数值
        /// </summary>
        static int GetSum(int targetNum)
        {
            int sum = 0;
            for (int i = 1; i <= targetNum; i++)
            {
                //sum += i;//计算所有数的和
                if (i % 2 != 0)//判断i是否为一个奇数
                {
                    sum = sum + i;
                    //sum += i;
                }
            }
            return sum;
        }
        #endregion
    }
}
