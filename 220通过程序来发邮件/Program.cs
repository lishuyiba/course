using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _220通过程序来发邮件
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 发一封普通的邮件（纯文本）
            //Console.WriteLine("开始发送...");
            ////1.MailMessage （创建一个邮件）
            //MailMessage msg = new MailMessage();
            //msg.From = new MailAddress("sk@lsy.com");//来自谁
            //msg.To.Add(new MailAddress("yzk@lsy.com"));//发给谁
            ////msg.CC //抄送对方都能收到邮件，但是语义不一样。（To -- 对方要处理邮件的人，CC -- 对方只要知道有这件事就可以了（比如：我让他去买份饭，财务知道就可以了））
            //msg.Subject = "去给我带份饭。";//主题
            //msg.SubjectEncoding = Encoding.GetEncoding("gb2312");
            //msg.Body = "在明天中午12：00点之前把饭送过来";

            ////2.SmtpClient （把邮件发出去）
            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = "localhost";//发件服务器SMTP地址
            //smtp.Credentials = new NetworkCredential("sk","123");//验证发送者的账号和密码
            //smtp.Send(msg);
            //Console.WriteLine("发送完毕！"); 
            #endregion


            #region 发送html格式邮件（一种方式）

            //Console.WriteLine("开始发送...");
            ////1.MailMessage （创建一个邮件）
            //MailMessage msg = new MailMessage();
            //msg.From = new MailAddress("sk@lsy.com");//来自谁
            //msg.To.Add(new MailAddress("yzk@lsy.com"));//发给谁
            //msg.Subject = "去给我带份饭。";//主题
            //msg.SubjectEncoding = Encoding.GetEncoding("gb2312");
            //msg.Body = "在明天中午<font color=\"red\"><h1></h1>12：00</font>点之前把饭送过来";
            //设置文本征文是否是html格式。
            //msg.IsBodyHtml = true;

            ////2.SmtpClient （把邮件发出去）
            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = "localhost";//发件服务器SMTP地址
            //smtp.Credentials = new NetworkCredential("sk", "123");//验证发送者的账号和密码
            //smtp.Send(msg);
            //Console.WriteLine("发送完毕！");
            //Console.ReadKey();

            #endregion


            #region 发送html格式邮件（第二种方式）


            //Console.WriteLine("开始发送...");
            ////1.MailMessage （创建一个邮件）
            //MailMessage msg = new MailMessage();
            //msg.From = new MailAddress("sk@lsy.com");//来自谁
            //msg.To.Add(new MailAddress("yzk@lsy.com"));//发给谁
            //msg.Subject = "========去给我带份饭。==========";//主题
            //msg.SubjectEncoding = Encoding.GetEncoding("gb2312");
            //msg.Body = "在明天中午12：00点之前把饭送过来";
            ////创建一个html格式的文档
            //AlternateView aview = AlternateView.CreateAlternateViewFromString("在明天中午<h1><font color=\"red\">12：00</font></h1>点之前把饭送过来",Encoding.UTF8,"text/html");



            ////2.SmtpClient （把邮件发出去）
            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = "localhost";//发件服务器SMTP地址
            //smtp.Credentials = new NetworkCredential("sk", "123");//验证发送者的账号和密码
            //smtp.Send(msg);
            //Console.WriteLine("发送完毕！");
            //Console.ReadKey();

            #endregion


            #region 在邮件中带图片

            //Console.WriteLine("开始发送...");
            ////1.MailMessage （创建一个邮件）
            //MailMessage msg = new MailMessage();
            //msg.From = new MailAddress("sk@lsy.com");//来自谁
            //msg.To.Add(new MailAddress("yzk@lsy.com"));//发给谁
            //msg.Subject = "========去给我带份饭。==========";//主题
            //msg.SubjectEncoding = Encoding.GetEncoding("gb2312");
            //msg.Body = "在明天中午12：00点之前把饭送过来";

            //#region 添加图片
            ////创建一个html格式的文档
            //AlternateView aview = AlternateView.CreateAlternateViewFromString("在明天中午<h1><font color=\"red\">12：00</font></h1>点之前把饭送过来<br/><img src=\"cid:jpg001\"/>", Encoding.UTF8, "text/html");
            ////为邮件中增加一张图片
            //LinkedResource resource = new LinkedResource(@"f:\1.jpg");
            //resource.ContentId = "jpg001";
            //aview.LinkedResources.Add(resource);
            //msg.AlternateViews.Add(aview);
            
            //#endregion

            ////2.SmtpClient （把邮件发出去）
            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = "localhost";//发件服务器SMTP地址
            //smtp.Credentials = new NetworkCredential("sk", "123");//验证发送者的账号和密码
            //smtp.Send(msg);
            //Console.WriteLine("发送完毕！");
            //Console.ReadKey();

            #endregion


            #region 在邮件中增加附件

            Console.WriteLine("开始发送...");
            //1.MailMessage （创建一个邮件）
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("sk@lsy.com");//来自谁
            msg.To.Add(new MailAddress("yzk@lsy.com"));//发给谁
            msg.Subject = "========去给我带份饭。==========";//主题
            msg.SubjectEncoding = Encoding.GetEncoding("gb2312");
            msg.Body = "在明天中午12：00点之前把饭送过来";

            #region 添加图片
            //创建一个html格式的文档
            AlternateView aview = AlternateView.CreateAlternateViewFromString("在明天中午<h1><font color=\"red\">12：00</font></h1>点之前把饭送过来<br/><img src=\"cid:jpg001\"/>", Encoding.UTF8, "text/html");
            //为邮件中增加一张图片
            LinkedResource resource = new LinkedResource(@"f:\1.jpg");
            resource.ContentId = "jpg001";
            aview.LinkedResources.Add(resource);
            msg.AlternateViews.Add(aview);

            #endregion

            #region 增加附件

            Attachment attachFile1 = new Attachment(@"f:\info.csv");
            Attachment attachFile2 = new Attachment(@"f:\info.csv");
            Attachment attachFile3 = new Attachment(@"f:\info.csv");

            msg.Attachments.Add(attachFile1);
            msg.Attachments.Add(attachFile2);
            msg.Attachments.Add(attachFile3);


            #endregion

            //2.SmtpClient （把邮件发出去）
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "localhost";//发件服务器SMTP地址
            smtp.Credentials = new NetworkCredential("sk", "123");//验证发送者的账号和密码
            smtp.Send(msg);
            Console.WriteLine("发送完毕！");
            Console.ReadKey();

            #endregion

        }
    }
}
