using _186添加类别;
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

namespace _187电话管理程序
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private string _s;
        public Main(string s)
            : this()
        {
            _s = s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1.禁用自动生成列
            dataGridView1.AutoGenerateColumns = false;
            cboGroup.SelectedIndex = 0;


            LoadDataGridView();




        }

        private void LoadDataGridView()
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select pid,pname,pcellphone,pHomePhone,ptypeid from phonenum");
            dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //获取当前行的数据
            string name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string pcellphone = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string pHomePhone = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtName.Text = name;
            txtCellPhone.Text = pcellphone;
            txtpHomePhone.Text = pHomePhone;
            string ptypeid = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cboGroup2.Text = ptypeid;

            //主键id
            string pid = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            _s = pid;

        }

        private string DeletePid(DataGridViewCellEventArgs e)
        {
            return dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //执行多条件搜索
            //1.拼接sql语句

            #region 太弱
            //StringBuilder sql = new StringBuilder("select * from PhoneNum where 1=1");

            //if (cboGroup.SelectedIndex != 0)
            //{
            //    sql.Append(" where ptyeid=" + cboGroup.Text.Split('|')[0]);
            //}

            //if (txtSearchName.Text.Trim().Length > 0)
            //{
            //    sql.Append(" and pname like '%" + txtSearchName.Text.Trim() + "%'");
            //}

            //if (txtSearchCellPhone.Text.Trim().Length > 0)
            //{
            //    sql.Append(" and pcellphone like '%" + txtSearchCellPhone.Text.Trim() + "%'");
            //} 
            #endregion

            #region 多条件搜索时，使用List集合来拼接条件（拼接sql）

            //StringBuilder sql = new StringBuilder("select * from PhoneNum");
            //List<string> wheres = new List<string>();
            //if (cboGroup.SelectedIndex != 0)
            //{
            //    //sql.Append(" where ptyeid=" + cboGroup.Text.Split('|')[0]);
            //    wheres.Add(" ptypeid=" + cboGroup.Text.Split('|')[0]);
            //}

            //if (txtSearchName.Text.Trim().Length > 0)
            //{
            //    //sql.Append(" and pname like '%" + txtSearchName.Text.Trim() + "%'");
            //    wheres.Add(" pname like '%" + txtSearchName.Text.Trim() + "%'");
            //}

            //if (txtSearchCellPhone.Text.Trim().Length > 0)
            //{
            //    //sql.Append(" and pcellphone like '%" + txtSearchCellPhone.Text.Trim() + "%'");
            //    wheres.Add(" pcellphone like'%" + txtSearchCellPhone.Text.Trim() + "%'");
            //}

            ////判断用户是否选择了条件
            //if (wheres.Count>0)
            //{
            //    string wh=string.Join(" and ",wheres.ToArray());
            //    sql.Append(" where " + wh);
            //}


            #endregion

            #region 多条件搜索使用带参数的sql语句

            //StringBuilder sql = new StringBuilder("select * from PhoneNum");
            //List<string> wheres = new List<string>();
            //List<SqlParameter> listparameter = new List<SqlParameter>();
            //if (cboGroup.SelectedIndex != 0)
            //{
            //    //sql.Append(" where ptyeid=" + cboGroup.Text.Split('|')[0]);
            //    //wheres.Add(" ptypeid=" + cboGroup.Text.Split('|')[0]);
            //    wheres.Add(" ptypeid=@typeid ");
            //    listparameter.Add(new SqlParameter("@typeid", cboGroup.Text.Split('|')[0]));
            //}

            //if (txtSearchName.Text.Trim().Length > 0)
            //{
            //    //sql.Append(" and pname like '%" + txtSearchName.Text.Trim() + "%'");
            //    //wheres.Add(" pname like '%" + txtSearchName.Text.Trim() + "%'");
            //    wheres.Add(" pname like @pname ");
            //    //pname like '%乔%'
            //    //pname like '%'+pname+'%'
            //    listparameter.Add(new SqlParameter("@pname", "%" + txtSearchName.Text.Trim() + "%"));
            //}

            //if (txtSearchCellPhone.Text.Trim().Length > 0)
            //{
            //    //sql.Append(" and pcellphone like '%" + txtSearchCellPhone.Text.Trim() + "%'");
            //    //wheres.Add(" pcellphone like'%" + txtSearchCellPhone.Text.Trim() + "%'");
            //    wheres.Add(" pcellphone like @cellphone");
            //    listparameter.Add(new SqlParameter("@cellphone", "%" + txtSearchCellPhone.Text.Trim() + "%"));
            //}

            ////判断用户是否选择了条件
            //if (wheres.Count > 0)
            //{
            //    string wh = string.Join(" and ", wheres.ToArray());
            //    sql.Append(" where " + wh);
            //}


            //DataTable dataTable = SqlHelper.ExecuteDataTable(sql.ToString(), listparameter.ToArray());


            #endregion


            #region 测试

            StringBuilder sql = new StringBuilder("select * from PhoneNum");
            List<string> wheres = new List<string>();//存储where
            List<SqlParameter> listparameter = new List<SqlParameter>();//存储要多少个where的个数
            if (cboGroup.SelectedIndex != 0)
            {
                //sql.Append(" where ptyeid=" + cboGroup.Text.Split('|')[0]);
                //wheres.Add(" ptypeid=" + cboGroup.Text.Split('|')[0]);
                wheres.Add(" ptypeid=@typeid ");
                listparameter.Add(new SqlParameter("@typeid", cboGroup.Text.Split('|')[0]));
            }

            if (txtSearchName.Text.Trim().Length > 0)
            {
                //sql.Append(" and pname like '%" + txtSearchName.Text.Trim() + "%'");
                //wheres.Add(" pname like '%" + txtSearchName.Text.Trim() + "%'");
                wheres.Add(" pname like @pname ");
                //pname like '%乔%'
                //pname like '%'+pname+'%'
                listparameter.Add(new SqlParameter("@pname", "%" + txtSearchName.Text.Trim() + "%"));
            }

            if (txtHomePhone.Text.Trim().Length > 0)
            {
                //sql.Append(" and pcellphone like '%" + txtSearchCellPhone.Text.Trim() + "%'");
                //wheres.Add(" pcellphone like'%" + txtSearchCellPhone.Text.Trim() + "%'");
                wheres.Add(" pcellphone like @cellphone");
                listparameter.Add(new SqlParameter("@cellphone", "%" + txtHomePhone.Text.Trim() + "%"));
            }

            //判断用户是否选择了条件
            if (wheres.Count > 0)
            {
                string wh = string.Join(" and ", wheres.ToArray());
                sql.Append(" where " + wh);
            }


            DataTable dataTable = SqlHelper.ExecuteDataTable(sql.ToString(), listparameter.ToArray());
            dataGridView1.DataSource = dataTable;

            #endregion


            //MessageBox.Show(sql.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "delete from PhoneNum where pid=@pid";
            SqlParameter pms = new SqlParameter("@pid", _s);
            SqlHelper.ExecuteNonQuery(sql, pms);
            MessageBox.Show("删除成功！");
            LoadDataGridView();

            //MessageBox.Show(_s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "update PhoneNum set ptypeid=@typeid,pname=@name,pcellphone=@phone,pHomePhone=@homephone where pid=@pid";
            SqlParameter[] pms = new SqlParameter[] { 
                new SqlParameter("@typeid",cboGroup2.Text.Trim()),
                new SqlParameter("@name",txtName.Text.Trim()),
                new SqlParameter("@phone",txtCellPhone.Text.Trim()),
                new SqlParameter("@homephone",txtpHomePhone.Text.Trim()),
                new SqlParameter("@pid",_s)
            };
            SqlHelper.ExecuteNonQuery(sql, pms);
            MessageBox.Show("更新成功！");
            LoadDataGridView();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "delete from PhoneNum where pid=@pid";
            SqlParameter pms = new SqlParameter("@pid", _s);
            SqlHelper.ExecuteNonQuery(sql, pms);
            MessageBox.Show("删除成功！");
            LoadDataGridView();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string sql = "insert into PhoneNum values(@pname,@pcellphone,@phomephone,@ptypeid)";
            //SqlParameter[] pms=new SqlParameter[]{
            //                                        new SqlParameter ("@pname",txtName.Text.Trim()),
            //                                        new SqlParameter ("@pcellphone",txtCellPhone.Text.Trim()),
            //                                        new SqlParameter ("@phomephone",txtpHomePhone.Text.Trim()),
            //                                        new SqlParameter ("@ptypeid",cboGroup2.Text.Trim())
            //};
            //SqlHelper.ExecuteNonQuery(sql, pms);
            //MessageBox.Show("添加成功！");
        }

        private void 添加ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
