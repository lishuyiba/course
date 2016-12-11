using _179省市联动;
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

namespace _180省市联动_通过绑定数据源_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Area> list = new List<Area>();

            #region 初始化List集合

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
                                Area model = new Area() { AreaId = reader.GetInt32(0), AreaName = reader.GetString(1) };
                                list.Add(model);
                            }
                        }
                    }
                }
            }

            #endregion

            cboProvince.DisplayMember = "AreaName";
            cboProvince.ValueMember = "AreaId";
            cboProvince.DataSource = list;
        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Area> list = new List<Area>();
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
                                //int areaId = reader.GetInt32(0);
                                //string areaName = reader.GetString(1);
                                Area model = new Area() { AreaName = reader.GetString(1) };
                                //cboCity.Items.Add(areaName);

                                list.Add(model);


                            }
                        }
                    }
                }
            }
            cboCity.DisplayMember = "AreaName";
            cboCity.ValueMember = "AreaId";
            cboCity.DataSource = list;
        }
    }
}
