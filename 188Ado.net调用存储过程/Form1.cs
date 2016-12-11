using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _188Ado.net调用存储过程
{
    public partial class Form1 : Form
    {

        //复习：
        //1.把sql语句变成存储过程名称
        //2.把CommandType设置为storedProcedure
        //3.增加参数的方式与带参数的sql语句一样。
        //4.如果有output参数，则需要设置参数的Direction属性。


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text.Trim();
            string pwd = txtPwd.Text;

            //usp_Login
            string constr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                //本来应该写sql语句，现在变成了存储过程的名称
                string usp_Login = "usp_Login";
                using (SqlCommand cmd = new SqlCommand(usp_Login, con))
                {
                    //由于存储过程有参数，所以这里也得为command对象增加参数
                    //如果要调用存储过程没有参数，则这里不需要为command对象增加参数
                    SqlParameter[] pms = new SqlParameter[] { 
                        new SqlParameter("@uid",uid),
                        new SqlParameter("@pwd",pwd),
                        new SqlParameter("@result",SqlDbType.Bit)
                    };
                    //设置第三个参数是一个oupput参数
                    pms[2].Direction = ParameterDirection.Output;
                    //把参数加进来
                    cmd.Parameters.AddRange(pms);
                    //执行存储过程与sql语句最大的区别：需要设置一个CommandTpye
                    cmd.CommandType = CommandType.StoredProcedure;
                    //执行
                    con.Open();

                    #region ExecuteNonQuery
                    cmd.ExecuteNonQuery(); 
                    #endregion

                    #region ExecuteScalar
                    ////由于该存储过程执行完毕以后没有查询任何的值，所以该方法返回值为null
                    //object obj= cmd.ExecuteScalar();
                    ////MessageBox.Show(obj.ToString());
                    #endregion

                    #region ExecuteReader
                    ////调用执行返回Reader的方法，因为这里不需要得到返回值，所以也不接受返回的DataReader
                    //cmd.ExecuteReader();
                    #endregion

                    //这里要判断用户登陆是否成功，关心的是执行完存储过程以后的输出参数，必须等到sql语句执行完毕
                    bool b =Convert.ToBoolean( pms[2].Value);
                    if (b)
                    {
                        MessageBox.Show("登陆成功！");
                    }
                    else
                    {
                        MessageBox.Show("登陆失败！");
                    }
                    //对于这里的验证登陆的存储过程，由于该存储过程执行完毕以后不返回任何的数据，是否登陆成功是根据输出参数来决定的，所以这里调用存储过程的哪个方法都是可以执行。
                }
            }


        }
    }
}
