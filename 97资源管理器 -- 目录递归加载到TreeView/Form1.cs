using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _97资源管理器____目录递归加载到TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node!=null)
            {
                if (e.Node.Tag!=null)
                {
                    textBox1.Text = File.ReadAllText(e.Node.Tag.ToString(),Encoding.Default);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //将demo下的所有文件夹加载到TreeView上。
            //获取demo目录
            DirectoryInfo demoDir = new DirectoryInfo("demo");
            DirectoryInfo[] dirInfos = demoDir.GetDirectories();//获取文件夹里面所有的子文件夹
            foreach (DirectoryInfo item in dirInfos)
            {
                TreeNode tnode = treeView1.Nodes.Add(item.Name);
                LoadData(item.FullName, tnode);
            }

        }
        private void LoadData(string path, TreeNode tnode)
        {
            //1获取当前路径下的所有直接子文件
            string[] files = Directory.GetFiles(path, "*.txt", SearchOption.TopDirectoryOnly);

            //2把这些文件加载到treeview上
            foreach (string item in files)
            {
                TreeNode nodeFile = tnode.Nodes.Add(Path.GetFileName(item));
                
                //每次帮顶文件节点的时候，都把当前文件名的完整路径绑定到Tag中。
                nodeFile.Tag = item;

            }

            //3获取当前路径下的所有直接子文件夹
            string[] dirs = Directory.GetDirectories(path);
            foreach (string item in dirs)
            {
                TreeNode node = tnode.Nodes.Add(Path.GetFileName(item));
                LoadData(item, node);
            }
        }
    }
}
