using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05猜拳游戏
{
    public class Player
    {
        public string FistName
        {
            get;
            set;
        }
        public int ShowFist(string fist)
        {
            int result = -1;
            switch (fist)
            {
                case "石头":
                    result = 1;
                    break;
                case "剪刀":
                    result = 2;
                    break;
                case "布":
                    result = 3;
                    break;              
            }
            this.FistName = fist;
            return result;
        }
    }
}
