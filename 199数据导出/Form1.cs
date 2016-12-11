using _197通过MD5加密登陆;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _199数据导出
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from T_Seats";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text))
            {
                if (reader.HasRows)
                {
                    //在这里创建一个Workbook
                    using (Workbook wk = new HSSFWorkbook())
                    {
                        //创建一个sheet（工作表）
                        using (Sheet sheet = wk.CreateSheet("CallCenter"))
                        {                            
                            //每循环一次就创建一行
                            int rowIndex = 0;
                            #region 循环创建行与列
                            while (reader.Read())
                            {
                                #region 获取列数据
                                //autoId, loginId, realName, loginPwd
                                int autoid = reader.GetInt32(0);
                                string loginId = reader.GetString(1);
                                string realname = reader.GetString(2);
                                string loginpwd = reader.GetString(3);

                                //测试数据读取
                                // Console.WriteLine("{0}-{1}-{2}-{3}", autoid, loginId, realname, loginpwd);
                                #region 可空值类型
                                //int? fage = reader.IsDBNull(2) ? null :(int?) reader.GetInt32(2);
                                //int? n = null;
                                #endregion
                                #endregion
                                //每循环一次就创建一行
                                Row row = sheet.CreateRow(rowIndex);
                                //创建单元格                               
                                row.CreateCell(0).SetCellValue(autoid);
                                row.CreateCell(1).SetCellValue(loginId);
                                row.CreateCell(2).SetCellValue(realname);
                                row.CreateCell(3).SetCellValue(loginpwd);
                                #region 对realname空值问题处理
                                //if (realname == null)
                                //{
                                //    row.CreateCell(2, CellType.BLANK);
                                //}
                                //else
                                //{
                                //    row.CreateCell(2).SetCellValue(realname);
                                //}
                                #endregion
                                rowIndex++;
                            } 
                            #endregion

                            #region 导出数据到Excel
                            using (FileStream fs = File.OpenWrite("myT_Seats.xls"))
                            {
                                wk.Write(fs);
                                MessageBox.Show("数据导出成功！");
                            } 
                            #endregion
                        }
                    }
                }
                else
                {
                    MessageBox.Show("表中没有数据！");
                }
            }
        }
    }
}
