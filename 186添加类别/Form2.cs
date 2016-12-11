using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _186添加类别
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();//默认调用 默认的无参数构造函数
        }

        public Form2(int pid)
            : this()//先调用InitializeComponent();方法再调用 _pid = pid;这个方法
        {
            _pid = pid;//也要调用默认的无参数构造函数
        }
        private int _pid;

        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //引用类型
            //好处：省去装箱和拆箱
            //缺点：等垃圾回收后才能把变量回收
            
            //值类型
            //好处：用完之后，出了变量作用域就马上释放，不需要等待垃圾回收
            //缺点：需要装箱和拆箱

            string name = txtCateName.Text.Trim();
            string desc = txtCateDesc.Text.Trim();

            string sql = "insert into Category values(@name,@pid,@desc)";
            SqlParameter[] pms=new SqlParameter[]{
                new SqlParameter("@name",name),
                new SqlParameter("@pid",_pid),
                new SqlParameter("@desc",desc)
            };
            SqlHelper.ExecuteNonQuery(sql, pms);

            if (Update!=null)
            {
                //在Update方法中为了避免刷新整个TreeView，可以考虑更新时，只动态增加一个节点而不是刷新整个TreeView，需要插入的时候通过output获取刚刚插入的自动编号。
                //然后将自动编号与类别名称通过委托参数回传给Form1窗体。
                Update();
            }
            MessageBox.Show("添加成功！");
            this.Close();

        }
        public new  UpdateTreeViewDelegate Update;
    }
}
