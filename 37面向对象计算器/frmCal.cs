using JsQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37面向对象计算器
{
    public partial class frmCal : Form
    {
        public frmCal()
        {
            InitializeComponent();
        }

        private void btnJiSuan_Click(object sender, EventArgs e)
        {
            #region 旧代码
            //Calculator cal = new Calculator();
            //cal.Number1 = Convert.ToInt32(txtNumber1.Text.Trim());
            //cal.Number2 = Convert.ToInt32(txtNumber2.Text.Trim());
            //switch (cboFuHao.Text.Trim())
            //{
            //    case "+":
            //        lblResult.Text = cal.Add().ToString();
            //        break;
            //    case "-":
            //        lblResult.Text = cal.Sub().ToString();
            //        break;
            //} 
            #endregion

            int n1 = Convert.ToInt32(txtNumber1.Text.Trim());
            int n2 = Convert.ToInt32(txtNumber2.Text.Trim());
            
            #region 旧代码
            //JiSuan jisuan = null;
            //switch (cboFuHao.Text.Trim())
            //{
            //    case "+":
            //        jisuan = new JiaFa();
            //        break;
            //    case "-":
            //        jisuan = new JianFa();
            //        break;
            //    case "*":
            //        jisuan = new ChengFa();
            //        break;
            //} 
            #endregion

            //通过调用GetJiSuanObj方法，返回一个对应的计算的对象。
            JiSuan jisuan= GetJiSuanObj(cboFuHao.Text.Trim());

            jisuan.Number1 = n1;
            jisuan.Number2 = n2;
            lblResult.Text = jisuan.Computer().ToString();
        }

        /// <summary>
        /// 返回值，是计算器的父类类型。
        /// ===============================
        /// 
        /// 简单工厂设计模式
        /// 
        /// 方法的返回值类型    --  父类类型
        /// 方法里返回具体对象  --  父类的子类对象。
        /// 
        /// ===============================
        /// 
        /// </summary>
        /// <param name="p"></param>
        private JiSuan GetJiSuanObj(string p)
        {
            JiSuan js = null;
            switch (p)
            {
                case"+":
                    js = new JiaFa();
                    break;
                case"-":
                    js = new JianFa();
                    break;
            }
            return js;
        }
    }
}
