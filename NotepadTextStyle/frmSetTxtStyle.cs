using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadTextStyle
{
    public partial class frmSetTxtStyle : Form
    {
        public frmSetTxtStyle()
        {
            InitializeComponent();
        }
        public frmSetTxtStyle(TextBox txtBox)
            : this()
        {
            _txtBox = txtBox;
        }
        private TextBox _txtBox;

        private void btnOK_Click(object sender, EventArgs e)
        {
            float size = float.Parse(cboFontSize.Text);
            _txtBox.Font = new Font(cboFontFamily.Text, size);
            this.Close();
        }
    }
}
