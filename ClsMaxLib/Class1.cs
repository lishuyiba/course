using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsMaxLib
{
    public class Class1
    {
        /// <summary>
        /// 计算年龄的最大值
        /// </summary>
        public int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        /// <summary>
        /// 字符最多的人
        /// </summary>
        public string GetMaxString(string[] _names)
        {
            string max = _names[0];
            for (int i = 0; i < _names.Length; i++)
            {
                if (_names[i].Length > max.Length)
                {
                    max = _names[i];
                }
            }
            return max;
        }

        /// <summary>
        /// 年龄最大的人
        /// </summary>
        public Person GetMaxPerson(Person[] pers)
        {
            Person pmax = pers[0];
            for (int i = 0; i < pers.Length; i++)
            {
                if (pers[i].Age > pmax.Age)
                {
                    pmax = pers[i];
                }
            }
            return pmax;
        }

        //
        public object GetMaxObject(object[] objs, CompareDelegate BiJiaoFangShi)
        {
            object max = objs[0];
            for (int i = 1; i < objs.Length; i++)
            {
                //假设BiJiaoFangShi的返回值是整型，如果返回值是大于0表示max>obj[i]，如果返回值是0表示max==objs[i]，如果返回值是负数，表示max<objs[i]
                //-1 小
                //0  等
                //1  大
                if (BiJiaoFangShi(max, objs[i]) < 0)
                {
                    max = objs[i];
                }
            }
            return max;
        }

    }
    public class Person
    {
        public string name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
    }
}
