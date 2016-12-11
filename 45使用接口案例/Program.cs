using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45使用接口案例
{
    #region 旧代码
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Chinese cn = new Chinese();
    //        DengJi(cn);

    //        //Japanese jp = new Japanese();
    //        //DengJi(jp);

    //        Console.ReadKey();
    //    }
    //    static void DengJi(Chinese c)
    //    {
    //        Console.WriteLine("====开始登记====");
    //        c.Show();

    //    }
    //}
    //public class Chinese
    //{
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }
    //    public void Show()
    //    {
    //        Console.WriteLine("我是中国人，我的户口是。。。");
    //    }
    //}
    //public class Japanese
    //{
    //    public string Name
    //    {
    //        get;
    //        set;
    //    }
    //    public void Show()
    //    {
    //        Console.WriteLine("我是日本人，我的户口是。。。");
    //    }
    //} 
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Chinese cn = new Chinese();
            Japanese jp = new Japanese();
            Car c = new Car();
            DengJi(jp);

            Console.ReadKey();
        }
        //static void DengJi(Person c)
        //{
        //    Console.WriteLine("====开始登记====");
        //    c.Show();
        //}

        static void DengJi(IShow c)
        {
            Console.WriteLine("====开始登记====");
            c.Show();
        }

    }

    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public virtual void Show()
        {
            Console.WriteLine("我是中国人，我住。。。");
        }
    }

    public class Chinese:Person,IShow
    {
        public override void Show()
        {
            Console.WriteLine("我是中国人，我的户口是。。。");
        }

        void IShow.Show()
        {
            Console.WriteLine("中国人登记，我的户口是。。。");
        }
    }
    public class Japanese:Person,IShow
    {
        public override void Show()
        {
            Console.WriteLine("我是日本人，我的户口是。。。");
        }

        void IShow.Show()
        {
            Console.WriteLine("日本人登记，我的户口是。。。");
        }
    }

    public class Car : IShow
    {

        public void Show()
        {
            Console.WriteLine("车牌号码：京A8888");
        }
    }

    public interface IShow
    {
        void Show();
    }

}
