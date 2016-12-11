using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsQ
{
    /// <summary>
    /// 抽象计算类
    /// </summary>
    public abstract class JiSuan
    {
        //抽象第一个数
        public int Number1
        {
            get;
            set;
        }
        
        //抽象第二个数
        public int Number2
        {
            get;
            set;
        }

        //抽象计算公式，以后添加加、减、乘、除法的时候，直接继承该方法就可以了。
        public abstract int Computer();
    } 
}
