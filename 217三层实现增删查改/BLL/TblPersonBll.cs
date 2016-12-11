using _217三层实现增删查改.DAL;
using _217三层实现增删查改.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217三层实现增删查改.BLL
{
    public class TblPersonBll
    {
        TblPersonDal dal = new TblPersonDal();
        public int Insert(TblPerson model)
        {
            return (int) dal.Insert(model);
        }

        public int Delete(int autoId)
        {
            return dal.Delete(autoId);
        }

        public List<TblPerson> SelectAll()
        {
            return dal.SelectAll();
        }

        public int Update(TblPerson model)
        {
            return dal.Update(model);
        }

        public TblPerson GetModelById(int autoId)
        {
            return dal.GetModelById(autoId);
        }
    }
}
