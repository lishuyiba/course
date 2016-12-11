using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32抽象案例三
{
    /// <summary>
    /// 计算圆形
    /// </summary>
    class Circle:Shape
    {
        public Circle(double r)
        {
            this.BanJing = r;
        }

        public double BanJing
        {
            get;
            set;
        }

        public override double GetArea()
        {
            return Math.PI * BanJing * BanJing;
        }

        public override double GetZhouChang()
        {
            return 2 * Math.PI * BanJing;
        }
    }
}
