using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20用虚方法实现多态
{
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get;
            set;
        }

        //1.第一，将父类中的Show方法标记为“虚方法”，virtual
        //2.当一个方法是虚方法的时候，那么这个方法在子类中就可以重写了。
        //3.子类继承父类以后，可以直接使用该方法，也可以将该方法重写。
        public virtual void Show()
        {
            Console.WriteLine("父类中的Show方法。");
        }
    }

    /// <summary>
    /// 中国人类
    /// </summary>
    public class Chinese : Person
    {
        public Chinese(string name)
            :base(name)
        {

        }

        //4.子类如果要重写父类中的方法，则需要在子类的Show方法前加一个override关键字
        //5.子类重写父类的方法必须并且只能用override关键字。
        public override void Show()
        {
            Console.WriteLine("我叫：{0}，我是中国人！",Name);
        }
    }

    public class Japanese : Person
    {
        public Japanese(string name)
            :base(name)
        {

        }
        public override void Show()
        {
            Console.WriteLine("我叫：{0}，我是日本人！",Name);
        }
    }

    public class American : Person
    {
        public American(string name)
            :base(name)
        {

        }
        public override void Show()
        {
            Console.WriteLine("我叫：{0}，我是美国人！",Name);
        }
    }

    /// <summary>
    /// 英国人类
    /// </summary>
    public class English : Person
    {
        public English(string name)
            :base(name)
        {

        }
        public override void Show()
        {
            Console.WriteLine("我叫：{0}，我是英国人！",Name);
        }
    }
}
