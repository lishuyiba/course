using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtEditorInterface
{
    /// <summary>
    /// 定义接口
    /// </summary>
    public interface IEditor
    {
        //是一个只读属性，里面存储的是插件名称。
        string PluginName
        {
            get;
        }

        //启动插件程序
        void StartProgram(TextBox txtBox);
    }
}
