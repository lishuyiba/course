using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class Class1
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void SayHi()
        {
            Console.WriteLine("大家好！");
        }
        public void SyaHello()
        {
            MyClass mc = new MyClass();
            mc.SayHi();
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public delegate void MyDelegate();

    public enum Good
    {
        高,
        富,
        帅
    }

    internal class MyClass
    {
        internal void SayHi()
        {
            Console.WriteLine("能看到吗？");
        }
    }

    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }

    public class Chinese:Person,IZiWoXiuFu
    {
        public string HuKouSuoZaiDi
        {
            get;
            set;
        }
        public void XiuFu()
        {
            Console.WriteLine("以毒攻毒，配平了。");
        }
    }

    public interface IZiWoXiuFu
    {
        void XiuFu();
    }

    public abstract class MyAbsClass
    {
        public abstract void SayHello();
    }

    public static class MystaticClass
    {
        
    }
}

