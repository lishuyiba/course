using _218三层中的多条件搜索实现方式.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _218三层中的多条件搜索实现方式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Condition> listWhere = new List<Condition>();
            if (txtBookName.Text.Trim().Length > 0)
            {
                Condition con = new Condition();
                con.PropertyName = "BookName";
                con.Value = txtBookName.Text.Trim();
                con.Operation = Opt.Like;
                listWhere.Add(con);
            }
            if (txtAuthor.Text.Trim().Length > 0)
            {
                Condition con = new Condition();
                con.PropertyName = "BookAuthor";
                con.Value = txtAuthor.Text.Trim();
                con.Operation = Opt.Like;
                listWhere.Add(con);
            }
            if (txtPub.Text.Trim().Length > 0)
            {
                Condition con = new Condition();
                con.PropertyName = "BookPub";
                con.Value = txtPub.Text.Trim();
                con.Operation = Opt.Like;
                listWhere.Add(con);
            }
            if (txtPrice.Text.Trim().Length > 0)
            {
                Condition con = new Condition();
                con.PropertyName = "BookPrice";
                con.Value = txtPrice.Text.Trim();
                con.Operation = Opt.Equal;
                listWhere.Add(con);
            }

            BookBLL bll = new BookBLL();
            List<string> list = bll.Search(listWhere);

        }
    }
}
