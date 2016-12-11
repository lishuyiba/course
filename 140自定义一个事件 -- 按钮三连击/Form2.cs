using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _140自定义一个事件____按钮三连击
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ucButton1_Load(object sender, EventArgs e)
        {
            //窗体加载的时候
            ucButton1.TripleClick=Button_TripleClick;
        }

        private void Button_TripleClick()
        {
            MessageBox.Show("Hello Word!");
        }
    }
}
