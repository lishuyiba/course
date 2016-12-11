using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogToText
{
    public class Class1
    {
        public void WriteLog(string msg)
        {
            using (StreamWriter sw= File.AppendText(@"f:\myLogger.txt"))
            {
                sw.WriteLine(msg);
            }
        }
    }
}
