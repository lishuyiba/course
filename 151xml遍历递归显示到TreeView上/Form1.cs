using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _151xml遍历递归显示到TreeView上
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //加载x1.xml
            XDocument xdoc = XDocument.Load("x1.xml");
            //获取根结点
            XElement exRoot = xdoc.Root;
            //将根结点绑定到TreeView上
            TreeNode treeViewRoot = treeView1.Nodes.Add(exRoot.Name.ToString());
            //递归加载
            LoadNodes(exRoot, treeViewRoot);
        }

        private void LoadNodes(XElement exRoot, TreeNode treeViewRoot)
        {
            //exRoot.Elements()表示：获取exRoot节点下面的所有子节点
            //把exRoot下面所有的内容都循环绑定到treeViewRoot下面
            foreach (XElement ele in exRoot.Elements())
            {
                if (ele.Elements().Count() > 0)
                {
                    //把元素本身绑定上来
                    TreeNode node = treeViewRoot.Nodes.Add(ele.Name.ToString());//加名称
                    //如果元素还有属性的话，把属性也绑定上来
                    XAttribute attr = ele.Attribute("id");
                    if (attr!=null)//如果有id属性
                    {                        
                        node.Text = "["+attr.Name+"="+attr.Value+"]";
                    }
                    LoadNodes(ele, node);
                }
                else
                {
                    TreeNode node = treeViewRoot.Nodes.Add(ele.Value);//加内容
                }

            }
        }
    }
}
