using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21ToString重写
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass mc = new MyClass();
            //string s = mc.ToString();
            //Console.WriteLine(s);
            //Console.ReadKey();

            #region ToString重写
            char[] ch = { 'a', 'b', 'c', 'd' };
            string s1 = new string(ch);
            Console.WriteLine(s1);
            Console.ReadKey();
            #endregion
        }
    }
    class MyClass
    {
        //因为ToString采用了vritual虚方法，所以可以采用override重写
        public override string ToString()
        {
            return "传智播客.NET培训";
        }
    }
}
