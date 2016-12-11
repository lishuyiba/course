using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44接口练习二
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student();
            student.Say();
            IShouZuoYe istudent = new Student();
            istudent.ShouZuoYe();

            Person teacher = new Teacher();
            teacher.Say();
            IShouZuoYe iteacher = new Teacher();
            iteacher.ShouZuoYe();

            Person xiaozhang = new XiaoZhang();
            xiaozhang.Say();
            IBuShouYeZuo ixiaozhang = new XiaoZhang();
            ixiaozhang.BuShouZuoYe();
            Console.ReadKey();
        }
    }
    
}
