using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22通过虚方法实现方法重写的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习一
            //写代码 声明变量：尽量能用父类就不要用子类
            //                 能用接口就不要用抽象类
            //                 能用抽象类就不要用普通父类

            //多态、重写
            Employee em = new Manager();//声明一个父类类型的变量 指向 一个具体类型的子类类型变量
            em.DaKai();

            Employee ShaoGuoLuDe = new ShaoGuoLuDe();
            ShaoGuoLuDe.DaKai(); 
            #endregion

            #region 练习二
            Person student = new Student();
            student.SayHello();
            Person teacher = new Teacher();
            teacher.SayHello();
            Person siji = new SiJi();
            siji.SayHello(); 
            #endregion

            Console.ReadKey();
        }
    }
}
