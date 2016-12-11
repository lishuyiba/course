using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16继承练习
{
    public class Father
    {
        public Father(string lastname, double property, BloodType type)
        {
            this.IastName = lastname;
            this.Property = property;
            this.BloodType = type;
        }

        public string IastName
        {
            get;
            set;
        }
        public double Property
        {
            get;
            set;
        }
        public BloodType BloodType
        {
            get;
            set;
        }
    }
}
