using Microsoft.International.Converters.PinYinConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210更新拼音字段
{
    public static class CommonHelper
    {
        //1.计算MD5值的方法

        /// <summary>
        /// 根据字符串获得拼音
        /// </summary>
        public static string GetPinYinByString(string msg)
        {
            StringBuilder sbPy = new StringBuilder();
            foreach (char ch in msg)
            {
                ChineseChar chChar = new ChineseChar(ch);
                if (chChar.PinyinCount>0)
                {
                    sbPy.Append(chChar.Pinyins[0].Substring(0, chChar.Pinyins[0].Length - 1));
                }
            }
            return sbPy.ToString();
        }

        /// <summary>
        /// 获取拼音的缩写
        /// </summary>
        public static string GetShorPinYinByString(string msg)
        {
            StringBuilder sbPy = new StringBuilder();
            foreach (char ch in msg)
            {
                ChineseChar chChar = new ChineseChar(ch);
                if (chChar.PinyinCount > 0)
                {
                    sbPy.Append(chChar.Pinyins[0].Substring(0,1));
                }
            }
            return sbPy.ToString();
        }
    }
}
