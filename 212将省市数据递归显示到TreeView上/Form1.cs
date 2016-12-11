using _197通过MD5加密登陆;
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

namespace _212将省市数据递归显示到TreeView上
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 旧代码
            //string sql = "select AreaId,AreaName from TblArea where AreaPId=0";
            //SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text);
            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        int areaId = reader.GetInt32(0);
            //        string areaName = reader.GetString(1);
            //        TreeNode treeNode = treeView1.Nodes.Add(areaName);
            //        treeNode.Tag = areaId;
            //    }
            //} 
            #endregion

            //获取所有父Id为0的那些省份与直辖市
            List<Area> list = GetDataByParentId(0);

            //将List中的数据绑定到TreeView上
            LoadDataToTree(treeView1.Nodes, list);

        }

        private void LoadDataToTree(TreeNodeCollection treeNodeCollection, List<Area> list)
        {
            foreach (Area item in list)
            {
                TreeNode tNode = treeNodeCollection.Add(item.AreaName);
                //tNode.Tag = item.AreaId;//记录当前区域的Id

                //获取当前Id对象的所有的子城市
                List<Area> listSub = GetDataByParentId(item.AreaId);
                LoadDataToTree(tNode.Nodes, listSub);
            }
        }


        /// <summary>
        /// 根据父Id获取该区域下面的所有子区域
        /// </summary>
        /// <param name="p">传进来的id</param>
        /// <returns>返回list集合</returns>
        private List<Area> GetDataByParentId(int p)
        {
            List<Area> list = new List<Area>();
            string sql = "select * from TblArea where AreaPId=@pid";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, new SqlParameter("@pid", p)))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Area model = new Area();
                        model.AreaId = reader.GetInt32(0);
                        model.AreaName = reader.GetString(1);
                        model.AreaPId = reader.GetInt32(2);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
    }
}
