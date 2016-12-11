using _215通过三层实现年龄自动增长.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215通过三层实现年龄自动增长.BLL
{
    public class MyStudentBll
    {
        /// <summary>
        /// 这里的方法也可以直接返回一个int（所影响的行数）
        /// 业务逻辑层的方法到底返回什么值，直接取决于表现层要什么结果，UI层要什么，Bll就返回什么（可以根据数据访问层返回的结果来做出相应的返回值）
        /// </summary>
        /// <param name="fid"></param>
        /// <returns></returns>
        public bool IncAgeById(int fid)
        {
            MyStudentDal dal = new MyStudentDal();
            int r = dal.IncAgeById(fid);
            if (r>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
