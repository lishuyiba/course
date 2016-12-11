using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03类和对象
{
    public class Teacher
    {
        public Teacher()
        {
        }

        public Teacher(string _name)
        {
            this.Name = _name;
        }

        public double Salary
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public void AddNewStudent()
        {
            Console.WriteLine("添加一位新学生！");
        }
    }
}
