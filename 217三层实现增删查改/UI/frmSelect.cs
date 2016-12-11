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
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }

        private void frmSelect_Load(object sender, EventArgs e)
        {
            TblPersonBll bll = new TblPersonBll();
            List<TblPerson> list = bll.SelectAll();
            dataGridView1.DataSource = list;
        }
    }
}
