using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20用虚方法实现多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //对扩展开放，对修改关闭 -- 开放封闭原则。
            Chinese cn1 = new Chinese("李树逸");
            Chinese cn2 = new Chinese("越犀利");
            Japanese jp1 = new Japanese("松下蜘蛛");
            Japanese jp2 = new Japanese("井上言");
            American us1 = new American("HanMeiMei");
            English en1 = new English("Tom");

            //Chinese ch = new Chinese("lsy");
            //Person p1 = ch;//子类的类型变量赋值给父类的类型变量，不需要强制转换。
            //p1.Show();

            Person[] cns = new Person[] {cn1,cn2,jp1,jp2,us1,en1};
            //遍历数组中的每个元素，调用每个元素的Show方法。
            for (int i = 0; i < cns.Length; i++)
            {
                #region 旧版本
                ////判断当前cns[i]中存储的对象是否是Chinese类型。
                //if (cns[i] is Chinese)
                //{
                //    Chinese cn = (Chinese)cns[i];
                //    cn.Show();
                //}
                //else if (cns[i] is Japanese)
                //{
                //    Japanese cn = (Japanese)cns[i];
                //    cn.Show();
                //}
                //else if (cns[i] is American)
                //{
                //    American cn = (American)cns[i];
                //    cn.Show();
                //}
                #endregion

                #region 新版本 采用了重写
                //1.这里无论数组中有什么类型，都只是调用一个Show（）方法就可以了。
                //2.如果cns[i]中存储的时Chinese类型，则调用Chinese的方法。
                //3.这句话就是多态的体现。
                cns[i].Show();//这句话就是多态的体现。
                #endregion

            }
            Console.WriteLine("=======OK=======");
            Console.ReadKey();
        }
    }
}
