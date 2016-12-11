using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace xml序列化演示
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Name = "yzk";
            //p.Age = 19;
            //p.Email = "yzk@rupeng.com";

            #region 自己写xml序列化
            
            //DoXmlSerialize("MyXml.xml",p);            

            #endregion

            #region 自己写 特性

            MyClass mc = new MyClass();
            mc.Name = "sk";
            mc.Age = 10;
            DoXmlSerialize("MyXml.xml", mc);

            #endregion

            //Person p1 = new Person();
            //p1.Name = "sk";
            //p1.Age = 20;
            //p1.Email = "sk@rupeng.com";


            #region xml序列化List集合
            
            //List<Person> list=new List<Person>();
            //list.Add(p);
            //list.Add(p1);
            //XmlSerializer xmlSer=new XmlSerializer(typeof(List<Person>));
            //using (FileStream fs= (File.OpenWrite("list.xml")))
            //{
            //    xmlSer.Serialize(fs, list);
            //}

            #endregion

            #region xml序列化对象

            ////xml序列化
            //XmlSerializer xmlSer = new XmlSerializer(typeof(Person));
            //using (FileStream fs = File.OpenWrite("person.xml"))
            //{
            //    xmlSer.Serialize(fs, p);
            //} 

            #endregion

            Console.WriteLine("xml序列号成功！");
            Console.ReadKey();
        }


            static void DoXmlSerialize(string path, object obj)
            {
                Type typeObj=obj.GetType();
                //1.要写入xml的根节点，根节点是类型的名
                string clsName=typeObj.Name;
                XDocument xdoc=new XDocument();
                XElement xeRoot=new XElement(clsName);
                xdoc.Add(xeRoot);

                //2.创建这个类型的每个属性的xml节点
                PropertyInfo[] pinfos=typeObj.GetProperties();
                foreach (PropertyInfo property in pinfos)
                {
                    //通过每个属性的property获取，该属性的CanNotSerializable特性，看有没有这个特性，如果有就不可以化，如果没有就可以序列化
                    object[] objAttrs = property.GetCustomAttributes(typeof(CanNotSerializableAtteibute), false);
                    if (objAttrs.Length<=0)//表示没有标志特性，即可xml序列化
                    {
                        //如果没有CanNotSerializable这个特性就执行序列化
                        //对于每个属性都要创建一个xml元素
                        XElement xElement = new XElement(property.Name, property.GetValue(obj, null));

                        xeRoot.Add(xElement);
                    }


                   
                }
                xdoc.Save(path);
            }


        }
    }

    public class MyClass
    {
        public string Name
        {
            get;
            set;
        }
        
        [CanNotSerializableAtteibute]
        public int Age
        {
            get;
            set;
        }
    }

    public class CanNotSerializableAtteibute:Attribute
    {
        
    }

    public class Person
    {
        //打上这个标志，属性就不会被xml序列化
        //[XmlIgnore]
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
    }

