using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _186添加类别
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            #region MyRegion
            //string sql = "insert into TblClass values('AAAAA','5A班级')";

            ////1.
            //SqlParameter[] pms = new SqlParameter[] { 
            //new SqlParameter(),
            //new SqlParameter()
            //};

            ////2.
            //pms = null;

            //int r = SqlHelper.ExecuteNonQuery(sql);
            //MessageBox.Show("成功插入" + r + "行。"); 
            #endregion

            LocadCategory();
        }

        private void LocadCategory()
        {
            //1.加载所有的父类别
            List<Category> list = new List<Category>();
            //将所有父类别加载到List集合中
            GetParentCategory(list);
            foreach (Category categoryItem in list)
            {
                TreeNode tnode = treeView1.Nodes.Add(categoryItem.CategoryName);
                tnode.Tag = categoryItem.CategoryId;

                #region 为每个父节点设置右键菜单

                tnode.ContextMenuStrip = contextMenuStrip2;

                #endregion


                //对于每个父类别，要加载对应的子类别
                LoadSubCategory(tnode);//这里本来可以用两个参数，但是由于Tag已经把id存储了，不过，也可以使用两个参数

            }
        }

        private void LoadSubCategory(TreeNode tnode)
        {
            //1.根据当前父类别的Id查询对应的字类别
            string sql = "select tid,tname from Category where tParentId=@pid";

            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@pid", tnode.Tag)))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Category mode = new Category();
                        //mode.CategoryId = reader.GetInt32(0);
                        //mode.CategoryName = reader.GetString(1);
                        //tnode.Nodes.Add(mode.CategoryName);

                        object id = reader.GetValue(0);
                        //int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        TreeNode tsubNode = tnode.Nodes.Add(name);
                        tsubNode.Tag = id;

                        #region 设置子节点的右键菜单
                        tsubNode.ContextMenuStrip = contextMenuStrip1;
                        #endregion

                    }
                }

            }

        }

        private void GetParentCategory(List<Category> list)
        {
            string sql = "select tid,tname from Category where tParentId=-1";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Category model = new Category();
                        model.CategoryId = reader.GetInt32(0);
                        model.CategoryName = reader.GetString(1);
                        list.Add(model);
                    }
                }
            }
        }

        //菜单项的单击事件
        private void tsmiAddSubCategory_Click(object sender, EventArgs e)
        {
            //1.获取当前选择的节点Tag中的Id
            int id = Convert.ToInt32(treeView1.SelectedNode.Tag);
            Form2 f2 = new Form2(id);

            f2.Update = UpdateTreeView;

            f2.Show();


        }


        private void UpdateTreeView()
        {
            //在这里更新主窗体
            treeView1.Nodes.Clear();
            LocadCategory();
        }


        //将制定的文件夹下的文本文件导入到ContentInfo表中
        private void tsmiImportWenZhang_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;//设置多选
            openFileDialog1.Filter = "txt|*txt";//限定打开文本文件
            DialogResult result = openFileDialog1.ShowDialog();//显示打开对话框
            if (result == DialogResult.OK)//判断用户是否按下OK
            {
                //files里面存储的就是每个文本文件的路径
                string[] files = openFileDialog1.FileNames;

                //循环每个文件，并导入
                foreach (string filePath in files)
                {
                    //文章内容
                    string content = File.ReadAllText(filePath, Encoding.GetEncoding("gb2312"));

                    //文章标题(没有后缀名)
                    string title = Path.GetFileNameWithoutExtension(filePath);

                    //文章列别Id，就是当前选中类别的Tag
                    object categoryId = treeView1.SelectedNode.Tag;

                    string sql = "insert into ContentInfo(dtid,dname,dcontent) values(@id,@name,@content)";
                    SqlParameter[] pms = new SqlParameter[] { 
                    new SqlParameter("@id",categoryId),
                    new SqlParameter("@name",title),
                    new SqlParameter("@content",content),
                    };


                    SqlHelper.ExecuteNonQuery(sql, pms);
                    MessageBox.Show("导入成功！");


                }

            }
        }

        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            //1.获取当前选中类别的Id
            object id = treeView1.SelectedNode.Tag;

            //2.执行删除的sql语句
            string sql = "delete from Category where tid=@tid";
            SqlHelper.ExecuteNonQuery(sql, new SqlParameter("@tid", id));

            //3.从TreeView上将该节点删除
            treeView1.SelectedNode.Remove();
            MessageBox.Show("删除成功！");

        }

    }
}
