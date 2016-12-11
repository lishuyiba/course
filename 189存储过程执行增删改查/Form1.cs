using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _189存储过程执行增删改查
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=lenovo-pc;Initial Catalog=ItCastCn;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string usp_talCls_insert = "usp_talCls_insert";
                using (SqlCommand cmd = new SqlCommand(usp_talCls_insert, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter[] pms = new SqlParameter[] { 
                        new SqlParameter("@clsName",txtname.Text.Trim()),
                        new SqlParameter("@clsDesc",txtDesc.Text)
                    };
                    cmd.Parameters.AddRange(pms);
                    con.Open();
                    int r = cmd.ExecuteNonQuery();
                    con.Close();
                    if (r>0)
                    {
                        MessageBox.Show("插入成功！");
                    }
                    else
                    {
                        MessageBox.Show("插入失败！");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSelecte_Click(object sender, EventArgs e)
        {
            List<ClassModel> list = new List<ClassModel>();
            string constr = "Data Source=lenovo-pc;Initial Catalog=ItCastCn;Integrated Security=True";
            using (SqlConnection con=new SqlConnection(constr))
            {
                string usp_tblCls_selectAll = "usp_tblCls_selectAll";
                using (SqlCommand cmd=new SqlCommand(usp_tblCls_selectAll,con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (SqlDataReader reader=cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ClassModel model = new ClassModel();
                                model.clsName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                                model.clsDesc = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                                list.Add(model);
                            }
                        }
                    }
                }
            }
            dataGridView1.DataSource = list;
        }
    }
}
