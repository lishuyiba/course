using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _154解析xml交易记录
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load("ytbank.xml");
            XElement xeRoot = xdoc.Root;
            foreach (XElement xeMsg in xeRoot.Elements())
            {
                foreach (XElement xeSub in xeMsg.Elements())
                {
                    Console.WriteLine(xeSub.Name+":"+xeSub.Attribute("val").Value);
                }
                Console.WriteLine("=============================================");
            }
            Console.ReadKey();
        }
    }
}
