using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _99相对路径问题
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //在程序中使用相对路径不要直接这么写，因为这样写有时可能不准确
            //比如：用户打开了OpenFileDialong对话框等。
            //textBox2.Text = File.ReadAllText("1.txt", Encoding.Default);

            //1.先获取当前的exe文件执行的路径
            string exePath = Assembly.GetExecutingAssembly().Location.ToString();

            string txtPath = Path.Combine(Path.GetDirectoryName(exePath), "1.txt");

            textBox2.Text = File.ReadAllText(txtPath, Encoding.Default);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }
    }
}
