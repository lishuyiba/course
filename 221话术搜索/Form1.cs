using _221话术搜索BLL;
using _221话术搜索Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221话术搜索
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TScriptsBll bll = new TScriptsBll();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(treeView1.Nodes, GetByParentId(0));
        }

        private void LoadData(TreeNodeCollection treeNodeCollection, List<TScript> list)
        {
            foreach (TScript item in list)
            {
                TreeNode tnode = treeNodeCollection.Add(item.ScriptTitle);
                tnode.Tag = item.ScriptId;
                LoadData(tnode.Nodes, GetByParentId(item.ScriptId));
            }
        }
        private List<TScript> GetByParentId(int pid)
        {
            return bll.GetDataByParentId(pid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTxt = textBox1.Text.Trim();
            SearchOnTreeView(treeView1.Nodes, searchTxt);
        }

        private void SearchOnTreeView(TreeNodeCollection treeNodeCollection, string searchTxt)
        {
            foreach (TreeNode node in treeNodeCollection)
            {
                if (node.Text.Contains(searchTxt))
                {
                    node.BackColor = Color.Red;

                    //TreeNode tp = node.Parent;
                    //while (tp != null)
                    //{
                    //    tp.Expand();//展开当前节点，不包含子节点
                    //    tp = tp.Parent;
                    //}

                    //设置当前节点可见
                    node.EnsureVisible();
                }
                SearchOnTreeView(node.Nodes, searchTxt);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
