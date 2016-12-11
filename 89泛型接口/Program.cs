using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89泛型接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //泛型接口用法
            MyClass1<string> mc1 = new MyClass1<string>();
            mc1.M1("hello");
            Console.ReadKey();
        }
    }
    public interface ITest<T>
    {
        void M1(T t);

        T M2();

        void M3(T obj);

        //可以是属性
        T PValue
        {
            get;
            set;
        }
    }

    //实现接口的时候的两个方式
    //第一种：可以指定泛型
    //第二种：可以不指定泛型

    #region 实现泛型接口 方式一“封闭类型”

    //有的书上叫“封闭类型”
    class MyClass : ITest<string>
    {

        public void M1(string t)
        {
            throw new NotImplementedException();
        }

        public string M2()
        {
            throw new NotImplementedException();
        }

        public void M3(string obj)
        {
            throw new NotImplementedException();
        }

        public string PValue
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    #endregion

    #region 实现泛型接口 方式二“开放类型”

    //“开放类型”
    //当ITest<T>的类型不确定的时候，可以在MyClass1后面加一个类型
    //将来MyClass1<T>的T是什么类型 ITest<T>的T就是什么类型
    class MyClass1<T> : ITest<T>
    {

        public void M1(T t)
        {
            Console.WriteLine(t);
        }

        public T M2()
        {
            throw new NotImplementedException();
        }

        public void M3(T obj)
        {
            throw new NotImplementedException();
        }

        public T PValue
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    #endregion

}
