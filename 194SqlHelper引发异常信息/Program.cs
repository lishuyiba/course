using _185通过SqlHelper实现增删查改;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _194SqlHelper引发异常信息
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sql = "select count(*) from tblstudent";
            //int r = (int)SqlHelper.ExecuteScalar(sql,System.Data.CommandType.Text);
            //Console.WriteLine(r);
            //Console.WriteLine("OK");
            //Console.ReadKey();

            #region MyRegion

            //参数一般用在where语句后，或者赋值时：select @count=.... from
            //不能把表名、列名等用参数来代替
            //比如 select @col1,@col2 from @biao1
            //所以下面的做法是错误的。
            string sql = "select count(*) from @tbname";
            SqlParameter p1 = new SqlParameter("@tbname", "tblstudent");
            int r = (int)SqlHelper.ExecuteScalar(sql, System.Data.CommandType.Text, p1);
            Console.WriteLine(r);
            Console.ReadKey();

            //            --可以这么用，但是存在SQL漏洞攻击
            //--可以设置declare @tbname nvarchar(1000)的字符数减少，比如declare @tbname nvarchar(11)，这样写了以后，就会过滤掉后面添加的内容
            //--也可以设置sa权限只能查询
            //--使用动态sql非常灵活，但不可避免注入攻击，通过各种手段只能减少危害，不能完全避免
            //--比如：设置变量的最大长度、将用户输入的内容中替换所有的关键字,特殊符号等等、设置用户的权限只能查询、金庸数据库中的一些危险功能。
            //declare @sql nvarchar(1000)
            //declare @tbname nvarchar(11)
            //set @tbname=' tblstudent;select * from sysobjects'
            //set @sql='select * from'
            //set @sql=@sql+@tbname
            //exec(@sql)

            #endregion
        }
    }
}
