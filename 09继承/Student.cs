using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09继承
{
    #region 旧代码
    //public class Student
    //{
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }
    //    public int Age
    //    {
    //        get;
    //        set;
    //    }
    //    public string Gender
    //    {
    //        get;
    //        set;
    //    }
    //    public string No
    //    {
    //        get;
    //        set;
    //    }
    //    public void LearnNet()
    //    {
    //        Console.WriteLine("学习！");
    //    }
    //}
    #endregion

    //继承的单根性，一个类同时只能继承一个父类。
    //public class Student:Person,NBAPlayer//报错，不能同时继承多个父类。
    public class Student : Person
    {
        public string No
        {
            get;
            set;
        }
        public void LearnNet()
        {
            Console.WriteLine("学习！");
        }
    }
   
}
