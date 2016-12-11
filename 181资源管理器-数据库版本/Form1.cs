using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _181资源管理器_数据库版本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select * from Category where tParentId=-1";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int categoryId = reader.GetInt32(0);
                                string categoryName = reader.GetString(1);
                                //将当前类别加载到TreeView上
                                TreeNode tnode = treeView1.Nodes.Add(categoryName);
                                //加载当前类别（categoryId）下的所有子类别
                                //select tid,tname from Category where tParentId=@
                                LoadSubCategory(categoryId, tnode);
                                tnode.Tag = categoryId;
                            }
                        }
                    }
                }
            }
        }

        private void LoadSubCategory(int categoryId, TreeNode tnode)
        {
            string constr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select tid,tname from Category where tParentId=@pid";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@pid", categoryId);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int cId = reader.GetInt32(0);
                                string categoryName = reader.GetString(1);
                                TreeNode subTNode = tnode.Nodes.Add(categoryName);
                                subTNode.Tag = cId;
                            }
                        }
                    }
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //当选中的时二级节点的时候level==1
            if (e.Node.Level == 1)
            {
                //e.Node表示当前选中的节点
                object categoryId = e.Node.Tag;

                LoadContentInfo(categoryId);

            }
        }

        private void LoadContentInfo(object categoryId)
        {
            listBox1.Items.Clear();
            string constr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select did,dname from ContentInfo where dtid=@pid";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@pid", categoryId);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int did = reader.GetInt32(0);
                                string dname = reader.GetString(1);
                                WenZhang wz = new WenZhang();
                                wz.WenZhangId = did;
                                wz.WenZhangBiaoTi = dname;
                                listBox1.Items.Add(wz);

                            }
                        }
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //如果listBox当前选定项不为空
            if (listBox1.SelectedItem != null)
            {
                //int obj =Convert.ToInt32( listBox1.SelectedItem);
                //string msg = GetWenZhangNeiRongById(obj);
                //textBox1.Text = msg;

                WenZhang wz = (WenZhang)listBox1.SelectedItem;
                int did = wz.WenZhangId;
                string msg = GetWenZhangNeiRongById(did);
                textBox1.Text = msg;

            }
        }

        private string GetWenZhangNeiRongById(int did)
        {
            string constr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select dcontent from ContentInfo where dId=@id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", did);
                    con.Open();
                    object objContent = cmd.ExecuteScalar();
                    return objContent.ToString();
                }
            }
        }
    }
}
