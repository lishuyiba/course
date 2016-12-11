using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _140自定义一个事件____按钮三连击
{   
    public delegate void TripleClickDelegate();
    public partial class UCButton : UserControl
    {
        public UCButton()
        {
            InitializeComponent();
        }

        //声明一个委托变量
        public TripleClickDelegate TripleClick;
        //private TripleClickDelegate TripleClick;

        int count = 0;
        private void btnTriple_Click(object sender, EventArgs e)
        {
            count++;
            if (count>=3)
            {
                //MessageBox.Show("三连击！");                
                if (TripleClick!=null)
                {
                    //当用户三连击的时候触发指定的操作。
                    TripleClick();
                }
                count = 0;
            }
            //MessageBox.Show("这个是用户控件中按钮的单击事件！");
        }
    }
}
