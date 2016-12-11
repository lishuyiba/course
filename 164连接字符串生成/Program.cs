using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _164连接字符串生成
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = "LENOVO-PC";
            scsb.UserID = "sa";
            scsb.Password = "sa";
            scsb.InitialCatalog = "School";
            scsb.ConnectTimeout = 30; //连接超时
            Console.WriteLine(scsb.ConnectionString);
            Console.ReadKey();
        }
    }
}
