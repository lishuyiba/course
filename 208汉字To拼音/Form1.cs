using Microsoft.International.Converters.PinYinConverter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _208汉字To拼音
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = txtCHS.Text.Trim();
            //因为不是静态类，所以要实例化这个对象
            //ChineseChar chChar = new ChineseChar()//这里只能传一个char，而字符串txt可能是多个char，所以用foreach循环
            StringBuilder sbPy = new StringBuilder();
            //遍历用户输入的每个char
            foreach (char ch in txt)
            {
                ChineseChar chChar = new ChineseChar(ch);
                #region 1
                //foreach (string py in chChar.Pinyins)
                //{
                //    sbPy.Append(py + "\r\n");
                //} 

                //for (int i = 0; i < chChar.PinyinCount; i++)
                //{
                //    sbPy.Append(chChar.Pinyins[i] + "\t\n");
                //}
                #endregion
                #region 2

                //for (int i = 0; i < chChar.PinyinCount; i++)
                //{
                //    //sbPy.Append(chChar.Pinyins[i] + "\t\n");
                //    sbPy.Append(chChar.Pinyins[i].Substring(0, chChar.Pinyins[i].Length - 1));

                //}

                #endregion

                if (chChar.PinyinCount>0)
                {
                    sbPy.Append(chChar.Pinyins[0].Substring(0, chChar.Pinyins[0].Length - 1));
                }                
            }
            txtCHPy.Text = sbPy.ToString().ToLower();

        }
    }
}
