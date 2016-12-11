using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48枚举
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetQQState(UserState.Busy);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("aaaaa", "提示", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            MessageBox.Show(result.ToString());

            MyColor color= MyColor.Blue;
            MessageBox.Show(color.ToString());
        }

        /// <summary>
        /// QQ状态
        /// </summary>
        public bool SetQQState(UserState state)
        {
            this.State = state;
            return true;
        }
        //State字段，用来存放传过来的值。
        private UserState State;

    }

    /// <summary>
    /// 颜色类
    /// </summary>
    public enum MyColor
    { 
        Red,
        Green,
        Blue,
        Yellow
    }

    /// <summary>
    /// 用户状态
    /// </summary>
    public enum UserState
    { 
        //一般枚举中的每个值都是互斥的。
        Qme,
        OnLine,
        OffLine,
        Busy,
        Hide
    }

}
