using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeStringLib
{
    public class Class1
    {
        //public void ChangeString(string[] str)
        //{
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        str[i] = str[i].ToUpper();
        //    }
        //}


        public void ChangeString(string[] str,ChgStrDelegate ChgStr)
        {
            //要把字符串数组str中的每个字符串都变成大写
            for (int i = 0; i < str.Length; i++)
            {
                //委托，只是把方法中变的地方提取出来，便于写出通用的代码。
                str[i] = ChgStr(str[i]);
            }
        }

    }
}
