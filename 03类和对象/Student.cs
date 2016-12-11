using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03类和对象
{
    //3.1当写好一个类以后，有一个默认的无参数的构造函数。
    //3.2如果手动添加一个构造函数，这个时候会将默认的那个无参数的构造函数给覆盖掉。
    //3.3构造函数是可以重载的，可以是多个。要注意！！！方法名和类名要一样，类不能有任何返回值。
    //3.4一个类有没有构造函数，在实例化这个类的时候可以看的到（Studen stu = new Studen();）如果出现两个重载，就是有两个构造函数。
    public class Student
    {
        //类的构造函数特点：
        //1.方法名必须与类名一致。
        //2.构造函数不能有任何返回值类型，哪怕是Void也不行。
        //3.构造函数的访问修饰符，一般都是public

        #region 有三个参数的构造函数 +Student(string _name,int _age,string _no)
        /// <summary>
        /// 有三个参数的构造函数
        /// </summary>
        public Student(string _name, int _age, string _no)
        {
            this.Name = _name;
            this.Age = _age;
            this.No = _no;
        }
        #endregion

        #region 没有参数的构造函数 +Student
        /// <summary>
        /// 没有参数的构造函数
        /// </summary>
        public Student()
        {

        }
        #endregion

        #region 当构造函数的访问修饰符是private\protected时，可以创建一个类来给外部访问 +static Student GetInStance()
        /// <summary>
        ///这时，由于类的构造函数都是私有的，所以可以自己编写一个方法来控制何时来创建类的对象。
        /// </summary>
        public static Student GetInStance()
        {
            return new Student();
        }
        #endregion
        

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 学号
        /// </summary>
        public string No
        {
            get;
            set;
        }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age
        {
            get;
            set;
        }

        /// <summary>
        /// 签到时间
        /// </summary>
        public string loginDateTime
        {
            get;
            set;
        }

        public void Login()
        { 
            Console.WriteLine("签到");
        }
        public void Logout()
        {
            Console.WriteLine("签退");
        }
    }
}
