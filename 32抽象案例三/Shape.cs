using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32抽象案例三
{
    /// <summary>
    /// 抽象类
    /// </summary>
    abstract class Shape
    {
        //面积
        public abstract double GetArea();

        //周长
        public abstract double GetZhouChang();
    }
}
