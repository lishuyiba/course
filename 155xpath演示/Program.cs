using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _155xpath演示
{
    class Program
    {
        static void Main(string[] args)
        {
            //找出所有一年级的学生（level=1）的。
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("stu.xml");
            //返回XmlNodeList就是搜索到的节点
            // "//student[@level=\"1\"]" 就是xpath语法
            XmlNodeList nodeList = xmlDoc.SelectNodes("//student[@level=\"1\"]");
            foreach (XmlNode node in nodeList)
            {
                Console.WriteLine(node.Name+":::"+node.InnerText);
            }
            Console.ReadKey();
        }
    }
}
