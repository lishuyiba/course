using ExtEditorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadConvertToUpper
{
    public class Class1:IEditor
    {
        public string PluginName
        {
            get { return "转换大写"; }
        }

        public void StartProgram(System.Windows.Forms.TextBox txtBox)
        {
            txtBox.Text = txtBox.Text.ToUpper();
        }
    }
}
