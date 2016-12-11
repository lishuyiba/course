using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsLib2
{
    public class Class1
    {
        public void Test1(WriteTimeDelegate WriteTime)
        {
            Console.WriteLine("=================================");
            //这里潜入的代码是可变的
            //这里的代码由将来调用Test1方法时确定
            //这里需要一个方法变量
            WriteTime();
            Console.WriteLine("=================================");
        }
    }
}
