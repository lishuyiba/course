using _217三层实现增删查改.BLL;
using _217三层实现增删查改.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _217三层实现增删查改.UI
{
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int age = Convert.ToInt32(txtAge.Text.Trim());
            int? height = string.IsNullOrEmpty(txtHeight.Text.Trim()) ? null : (int?)Convert.ToInt32(txtHeight.Text.Trim());
            bool? gender = string.IsNullOrEmpty(cboGender.Text.Trim()) ? null : (bool?)(cboGender.Text == "男" ? true : false);

            TblPerson model = new TblPerson();
            model.Uname = name;
            model.Age = age;
            model.Height = height;
            model.Gender = gender;

            TblPersonBll bll = new TblPersonBll();
            int r = bll.Insert(model);
            MessageBox.Show("插入成功！自动编号"+r);
        }
    }
}
