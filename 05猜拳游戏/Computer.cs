using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05猜拳游戏
{
    public class Computer
    {
        public string FistName
        {
            get;
            set;
        }
        public int ShowFist()
        {
            Random random = new Random();
            int result = random.Next(1, 4);
            switch (result)
            {
                case 1:
                    FistName = "石头";
                    break;
                case 2:
                    FistName = "剪刀";
                    break;
                case 3:
                    FistName = "布";
                    break;
                default:
                    break;
            }
            
            return result;
        }
    }
}
