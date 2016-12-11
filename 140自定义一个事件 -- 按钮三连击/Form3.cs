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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ucTripleClickEvent1_Load(object sender, EventArgs e)
        {
            //委托可以使用“=”赋值
            //事件不可以使用“=”赋值，只能通过“+=”或者“-=”来赋值，所以避免了使用“=”赋值时覆盖的问题。
            ucTripleClickEvent1.TripleClick += Click1;
            ucTripleClickEvent1.TripleClick += ucTripleClickEvent1_TripleClick;
        }

        void ucTripleClickEvent1_TripleClick()
        {
            MessageBox.Show("这是为TripleClick注册的第二个事件处理程序！");
        }

        private void Click1()
        {
            MessageBox.Show("通过事件实现的三连击！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //事件不能在定义事件的类的外部触发，只能在那个类内部触发，所以也就避免了冒充事件触发的问题。
            //ucTripleClickEvent1.TripleClick();
        }
    }
}
