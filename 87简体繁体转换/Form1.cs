using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _87简体繁体转换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //声明一个Dictionary集合，用来存储简繁字符信息
        private Dictionary<char, char> dict = new Dictionary<char, char>();

        private void brnConvert_Click(object sender, EventArgs e)
        {
            //获取用户输入的简体中文
            string usrInput = txtCHS.Text.Trim();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < usrInput.Length; i++)
            {
                //判断字库是否包含当前的文字
                if (dict.ContainsKey(usrInput[i]))
                {
                    sb.Append(dict[usrInput[i]]);
                }
                else
                {
                    //如果不包含，则不转换（还是原样显示）
                    sb.Append(usrInput[i]);
                }
            }
            txtCHT.Text = sb.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //加载字库信息
            string[] lines = File.ReadAllLines("ST.txt",Encoding.Default);//读取文本文件的信息到数组中
            for (int i = 0; i < lines.Length; i++)
            {
                dict.Add(lines[i][0], lines[i][2]);
            }
        }
    }
}
