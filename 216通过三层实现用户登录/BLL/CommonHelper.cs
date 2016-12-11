using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _216通过三层实现用户登录.BLL
{
    public static class CommonHelper
    {
        public static string Md5Encrypt(string msg)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(msg);
            byte[] md5Buffer = md5.ComputeHash(buffer);
            md5.Clear();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < md5Buffer.Length; i++)
            {
                sb.Append(md5Buffer[i].ToString("x2"));
            }
            return sb.ToString().ToUpper();
        }
    }
}
