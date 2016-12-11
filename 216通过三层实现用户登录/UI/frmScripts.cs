using _216通过三层实现用户登录.BLL;
using _216通过三层实现用户登录.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _216通过三层实现用户登录.UI
{
    public partial class frmScripts : Form
    {
        public frmScripts()
        {
            InitializeComponent();
        }

        TScriptsBll bll = new TScriptsBll();

        private void frmScripts_Load(object sender, EventArgs e)
        {

            //在页面加载的时候将数据库中的类型递归加载到TreeView上
            //获取所有的一级类别
            List<TScript> list = bll.GetScriptsByParentId(0);
            LoadDataToTree(treeView1.Nodes, list);
        }

        private void LoadDataToTree(TreeNodeCollection treeNodeCollection, List<TScript> list)
        {
            foreach (TScript item in list)
            {
                TreeNode tNode = treeNodeCollection.Add(item.ScriptTile);
                tNode.Tag = item.ScriptId;

                //设置让TreeView中每个节点单击右键的时候显示右键菜单
                tNode.ContextMenuStrip = contextMenuStrip1;

                LoadDataToTree(tNode.Nodes, bll.GetScriptsByParentId(item.ScriptId));
            }
        }

        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            //删除当前选中的节点
            //1.获取当前选中节点的Id
            int id = (int)treeView1.SelectedNode.Tag;
            TScriptsBll bll = new TScriptsBll();
            bll.DeleteById(id);//这个方法会递归删除
            treeView1.SelectedNode.Remove();
        }

        //点击哪个选项，哪个选项就被选中。
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.treeView1.SelectedNode = e.Node;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //当选中类别改变后，在右边的文本框中显示当前选中的节点对应的msg
            //1.获取当前选中节点的Id
            int id = (int)e.Node.Tag;
            TScriptsBll bll = new TScriptsBll();
            textBox1.Text = bll.GetScriptMsgScriptId(id);
        }
    }
}
