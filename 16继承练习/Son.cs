using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16继承练习
{
    public class Son:Father
    {
        //儿子类
        //构造函数，采用base继承了父类的构造函数。
        public Son(string lastName, double property, BloodType type)
            : base(lastName, property, type)
        {

        }

        public void PlayGame()
        {
            Console.WriteLine("name:{0}\nproperty:{1}\ntype:{2}\n 这是个儿子类，玩游戏方法！", IastName, Property, BloodType.AB);
        }
    }
}
