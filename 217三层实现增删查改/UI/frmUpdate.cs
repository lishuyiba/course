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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            TblPersonBll bll = new TblPersonBll();

            //由于更新语句是更新表中的列，这时用户实际可能只更新部分列，那么对于那些其他的用户没有要更新的列，则还是更新成原来的值，所以这时需要先将数据库中的原来这行中德数据查询出来赋值给model，然后再更新。
            TblPerson model = bll.GetModelById(id);            

            model.AutoId = id;
            model.Uname = "蒋坤";

            int r = bll.Update(model);
            MessageBox.Show("成功更新"+r+"行");
        }
    }
}
