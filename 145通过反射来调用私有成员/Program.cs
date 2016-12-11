using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _145通过反射来调用私有成员
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 通过反射来调用类中的私有成员

            //获取Person类的type
            //Type type = typeof(Person);
            //MethodInfo info = type.GetMethod("SayHi", BindingFlags.NonPublic | BindingFlags.Instance);
            //object obj = Activator.CreateInstance(type);
            //info.Invoke(obj, null);
            //Console.ReadKey(); 

            #endregion


            #region MyRegion

            Type type = typeof(Person);
            MethodInfo[] infos = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            for (int i = 0; i < infos.Length; i++)
            {
                Console.WriteLine(infos[i].Name);
            }
            Console.ReadKey();
            #endregion

        }
    }
    class Person
    {
        private void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}
