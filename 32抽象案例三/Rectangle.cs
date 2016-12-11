using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32抽象案例三
{
    /// <summary>
    /// 计算正方形
    /// </summary>
    class Rectangle:Shape
    {
        public Rectangle(double chang,double kuan)
        {
            this.Chang = chang;
            this.Kuan = kuan;
        }

        public double Chang
        {
            get;
            set;
        }
        public double Kuan
        {
            get;
            set;
        }

        public override double GetArea()
        {
            return Chang * Kuan;
        }

        public override double GetZhouChang()
        {
            return 2*(Chang+Kuan);
        }
    }
}
