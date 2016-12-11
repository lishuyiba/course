using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _138事件
{
    //事件定义：
    //事件编译器最后生成一个私有的委托变量和两个公有的方法来，事件是基于委托，没有委托就没有事件
    
    //用法：
    //在声明的类中才能触发，由于事件最后由Add和Remove方法，所以它只能使用+=或-=来赋值，不能直接使用=来赋值。


    class Program
    {
        static void Main(string[] args)
        {
            //Office office = new Office();
            //office.doSth = delegate()
            //{
            //    Console.WriteLine("报警119！");
            //};
            //office.PressButton();
            //Console.ReadKey();
            

            GuoLuFang guolu = new GuoLuFang();
            guolu.Heat = Hot;
            //当水烧到100摄氏度
            for (int i = 0; i < 100; i++)
            {                
                guolu.ShaoShui();                
            }
            Console.WriteLine("OK");
            Console.ReadKey();

        }
        static void Hot()
        {
            Console.WriteLine("滴滴滴滴滴滴，水烧开了！");
        }
    }

    /// <summary>
    /// 烧锅炉
    /// </summary>
    public delegate void GuoLuDelegate();
    public class GuoLuFang
    {
        //温度，用来监测锅炉中水的温度
        private int _temperature;

        public GuoLuDelegate Heat;

        //烧水
        public void ShaoShui()
        {
            _temperature++;
            if (_temperature==100)
            {
                //当水达到100摄氏度的时候，要触发一个事件。
                //这个时间将来到底是执行什么操作由用户来确定。
                //当水达到100度的时候，触发一个事件
                if (Heat!=null)
                {
                    //调用委托变量，相当于是触发了水烧开的事件。
                    Heat();
                }
            }
        }
    }



    /// <summary>
    /// 报警
    /// </summary>
    public delegate void DoDelegate();
    public class Office
    {
        public DoDelegate doSth;
        //报警
        private void Alert()
        {
            //Console.WriteLine("发出警告！通知119");
            //DoSth();
            if (doSth!=null)
            {
                //触发事件。
                doSth();
            }
        }

        //按下警铃
        public void PressButton()
        {
            Alert();
        }

    }

}
