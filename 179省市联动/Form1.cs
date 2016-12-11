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

namespace _179省市联动
{
    //当把DropDownStyle设置为DropDownList的时候，会将直辖市的[市]cboCity清空，否则会造成：cboProvnice选择“北京市”的时候cobCity还是显示“南宁市”
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProvince();
        }

        private void LoadProvince()
        {
            //cboProvince.Items.Clear();
            string constr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select * from TblArea where AreaPId=0";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int areaId = reader.GetInt32(0);
                                string areaName = reader.GetString(1);
                                Area model = new Area() { AreaId = areaId, AreaName = areaName };
                                cboProvince.Items.Add(model);
                            }
                        }
                    }
                }
            }
            //在下拉菜单显示“请选择”
            Area mode = new Area() { AreaId = -1, AreaName = "请选择" };
            cboProvince.Items.Insert(0, mode);
            cboProvince.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string obj = cboProvince.SelectedItem.ToString();
            //MessageBox.Show(obj);

            //获取当前选中项的id与name
            //1.获取当前下拉菜单的选中项
            Area mode = (Area)cboProvince.SelectedItem;
            MessageBox.Show(mode.AreaId + " " + mode.AreaName);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 省份下拉菜单的选中项改变事件
        /// </summary>
        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            //每次清空一下
            cboCity.Items.Clear();
            string constr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select * from TblArea where AreaPId=@pid";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    int pid = ((Area)cboProvince.SelectedItem).AreaId;
                    cmd.Parameters.AddWithValue("@pid", pid);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int areaId = reader.GetInt32(0);//
                                string areaName = reader.GetString(1);

                                Area model = new Area();
                                model.AreaId = areaId;
                                model.AreaName = areaName;
                                cboCity.Items.Add(model);//因为cboCity不能传递两个参数，所以要通过Area对象来封装areaId、areaName
                                #region 只获取城市名称

                                //cboCity.Items.Add(areaName);

                                #endregion
                            }
                        }
                    }
                }
            }

            #region cboCity默认选中第0项
            if (cboCity.Items.Count <= 0)
            {

            }
            else
            {
                cboCity.SelectedIndex = 0;
            }
            #endregion            
        }
    }
}
