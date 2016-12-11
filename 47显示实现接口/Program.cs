using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFlyable fly = new Student();
            //fly.Fly();

            //ISupperMan ism = new Student();
            //ism.Fly();

            //这里调用的结果是IFlyable接口中的Fly方法。
            //因为显示实现接口后，被实现的方法变成了private的。所以通过类对象访问不到。
            //Student student = new Student();
            //student.Fly();

            #region 不管用哪个接口创建子类，都实现了MyClass里面的方法。
            //IFlyable ismm = new MyClass ();
            //ismm.Fly();

            //ISupperMan isuppter = new MyClass();
            //isuppter.Fly();
 
            //Console.ReadKey();
            #endregion

            #region 索引器

            //Chinese cn = new Chinese();
            //string str= cn[2];//取第二个元素的值。
            //Console.WriteLine(str);
            //Console.ReadKey();

            #endregion

            //接口不能被实现
            //IFlyable fly = new IFlyable();




        }
    }
    public interface IFlyable
    {
        void Fly();
    }
    public interface ISupperMan
    {
        void Fly();
    }

    public class Chinese
    {
        private string[] names = new string[] { "张三", "李斯", "王五" };
        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }
    }

    public abstract class Teacher : IFlyable
    {
        //子类，可以在实现接口的时候把接口中的方法实现为virtual或者是abstract，都可以。
        public abstract void Fly();
    }

    public class Student : IFlyable, ISupperMan
    {

        public void Fly()
        {
            Console.WriteLine("Fly方法，实现接口。11111111");
        }
        //显示实现接口目的：为了解决方法重名的问题。
        //类中的成员如果不写访问修饰符则默认为private
        //类如果不写访问修饰符默认是internal
        void ISupperMan.Fly()
        {
            Console.WriteLine("Fly方法，显示实现接口。22222222");
        }
        //这里由于Student类，实现两个接口的时候，都是通过“显示实现接口”来实现的，所以对于Student类来说，
        //这些实现接口的方法都是“私有”的，所以通过Student对象都无法访问。
        //void IFlyable.Fly()
        //{
        //    Console.WriteLine("IFlyable中的Fly方法");
        //}
    }

    //继承了两个接口，只有一个方法。
    //不报错，但是无法区分是哪个接口的Fly方法。
    public class MyClass : ISupperMan, IFlyable
    {

        public void Fly()
        {
            Console.WriteLine("fly.........333333333");
        }
    }
}
