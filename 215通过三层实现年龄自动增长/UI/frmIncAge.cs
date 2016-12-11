using _215通过三层实现年龄自动增长.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _215通过三层实现年龄自动增长.UI
{
    public partial class frmIncAge : Form
    {
        //不要在UI表现层直接去调用DAL数据库访问层。
        //应该要通过逻辑层再调用数据库访问层。
        public frmIncAge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fid = Convert.ToInt32(textBox1.Text.Trim());
            MyStudentBll bll = new MyStudentBll();
            bool b = bll.IncAgeById(fid);
            if (b)
            {
                MessageBox.Show("更新成功！");
            }
            else
            {
                MessageBox.Show("更新失败！");
            }
        }

    }
}
