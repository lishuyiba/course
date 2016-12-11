using ExtEditorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadTextStyle
{
    public class SetTextStyle:IEditor
    {

        public string PluginName
        {
            get { return "设置字体与字号"; }
        }

        public void StartProgram(System.Windows.Forms.TextBox txtBox)
        {
            frmSetTxtStyle frm = new frmSetTxtStyle(txtBox);
            frm.Show();
        }
    }
}
