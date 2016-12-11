using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03Type类型的一些方法介绍
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.动态加载程序集
            Assembly asm = Assembly.LoadFile(@"f:\TestLib.dll");

            //2.1获取Chines类型的Type
            Type tpyeChinese = asm.GetType("TestLib.Chinese");

            //2.2获取Person类型的Type
            Type typePerson = asm.GetType("TestLib.Person");

            //2.3获取借口类型的Type
            Type typeIXiuFu = asm.GetType("TestLib.IZiWoXiuFu");

            //2.4获取抽象类MyAbsClass的type
            Type typeMyAbsClass = asm.GetType("TestLib.MyAbsClass");

            //2.5获取静态类MystaticClass的type
            Type typeMyStaticClass = asm.GetType("TestLib.MystaticClass");


            #region IsAssignableFrom
            //3.验证一下Person类型是不是Chines类型的父类。
            //验证是不是可以typeChinese类型的对象赋值给typePerson类型。
            //bool b = typePerson.IsAssignableFrom(tpyeChinese);
            //Console.WriteLine(b);//True，因为Chinese继承了Person

            //bool b = typeIXiuFu.IsAssignableFrom(tpyeChinese);
            //Console.WriteLine(b);
            //Console.ReadKey(); 
            #endregion

            #region IsInstanceOfType

            //创建了一个tpyeChinese类型的对象obj
            //object obj = Activator.CreateInstance(tpyeChinese);

            ////验证obj是不是typChinese类型的对象
            //bool b = tpyeChinese.IsInstanceOfType(obj);
            //Console.WriteLine(b);//True

            //验证obj是不是typePerson类型的对象
            //bool b = typePerson.IsInstanceOfType(obj);
            //Console.WriteLine(b);//True            

            #endregion

            #region IsSubclassOf

            //验证tpyeChinese是否是typePerson的子类
            //bool b = tpyeChinese.IsSubclassOf(typePerson);
            //Console.WriteLine(b);//True

            //判断tpyeChinese是否是typeIXiuFu的子类
            //IsSubclassOf不考虑接口，只考虑父子类关系。
            //bool b = tpyeChinese.IsSubclassOf(typeIXiuFu);
            //Console.WriteLine(b);//False

            #endregion

            #region IsAbstract 判断某个类型是否是一个抽象的            

            Console.WriteLine(tpyeChinese.IsAbstract);//False
            Console.WriteLine(typePerson.IsAbstract);//False

            //接口、抽象类、静态类都不能被实例化，所以这里都认为是“抽象的”

            Console.WriteLine(typeIXiuFu.IsAbstract);//True
            Console.WriteLine(typeMyAbsClass.IsAbstract);//True
            Console.WriteLine(typeMyStaticClass.IsAbstract);//True

            #endregion

            Console.ReadKey();
        }
    }
}
