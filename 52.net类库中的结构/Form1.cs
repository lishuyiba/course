using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52.net类库中的结构
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //显示鼠标的动态坐标
            this.Text = string.Format("({0},{1})",e.X,e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击鼠标后，让图片显示的位置。
            this.pictureBox1.Location = new Point(370,40);

            //点击鼠标后，让图片显示的大小。
            this.pictureBox1.Size = new Size(200, 400);
        }
    }
}
