using _221话术搜索DAL;
using _221话术搜索Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221话术搜索BLL
{
    public class TScriptsBll
    {
        public List<TScript> GetDataByParentId(int pid)
        {
            return new TScriptDal().GetDataByParentId(pid);
        }
    }
}
