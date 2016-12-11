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

namespace _219自己写一个生成Model的代码生成器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //连接数据库，将当前数据库中的所有表加载到ListBox中
            LoadTables();
        }

        private void LoadTables()
        {
            listTables.Items.Clear();
            //要查询当前数据库中的表，需要执行以下SQL语句            
            using (SqlConnection con = new SqlConnection(txtConstr.Text.Trim()))
            {
                string sql = "select TABLE_NAME from INFORMATION_SCHEMA.TABLES";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                listTables.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //进行一系列的字符串拼接
            //1.先获取用户选择的表
            string tbName = listTables.SelectedItem.ToString();
            //2.获取用户输入的命名空间
            string nsName = txtNameSpace.Text.Trim();

            StringBuilder sbCode = new StringBuilder();
            sbCode.AppendLine("using System;");
            sbCode.AppendLine("using System.Collections.Generic;");
            sbCode.AppendLine("using System.Linq;");
            sbCode.AppendLine("using System.Text;");
            sbCode.AppendLine("using System.Threading.Tasks;");
            sbCode.AppendLine("");
            sbCode.AppendLine("namespace " + nsName);
            sbCode.AppendLine("{");
            sbCode.AppendLine("    public class " + tbName);
            sbCode.AppendLine("    {");
            //=========================根据列动态生成属性=================================
            List<ColumnInfo> listColumn = GetColumnInfoByTableName(tbName);
            foreach (ColumnInfo item in listColumn)
            {
                sbCode.AppendLine("        public "+ChangeDbTypeToCSharpType(item.DataType,item.IsNullable)+" "+ChangeToPropertyName(item.ColumnName));
                sbCode.AppendLine("        {");
                sbCode.AppendLine("            get;");
                sbCode.AppendLine("            set;");
                sbCode.AppendLine("        }");
            }
            //=========================根据列动态生成属性=================================
            sbCode.AppendLine("    }");
            sbCode.AppendLine("}");
            txtResult.Text = sbCode.ToString();
        }

        private string ChangeDbTypeToCSharpType(string dbType,string isnullable)
        {
            #region 没有判断值类型

            //string csharpType = string.Empty;
            //switch (dbType)
            //{
            //    case "char":
            //    case "nchar":
            //    case "varchar":
            //    case "nvarchar":
            //    case "text":
            //    case "ntext":
            //        csharpType = "string";
            //        break;
            //    case "bit":
            //        csharpType = "bool";
            //        break;
            //    case "int":
            //        csharpType = "int";
            //        break;
            //}
            //if (isnullable.ToLower() == "yes")
            //{
            //    csharpType += "?";
            //}
            //return csharpType;

            #endregion

            #region 已判断数据类型（不完美）
            Type csharpType = null;
            switch (dbType)
            {
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                    csharpType = typeof(string);
                    break;
                case "bit":
                    csharpType = typeof(bool);
                    break;
                case "int":
                    csharpType = typeof(int);
                    break;
            }
            if (isnullable.ToLower() == "yes" && csharpType.IsValueType)
            {
                return csharpType.ToString() + "?";
            }
            return csharpType.ToString(); 
            #endregion
        }

        //把属性的首字母变成大写
        private string ChangeToPropertyName(string fieldName)
        {
            return char.ToUpper(fieldName[0]) + fieldName.Substring(1);
        }

        private List<ColumnInfo> GetColumnInfoByTableName(string tbName)
        {
            List<ColumnInfo> list = new List<ColumnInfo>();
            using (SqlConnection con = new SqlConnection(txtConstr.Text.Trim()))
            {
                string sql = "select COLUMN_NAME,DATA_TYPE,IS_NULLABLE from INFORMATION_SCHEMA.COLUMNS where table_name='" + tbName + "'";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ColumnInfo model = new ColumnInfo();
                                model.ColumnName = reader.GetString(0);
                                model.DataType = reader.GetString(1);
                                model.IsNullable = reader.GetString(2);
                                list.Add(model);
                            }
                        }
                    }
                }
            }
            return list;
        }
    }
}
