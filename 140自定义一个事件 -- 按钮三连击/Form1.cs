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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucButton1.TripleClick = Form1TripleClick;
            ucButton1.TripleClick += Form1TripleClick1;
            ucButton1.TripleClick += Form1TripleClick2;
        }

        void Form1TripleClick()
        {
            MessageBox.Show("在窗体1中的三连击！");
        }
        void Form1TripleClick1()
        {
            MessageBox.Show("111111111111111");
        }
        void Form1TripleClick2()
        {
            MessageBox.Show("222222222222222");
        }
        void Form1TripleClick3()
        {
            MessageBox.Show("333333333333333");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //通过委托来实现事件的功能的问题：
            //1.可以在类的外部来触发，因为委托变量TripleClick的访问修饰符为public的，所以在外部任何地方都可以触发。
            //如果把TripleClick的访问修饰符改成private的，那么的确不能在外部触发了，但是也不能在外部赋值了。
            ucButton1.TripleClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //由于委托可以使用“=”来赋值，所以，就有可能将前面的所有已经注册的事件处理程序都覆盖掉。
            ucButton1.TripleClick = Form1TripleClick3;
        }
    }
}
