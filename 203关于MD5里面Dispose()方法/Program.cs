using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _203关于MD5里面Dispose__方法
{
    class Program
    {
        static void Main(string[] args)
        {
            MD5 md5 = MD5.Create();
            //在.net2.0以前，Dispose是点不出来的，因为Md5继承了HashAlgorithm，而HashAlgorithm又继承了IDisposable
            //HashAlgorithm对Dispose是显示实现接口，所以点不出来
            //不过在.net4.0以上，微软使用了实现接口，所以可以点出来了。
            md5.Dispose();
        }
    }
}
