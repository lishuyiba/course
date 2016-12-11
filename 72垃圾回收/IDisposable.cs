using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72垃圾回收
{
    class IDisposable
    {
        #region IDisposable 成员

        public void Dispose()
        { 
            //这里的代码，来释放除内存资源外的其他资源。
        }

        //在c++中，叫析构函数
        //在c#中叫Finalize()函数。中文：终结函数
        //在当前对象被垃圾回收之前会调用Finalize()函数，释放其他资源。
        ~IDisposable()
        { 
            //不能手动调用，所以一般回收其他内存，都写在Dispose()方法中。
            //既然Dispose()方法已经释放其他内存，这时就不需要再调用Finalize()方法了。
            //所以就通过GC.SupperessFinalize(this);，告诉程序不要调用Finalize()了。
        }


        #endregion
    }
}
