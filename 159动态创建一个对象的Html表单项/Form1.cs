using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _159动态创建一个对象的Html表单项
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Person 表单
            Person p1 = new Person();
            p1.Name = "yzk";
            p1.Age = 19;
            p1.Email = "yzk@rupeng.com"; 
            #endregion


            //Car c1 = new Car() { Brand = "兰博基尼", LicenseNo = "京00000000" };

            CreateFormByObject(p1);
        }

        private void CreateFormByObject(object obj)
        {
            //获取这个对象的type
            Type type = obj.GetType();
            StringBuilder sbHtml = new StringBuilder();

            //获取当前对象中的所有属性
            PropertyInfo[] pinfo = type.GetProperties();
            foreach (PropertyInfo item in pinfo)
            {
                //sbHtml.Append(item.Name + ":<input value=\""+item.GetValue(obj,null)+"\"/><br/>");

                //===========读取特性中的内容，判断当前的显示语言=============
                //获取当前遍历的属性Brand上所标记的UserLanguageAttribute特性
                object[] objs = item.GetCustomAttributes(typeof(UserLanguageAttribute), false);
                //表示当前属性标记了这个特性（UserLanguageAttribute）
                if (objs.Length > 0)
                {
                    UserLanguageAttribute ula = (UserLanguageAttribute)objs[0];
                    sbHtml.Append(ula.DisplayLanguage + ":<input value=\"" + item.GetValue(obj, null) + "\"/><br/>");
                }
                else
                {
                    //没有标记特性
                    sbHtml.Append(item.Name + ":<input value=\"" + item.GetValue(obj, null) + "\"/><br/>");
                }

            }
            webBrowser1.DocumentText = sbHtml.ToString();
        }
    }

    public class Person
    {
        [UserLanguage("姓名")]
        public string Name
        {
            get;
            set;
        }

        [UserLanguage("年龄")]
        public int Age
        {
            get;
            set;
        }

        [UserLanguage("邮箱")]
        public string Email
        {
            get;
            set;
        }
    }

    public class Car
    {
        [UserLanguage("品牌")]
        public string Brand
        {
            get;
            set;
        }

        [UserLanguage("车牌号码")]
        public string LicenseNo
        {
            get;
            set;
        }
    }
    public class UserLanguageAttribute : Attribute
    {
        public UserLanguageAttribute(string lan)
        {
            this.DisplayLanguage = lan;
        }
        public string DisplayLanguage
        {
            get;
            set;
        }
    }
}
