using _197通过MD5加密登陆;
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

namespace _210更新拼音字段
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select CC_AutoId,CC_CustomerName from T_Customers";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.IsDBNull(1) ? null : reader.GetString(1);
                        string py = CommonHelper.GetPinYinByString(name);
                        string pyShor = CommonHelper.GetShorPinYinByString(name);
                        int r= SqlHelper.ExecuteNonQuery("update T_Customers set CC_Pinyin=@py,CC_PinyinShort=@pyshort where CC_AutoId=@id",CommandType.Text,new SqlParameter("@py",py),new SqlParameter("@pyshort",pyShor),new SqlParameter("@id",id));
                        if (r>0)
                        {
                            MessageBox.Show("更新成功！");
                        }
                        else
                        {
                            MessageBox.Show("更新失败！");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("没有查询出数据！");
                }
            }
        }
    }
}
