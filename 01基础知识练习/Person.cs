using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01基础知识练习
{
    public class Person
    {
        //public string Name;//叫字段，不叫属性
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private int _age;//自动封装属性，Ctrl+R+E
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Gender//自动属性
        {
            get;
            set;
        }

        public virtual void SayHi()
        {
            Console.WriteLine("大家好！我叫{0}",this.Name);
        }
    }
}
