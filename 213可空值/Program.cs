using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213可空值
{
    class Program
    {
        static void Main(string[] args)
        {
            //就变成了一个“可空值类型”
            int? x = null;
            //它们两个是一样的
            int xx = (int)x;
            int yy = x.Value;

            //不报错，因为是值类型
            double? d = null;
            bool? b = null;

            //报错，因为是引用类型，而引用类型可以赋空值
            //string? s = null;


            int? j = 100;
            //int i = (j == null ? 10 : (int)j);
            int i = j ?? 10;//等价上面


        }
    }
}
