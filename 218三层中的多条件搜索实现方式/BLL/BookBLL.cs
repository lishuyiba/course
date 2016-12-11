using _218三层中的多条件搜索实现方式.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _218三层中的多条件搜索实现方式.BLL
{
    public class BookBLL
    {
        public List<string> Search(List<Condition> list)
        {
            BookDAL dal = new BookDAL();
            return dal.Search(list);
        }
    }
}
