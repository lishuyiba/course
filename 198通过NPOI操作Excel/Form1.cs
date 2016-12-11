using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _198通过NPOI操作Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.读取Excel到FileStream
            using (FileStream fs = File.OpenRead("ReadExcel.xlsx"))
            {
                //2.根据文件流fs创建一个Workbook
                using (Workbook wk = new HSSFWorkbook(fs))
                {
                    //3.循环获取工作表的工数
                    //wk.NumberOfSheets获取当前“工作簿”中的工作表的个数
                    for (int i = 0; i < wk.NumberOfSheets; i++)
                    {
                        //循环获取每一个工作表
                        using (Sheet sheet = wk.GetSheetAt(i))
                        {
                            //循环遍历当前"工作表"中的每一行
                            //sheet.LastRowNum [获取最后一行的索引]
                            for (int r = 0; r <= sheet.LastRowNum; r++)
                            {
                                //输出工作表名称
                                Console.WriteLine("===================={0}====================",sheet.SheetName);
                                //循环获取每一行
                                Row row = sheet.GetRow(r);

                                //获取行的单元格
                                //row.LastCellNum [获取最后一个单元格的索引]
                                for (int c = 0; c < row.LastCellNum; c++)
                                {
                                    //获取每行中的每个单元格
                                    Cell cell = row.GetCell(c);
                                    Console.Write(cell.ToString() + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1.创建一个Workbook
            using (Workbook wk=new HSSFWorkbook())
            {
                //2.创建一个工作表sheet
                using (Sheet sheet=wk.CreateSheet("工作表1"))
                {
                    //3.创建行
                    //创建第一行（索引是0，所以是第一行）
                    Row row1 = sheet.CreateRow(0);

                    //为row1中创建一些cell
                    for (int i = 0; i < 10; i++)
                    {
                        row1.CreateCell(i).SetCellValue("单元格"+i);
                    }

                    //再创建一个行，如果这里再把索引写为0，则会将上一行覆盖掉
                    Row row2 = sheet.CreateRow(1);

                    //创建单元格中的值
                    row2.CreateCell(0).SetCellValue("单元格一中的值");
                    row2.CreateCell(1).SetCellValue("单元格二中的值");

                    //创建一个文件流
                    using (FileStream fs=File.OpenWrite("my.xls"))
                    {
                        wk.Write(fs);
                        MessageBox.Show("Excel已经写入成功！");
                    }                    
                }
            }
        }



    }
}
