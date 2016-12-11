using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04简易计算器_封装一个类实现_
{
    public partial class frmCal : Form
    {
        public frmCal()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (cboysf.SelectedIndex == 0)
            {
                MessageBox.Show("请选择运算符！");
            }
            else
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                switch (cboysf.Text)
                {
                    case "+":
                        Calculator c1 = new Calculator(num1, num2);
                        lblResult.Text = Convert.ToString(c1.Add());
                        break;
                    case "-":
                        Calculator c2 = new Calculator(num1, num2);
                        lblResult.Text = Convert.ToString(c2.Sub());
                        break;
                }
            }
        }

        private void frmCal_Load(object sender, EventArgs e)
        {
            cboysf.SelectedIndex = 0;
        }
    }
}
