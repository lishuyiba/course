using _197通过MD5加密登陆;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
//using NPOI.HSSF.UserModel;
//using NPOI.SS.UserModel;
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

namespace _200将Excel数据导入到数据库
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.读取Excel文件中的数据
            using (FileStream fs = File.OpenRead("myT_Seats.xls"))
            {
                //根据文件流创建一个Workbook
                using (Workbook wk = new HSSFWorkbook(fs))
                {
                    if (wk.NumberOfSheets > 0)
                    {
                        //获取第1个“工作表”
                        using (Sheet sheet = wk.GetSheetAt(0))
                        {

                            #region 第二种使用参数方式
                            string sql = "insert into T_Seats values(@loginId,@realName,@loginPwd)";
                            SqlParameter[] pms = new SqlParameter[] {
                                    new SqlParameter("@loginid",null),
                                    new SqlParameter("@realName",null),
                                    new SqlParameter("@loginPwd",null)
                                }; 
                            #endregion

                            //循环读取每一行数据，由于Excel中没有列名，所以直接从第0行开始读取
                            for (int r = 0; r <= sheet.LastRowNum; r++)//注意“=”否则，插入数据的时候会缺失最后 一行
                            {
                                Row row = sheet.GetRow(r);

                                #region 获取列数据
                                #region 解决获取空值问题
                                //string loginid = row.GetCell(1).StringCellValue == "NULL" ? null : row.GetCell(1).StringCellValue; 
                                #endregion
                                string loginid = row.GetCell(1).StringCellValue;
                                string loginname = row.GetCell(2).StringCellValue;
                                string loginpwd =row.GetCell(3).StringCellValue;

                                //测试
                                //Console.WriteLine("{0}-{1}-{2}", loginid, loginname, loginpwd); 
                                #endregion

                                #region 第一种使用参数方式
                                //string sql = "insert into T_Seats values(@loginId,@realName,@loginPwd)";
                                //SqlParameter[] pms = new SqlParameter[] {
                                //#region 解决向数据库中插入空值
                                //    //对于空值，在C#中是null，但是要通过带参数的sql语句向数据库中插入一个null值，则需要使用DBNull.Value
                                //    //new SqlParameter("@loginid",loginid==null?DBNull.Value:(object)loginid),
                                //#endregion
                                //    new SqlParameter("@loginid",loginid),
                                //    new SqlParameter("@realName",loginname),
                                //    new SqlParameter("@loginPwd",loginpwd)
                                //}; 
                                #endregion
                                
                                #region 第二种使用参数方式
                                pms[0].Value = loginid;
                                pms[1].Value = loginname;
                                pms[2].Value = loginpwd;
                                #endregion
                                //同一个参数不能让多个Command对象来使用，如果必须让多个Command对象使用同一组参数的话，那么每个Command对象使用完毕后都需要“cmd.Parameters.Clear();”清空一下。
                                SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);                               
                            }
                            MessageBox.Show("数据导入成功！");
                        }
                    }
                }
            }


            //2.将数据导入到数据库中
        }
    }
}
