using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05猜拳游戏
{
    public enum UserState
    {
        PlayerWin,
        ComputerWin,
        PingShou
    }
    public class CaiPan
    {
        public static UserState IsPlayerWin(int playerFist,int computerFist)
        {
            if (playerFist==computerFist)
            {
                return UserState.PingShou;
            }
            else if (playerFist - computerFist == -1 || playerFist - computerFist == 2)
            {
                return UserState.PlayerWin;
            }
            else
            {
                return UserState.ComputerWin;
            }
        }

    }
}
