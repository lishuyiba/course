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
    public delegate void MyTripleClick();
    public partial class UCTripleClickEvent : UserControl
    {
        public UCTripleClickEvent()
        {
            InitializeComponent();
        }

        int count = 0;

        //有了委托类型以后就可以定义事件了
        //所以说，使用事件与使用委托的区别就是一个event关键字。


        //通过reflector观察生成的代码，就可以发现，其实事件最终生成了：
        //1.一个私有的委托
        //2.两个public的方法Add和Remove，分别用来实现事件的+=和-=
        public event MyTripleClick TripleClick;

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count>=3)
            {
                //要用事件来实现，但是用事件之前，必须先定义委托，否则无法使用事件。

                TripleClick();//触发事件！

                count = 0;
            }
        }
    }
}
