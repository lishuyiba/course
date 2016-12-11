using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习一：把两个集合去除重复项合并成一个

            //ArrayList arrList1 = new ArrayList() { "a", "b", "c", "d", "e" };
            //ArrayList arrList2 = new ArrayList() { "d", "e", "f", "g", "h" };
            //ArrayList arrList3 = new ArrayList();
            //arrList3.AddRange(arrList1);//使用AddRange
            ////遍历arrList2
            //for (int i = 0; i < arrList2.Count; i++)
            //{
            //    //如果arrList3不包含arrList2的元素，就把它添加到arrList3
            //    if (!arrList3.Contains(arrList2[i]))
            //    {
            //        arrList3.Add(arrList2[i]);
            //    }
            //}
            //for (int i = 0; i < arrList3.Count; i++)
            //{
            //    Console.WriteLine(arrList3[i]);
            //}
            //Console.ReadKey();

            #endregion

            #region 练习二：随机生成10个1-100之间的数放到ArrayList中，并且10个数不能重复且都是偶数
            
            //ArrayList arrRandom = new ArrayList();
            //int index = 0;
            //Random random = new Random();
            ////只要集合众元素不够10就循环
            //while (arrRandom.Count < 10)
            //{
            //    index++;
            //    //通过random产生的都是伪随机数，伪随机数就需要一个种子。
            //    //只要种子一样，产生的随机数都是一样的。
            //    //=============不要把Random写到循环里面=============
            //    //Random random = new Random();
            //    //随机产生一个1-100之间的随机数
            //    int rd = random.Next(1, 101);
            //    //判断是否为偶数
            //    if (rd%2==0)
            //    {
            //        //判断arrRandom集合中的元素是否已存在
            //        if (!arrRandom.Contains(rd))
            //        {
            //            //如果不存在就添加到arrRandom集合中。
            //            arrRandom.Add(rd);
            //        }
            //    }
            //}
            ////遍历arrRandom
            //for (int i = 0; i < arrRandom.Count; i++)
            //{
            //    Console.WriteLine(arrRandom[i]);
            //}
            //Console.WriteLine("一共循环了：{0}次。",index);
            //Console.ReadKey();

            #endregion

            #region 练习三：分拣奇偶数 -- 有一个字符串是用空格分割的一系列整数，重新排列打印出来，奇数显示左边，偶数显示右边

            #region 自己写的

            //ArrayList arrLeft = new ArrayList();
            //ArrayList arrReght = new ArrayList();
            //ArrayList arrAll = new ArrayList();
            //string[] s = { "2", "7", "8", "3", "22", "9", "5", "11" };
            //for (int i = 0; i < s.Length; i++)
            //{
            //    int number = Convert.ToInt32(s[i]);
            //    if (number % 2 == 0)
            //    {
            //        arrReght.Add(number);
            //    }
            //    else
            //    {
            //        arrLeft.Add(number);
            //    }
            //}
            //arrAll.Add(arrLeft);
            //for (int i = 0; i < arrReght.Count; i++)
            //{
            //    arrAll.Add(arrReght[i]);
            //}
            //Console.ReadKey();

            #endregion

            string msg = "2 7 8 3 22 9 5 11";
            string[] nums = msg.Split(' ');

            ArrayList listOdd = new ArrayList();
            ArrayList listEven = new ArrayList();
            for (int i = 0; i < nums.Length; i++)
            {
                if (Convert.ToInt32(nums[i])%2!=0)
                {
                    listOdd.Add(nums[i]);
                }
                else
                {
                    listEven.Add(nums[i]);
                }
            }

            StringBuilder sb = new StringBuilder();

            listOdd.AddRange(listEven);
            for (int i = 0; i < listOdd.Count; i++)
            {
                sb.Append(listOdd[i] + " ");//字符串拼接
            }
            Console.WriteLine(sb.ToString());//拼接好后记得ToString()
            Console.ReadKey();

            #endregion

        }
    }
}
