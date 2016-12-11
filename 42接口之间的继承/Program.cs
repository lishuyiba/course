using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42接口之间的继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //这样做是对的。BastStudent也是ISupperStudent的子类。
            ISupperStudent stu = new BaseStudent();
            stu.Fly();
            stu.laobao();
            Console.ReadKey();
        }
    }
    public interface IFlyable
    {
        void Fly();
    }
    public interface ISwimable
    {
        void Swim();
    }
    public interface IStudy
    {
        void XueXiNet();
    }

    //接口与接口之间的继承。
    public interface ISupperStudent:IFlyable,ISwimable,IStudy
    {
        void laobao();
    }

    //类与接口之间叫“实现”。
    public class BaseStudent : ISupperStudent
    {

        public void Fly()
        {
            Console.WriteLine("fly......");
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public void XueXiNet()
        {
            throw new NotImplementedException();
        }

        public void laobao()
        {
            Console.Write("我是两百万！");
        }
    }


}
