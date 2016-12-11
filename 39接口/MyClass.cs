using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39接口
{
    class MyClass
    {
    }
    #region 接口一
    ////不要在一个接口中写过多的方法，避免造成接口污染。
    ////可编写多个接口，每个接口中，分别定义方法。
    //public interface Ijiekou
    //{
    //    void M1();
    //    void M2();
    //    void M3();
    //}
    //class Person : Ijiekou
    //{

    //    public void M1()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void M2()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void M3()
    //    {
    //        throw new NotImplementedException();
    //    }
    //} 
    #endregion


    #region 接口二  （建议）

    //public interface I1
    //{
    //    void M1();
    //}

    //public interface I2
    //{
    //    void M2();
    //}

    //public interface I3
    //{
    //    void M3();
    //}

    //class Person : I1, I3
    //{ 
        
    //}

    #endregion
}
