using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _153解析订单xml
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 解释xml（方法一）
            //XDocument xdoc = XDocument.Load("orders.xml");
            //XElement xeRoot = xdoc.Root;
            //string xeName = xeRoot.Element("CustomerName").Value;
            //string xeNumber = xeRoot.Element("OrderNumber").Value;
            //XElement xeItems = xeRoot.Element("Items");
            //Console.WriteLine("最终处理结如下：");
            //Console.WriteLine("\n");
            //Console.WriteLine("姓名：{0}", xeName);
            //Console.WriteLine("订单号：{0}", xeNumber);
            //Console.WriteLine("\t");
            //Console.WriteLine("订购商品：");
            //foreach (XElement item in xeItems.Elements())
            //{
            //    string attrName = item.Attribute("Name").Value;
            //    string attrCount = item.Attribute("Count").Value;
            //    Console.WriteLine("商品名称：{0} 数量：{1}", attrName, attrCount);
            //}
            //Console.ReadKey(); 
            #endregion

            #region 解析xml（方法二）

            XDocument xdoc = XDocument.Load("orders.xml");
            XElement xeRoot = xdoc.Root;
            Console.WriteLine("购买人姓名：{0}", xeRoot.Element("CustomerName").Value);
            Console.WriteLine("订单编号：{0}", xeRoot.Element("OrderNumber").Value);
            Console.WriteLine("购买商品：");
            XElement xeItems = xeRoot.Element("Items");
            foreach (XElement item in xeItems.Elements())
            {
                Console.WriteLine("商品名称：{0} 数量：{1}",item.Attribute("Name").Value,item.Attribute("Count").Value);
            }
            Console.ReadKey();

            #endregion
        }
    }
}
