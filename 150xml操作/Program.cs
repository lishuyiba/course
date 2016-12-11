using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace _150xml操作
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 把xml文件中的节点作为一个字符串输出
            //XDocument xDoc = XDocument.Load("x1.xml");
            //string xml = xDoc.ToString();
            //Console.WriteLine(xml);
            //Console.ReadKey();
            #endregion;

            #region 读取xml文件 通过XDocument
            ////加载xml文件
            //XDocument xDoc = XDocument.Load("x1.xml");

            ////循环遍历每个节点
            ////获取根元素
            //XElement exRoot = xDoc.Root;

            ////输出根节点的名称
            //Console.WriteLine("根节点：");
            ////Console.WriteLine(exRoot.Name);

            ////递归遍历xml中的每个节点
            //DiGuiGetXml(exRoot);

            //Console.ReadKey(); 
            #endregion

            #region 写入xml文件

            ////1.创建一个xml对象
            //XDocument xdoc = new XDocument();

            ////2.为xdoc增加一个根节点
            //XElement exRoot = new XElement("Websites");//<Website />

            ////3.将根节点加到xdoc中
            //xdoc.Add(exRoot);

            #region 创建元素（方法一）

            ////4.为根节点增加内容
            //XElement xeBaiDu = new XElement("Website");

            ////5.为BaiDu增加一个属性
            //XAttribute attrUrl = new XAttribute("url", "http://www.baidu.com");
            //xeBaiDu.Add(attrUrl);
            //exRoot.Add(xeBaiDu); 

            #endregion

            #region 创建元素（方法二）

            //exRoot.SetAttributeValue("WebsiteCount", 100);
            //XElement exGoogle = new XElement("Website");
            //exGoogle.SetAttributeValue("url", "http://www.google.com");//SetAttributeValue添加 标签
            ////为exGoogle添加子标签
            //exGoogle.SetElementValue("name", "谷歌");//SetElementValue添加 子标签
            //exGoogle.SetElementValue("age", "14");
            //exGoogle.SetElementValue("boss", "谢盖尔");

            //exRoot.Add(exGoogle);

            #endregion

            ////最后：将xdoc写入磁盘文件
            //xdoc.Save(@"f:\Website.xml");

            //Console.WriteLine("xml保存成功！");
            //Console.ReadKey();

            #endregion

            #region 获取某个指定标签的元素

            XDocument xdoc = XDocument.Load("x1.xml");
            XElement xeRoot = xdoc.Root;

            //1.在根节点的直接子元素下搜索
            //Console.WriteLine(xeRoot.Element("itcastJava").Value);

            //2.在根节点下的所有元素（所有后代元素）中搜索
            //Descendants表示所有后代元素
            foreach (XElement item in xeRoot.Descendants("itcastJava"))
            {
                Console.WriteLine(item.Value);
            }
            
            Console.ReadKey();
            #endregion


        }

        //递归遍历xml中的每个节点
        private static void DiGuiGetXml(XElement exRoot)
        {
            //1.遍历exRoot下面的所有子元素
            //exRoot.Elements();//获取exRoot元素下的所有直接子元素
            foreach (XElement ele in exRoot.Elements())
            {
                //将当前遍历的元素输出
                Console.WriteLine(ele.Name);
                //只要还有子文件夹就继续递归
                DiGuiGetXml(ele);
            }
        }
    }
}
