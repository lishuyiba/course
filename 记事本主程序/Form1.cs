using ExtEditorInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本主程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //主程序的窗体加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            //1.检查plugins目录下是否有dll文件
            //1.1获取当前执行exe文件的绝对路径
            string exePath = Assembly.GetExecutingAssembly().Location;
            //1.2获取插件的目录路径
            string pluginsPath = Path.Combine(Path.GetDirectoryName(exePath), "plugins");


            //思路：如果有dll文件，则循环遍历将每个dll文件都通过Assembly.LoadFile()加载起来，然后获取dll程序集中德类型。

            //2.1搜索pluginsPath目录下是否有对应的dll文件
            //2.1.1返回值是一个string数组，里面存储了每个dll文件的完整路径
            string[] dlls = Directory.GetFiles(pluginsPath);

            //3.循环遍历把每个插件（dll）都加载起来。
            foreach (string item in dlls)
            {
                //3.1这里每个item就是每个dll的完整路径
                //3.2加载item程序集内容(将每个插件加载起来)
                Assembly asem = Assembly.LoadFile(item);

                //思路：获取当前插件（当前的asem这个程序集中对应的类型，然后调用方法就可以了）

                //4.遍历asem这个插件（程序集）中的每个类型，找到那些public类型，并且是实现了IEditor接口的类。
                //4.1获取所有的public类型
                Type[] typs = asem.GetExportedTypes();

                //4.2获得接口的Type
                Type typeIEditor = typeof(IEditor);

                //4.3遍历每个类型看看这个类型是否实现了IEditor接口的类型
                foreach (Type typeClass in typs)
                {
                    //4.4判断当前类型typeClass是否实现了IEditor这个接口。
                    //4.4.1并且这个类型是可以被实例化的，否则不能用。
                    if (typeIEditor.IsAssignableFrom(typeClass) && !typeClass.IsAbstract)
                    {
                        //5.创建一个typeClass类型的对象
                        IEditor editor = (IEditor)Activator.CreateInstance(typeClass);

                        //6.1在菜单栏中，将该插件的名称增加进去
                        //6.2获取该插件tsiMenu的点击事件
                        ToolStripItem tsiMenu = this.格式ToolStripMenuItem.DropDownItems.Add(editor.PluginName);

                        tsiMenu.Tag = editor;

                        //7.为tsiMenu注册一个单击事件
                        tsiMenu.Click += tsiMenu_Click;
                    }
                }

            }



        }

        //菜单栏新增插件的单击事件
        void tsiMenu_Click(object sender, EventArgs e)
        {
            //sender就是当前单击的菜单项
            ToolStripItem tsi = (ToolStripItem)sender;

            IEditor editor = (IEditor)tsi.Tag;
            editor.StartProgram(textBox1);
        }
    }
}
