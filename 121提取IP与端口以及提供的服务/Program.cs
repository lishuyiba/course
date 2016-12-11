using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _121提取IP与端口以及提供的服务
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ip = "192.168.10.5[port=21,type=ftp]";
            string ip = "192.168.10.5[port=21]";
            //string regIp = @"^(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})\[[a-zA-Z]+=(\d+),[a-zA-Z]+=([a-zA-Z]+)\]$";//自己写
            string regIp = @"^(\d{1,3}(\.\d{1,3}){3})\[port=(\d{1,5})(,type=([a-zA-Z]+))?\]$";
            Match match = Regex.Match(ip, regIp);
            if (match.Success)
            {
                Console.WriteLine("ip:"+match.Groups[1].Value);
                Console.WriteLine("port:" + match.Groups[3].Value);
                //Console.WriteLine("type:" + match.Groups[5].Value);
                Console.WriteLine(string.IsNullOrEmpty(match.Groups[5].Value) ? "http" : match.Groups[5].Value);
            }
            Console.WriteLine("======OK========");
            Console.ReadKey();
        }
    }
}
