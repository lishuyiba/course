using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02简易计算器
{
    public partial class frmCal : Form
    {
        public frmCal()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //1.判断用户是否选择了“运算符”
            if (cboysf.SelectedIndex == 0)
            {
                MessageBox.Show("请选择运算符！");
            }
            else
            {
            //单击“=”后执行的代码
            int num1 =Convert.ToInt32( txtNum1.Text.Trim());//Trim表示去掉两个的空格
            int num2 = Convert.ToInt32(txtNum2.Text.Trim());
            switch (cboysf.Text)
            {
                case"+":
                    lblResult.Text =Convert.ToString( num1 + num2);
                    break;
                case"-":
                    lblResult.Text = Convert.ToString(num1-num2);
                    break;
            }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置，将所有项中的第0项作为默认选中项。
            cboysf.SelectedIndex = 0;
        }
    }
}
