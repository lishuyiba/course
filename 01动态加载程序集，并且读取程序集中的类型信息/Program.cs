using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01动态加载程序集_并且读取程序集中的类型信息
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 加载指定的程序集，并且获取该程序集中的所有类型
            ////1.加载f:\TestLib.dll程序集
            ////现在sam就是TestLib.dll程序集对象
            //Assembly asm = Assembly.LoadFile(@"f:\TestLib.dll");

            ////2.获取asm这个程序集中的所有类型（public类型和非public类型）。
            ////Type[] types = asm.GetTypes();

            ////获取程序集中的所有public类型。
            //Type[] types = asm.GetExportedTypes();

            ////3.循环遍历把每个类型都输出
            //foreach (Type typeItem in types)
            //{
            //    Console.WriteLine(typeItem.Name);
            //}
            //Console.ReadKey(); 
            #endregion

            #region 加载程序集，获取Class1下的所有方法

            //1.加载程序集
            Assembly asm = Assembly.LoadFile(@"f:\TestLib.dll");

            //2.获取Class1这个类型（typeClass1就表示描述Class1类的type里面存储的就是Class1的一些相关信息，就可以理解成是Class1的元数据）
            Type typeClass1 = asm.GetType("TestLib.Class1");

            #region 获取当前类型中德所有非protected非private方法
            ////3.获取Class1中的所有方法
            //MethodInfo[] minfos = typeClass1.GetMethods();

            ////4.遍历每个方法，把每个方法的名称打印出来。
            //foreach (MethodInfo MethodItem in minfos)
            //{
            //    Console.WriteLine(MethodItem.Name);
            //}
            //Console.ReadKey();
            #endregion

            #region 获取SayHi方法以及调用方法（获取指定某个方法）

            //MethodInfo method = typeClass1.GetMethod("SayHi");
            
            ////3.输出该方法
            //Console.WriteLine(method.Name);

            ////4.动态创建一个Class1类型的对象
            //object obj=Activator.CreateInstance(typeClass1);

            ////5.调用方法
            //method.Invoke(obj,null);

            //Console.ReadKey();

            #endregion




            #endregion
        }
    }
}
