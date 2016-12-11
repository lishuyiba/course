using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09继承
{
    #region 旧代码
    // public class Teacher
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
    //    public double Salary
    //    {
    //        get;
    //        set;
    //    }

    //    public void AddStundet()
    //    {
    //        Console.WriteLine("添加一位学生！");
    //    }
    //}
    #endregion

    public class Teacher : Person
    {
        public double Salary
        {
            get;
            set;
        }

        public void AddStundet()
        {
            Console.WriteLine("添加一位学生！");
        }

    }
}
