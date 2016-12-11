using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49枚举介绍
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.普通枚举中每个值都是互斥的。
            //2.枚举中的每个值都有一个对应数值来表示。
            //2.1默认数值是整型int，从0开始，一次递增。
            //2.2可以手动设置每个枚举对应的整数。
            //3.枚举在编译完成后就已经用对应的数值常量来表示了。


            //枚举
            //1.普通枚举
            //public enum MyColor:byte
            //{
            //   Red = 0;
            //}

            //2.标志枚举
            //00001
            //00010
            //00100


            Console.WriteLine((int)UserState.Qme);
            Console.WriteLine((int)UserState.OnLine);
            Console.WriteLine((int)UserState.OffLine);
            Console.WriteLine((int)UserState.Busy);
            Console.WriteLine((int)UserState.Hide);
            Console.WriteLine((int)UserState.Left);

            //把枚举转换为字符串。
            string str = UserState.Busy.ToString();
            Console.WriteLine(str);

            //把字符串转换为枚举类型。
            string meiju = "Qme";
            UserState state = (UserState)Enum.Parse(typeof(UserState), meiju);
            Console.WriteLine((int)state);

            Console.ReadKey();
        }
    }

    /// <summary>
    /// 用户状态
    /// </summary>
    //默认枚举都是使用int来替代的，但是也可以指定具体的数据类型。
    //枚举：byte表示，限制枚举中的数字类型。
    public enum UserState:byte
    { 
        //一般枚举中的每个值都是互斥的。
        Qme,
        OnLine=100,
        OffLine,
        Busy,
        Hide=20,
        Left
    }
}
