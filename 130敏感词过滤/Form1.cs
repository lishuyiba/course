using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _130敏感词过滤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 通过常规的方式验证用户输入中是否包含某个敏感词

            ////1.获取用户输入的字符串
            //string userInput = txtContent.Text.Trim();
            ////2.读取“敏感词”库
            //string[] lines = File.ReadAllLines("filter.txt", Encoding.GetEncoding("gbk"));
            ////3.将敏感词分类
            ////3.1存储“审核”的敏感词
            //List<string> listMod = new List<string>();
            ////3.2存储“禁止发帖”敏感词
            //List<string> listBanned = new List<string>();

            //foreach (string word in lines)
            //{
            //    string[] parts = word.Split('=');
            //    if (parts[1] == "{MOD}")
            //    {
            //        //需要审核的关键词
            //        listMod.Add(parts[0]);
            //    }
            //    else if (parts[1] == "{BANNED}")
            //    {
            //        //禁止发帖关键词
            //        listBanned.Add(parts[0]);
            //    }
            //}
            ////4遍历用户输入的内容，判断里面是否包含“禁止发帖”关键词
            //bool banned = false;
            //foreach (string item in listBanned)
            //{
            //    //4.1遍历listBanned集合中的每一个关键词，对于每个关键词都判断一下用户的输入中是否包含
            //    if (userInput.Contains(item))
            //    {
            //        banned = true;
            //        break;
            //    }
            //}
            ////4.2判断用户的输入中，是否包含禁止发帖的关键词
            //if (banned)
            //{
            //    MessageBox.Show("您输入的文字包含禁止敏感词，请重新输入！");
            //}
            //else
            //{
            //    //5.继续验证是否包含需要 审核 的关键词
            //    foreach (string item in listMod)
            //    {
            //        if (userInput.Contains(item))
            //        {
            //            MessageBox.Show("需要审核才能发布！");
            //            break;
            //        }
            //    }
            //}

            #endregion

            #region 通过正则表达式过滤敏感词

            //1.获取用户输入
            string userInput = txtContent.Text.Trim();
            string[] lines = File.ReadAllLines("filter.txt", Encoding.GetEncoding("gbk"));

            StringBuilder sbMod = new StringBuilder();
            StringBuilder sbBanned = new StringBuilder();

            foreach (string item in lines)
            {
                string[] parts = item.Split('=');
                if (parts[1] == "{MOD}")
                {
                    sbMod.Append(parts[0] + "|");
                }
                else if (parts[1] == "{BANNED}")
                {
                    sbBanned.Append(parts[0] + "|");
                }
            }
            string regMod = sbMod.ToString().TrimEnd('|');
            string regBanned = sbBanned.ToString().TrimEnd('|');

            if (Regex.IsMatch(userInput, regBanned))
            {
                MessageBox.Show("禁止发帖！");
            }
            else if (Regex.IsMatch(userInput, regMod))
            {
                MessageBox.Show("需要审核！");
            }

            #endregion


        }
    }
}
