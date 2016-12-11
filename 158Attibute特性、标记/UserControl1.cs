using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _158Attibute特性_标记
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当前控件的版本
        /// </summary>
        [DisplayName("用户控件版本")]
        [Description("这个是用户控件的版本信息")]
        public string UCVersion
        {
            get;
            set;
        }
    }
}
