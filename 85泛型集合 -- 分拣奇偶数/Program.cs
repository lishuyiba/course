using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _85泛型集合____分拣奇偶数
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "2 7 8 3 22 9 5 11";
            List<string> listOdd = new List<string>();
            List<string> listEven = new List<string>();
            string[] nums = msg.Split(' ');
            for (int i = 0; i < nums.Length; i++)
            {
                //判断是否为偶数
                if (int.Parse(nums[i]) % 2 == 0)
                {
                    listEven.Add(nums[i]);
                }
                else
                {
                    listOdd.Add(nums[i]);
                }
            }
            listOdd.AddRange(listEven);//添加到listOdd集合里面
            string[]str= listOdd.ToArray();//转换成数组
            Console.WriteLine(string.Join(" ", str));//用Join来拼接字符串
            Console.ReadKey();

        }
    }
}
