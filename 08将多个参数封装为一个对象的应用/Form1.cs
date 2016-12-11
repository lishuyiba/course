using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08将多个参数封装为一个对象的应用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Prov p1 = new Prov() { ProvName=  "山东", ProvId = 1 };//对象初始化器
            Prov p2 = new Prov() { ProvName = "山西", ProvId = 2 };
            Prov p3 = new Prov() { ProvName = "北京", ProvId = 3 };
            Prov p4 = new Prov() { ProvName = "上海", ProvId = 4 };

            comboBox1.Items.Add(p1);
            comboBox1.Items.Add(p2);
            comboBox1.Items.Add(p3);
            comboBox1.Items.Add(p4);



            //向下拉菜单添加省份
            //comboBox1.Items.Add("山东");
            //comboBox1.Items.Add("山西");
            //comboBox1.Items.Add("北京");
            //comboBox1.Items.Add("上海");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //显示选中项的名称
            //MessageBox.Show(comboBox1.Text);

            Prov p=(Prov)comboBox1.SelectedItem;
            MessageBox.Show("省份："+p.ProvName+"\nId："+p.ProvId);


        }
    }
}
