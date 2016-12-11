using _216通过三层实现用户登录.DAL;
using _216通过三层实现用户登录.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216通过三层实现用户登录.BLL
{
    public class TScriptsBll
    {
        private TScriptsDal dal = new TScriptsDal();

        /// <summary>
        /// 获取pid下所有子类别
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<TScript> GetScriptsByParentId(int pid)
        {
            return dal.GetScriptsByParentId(pid);
        }


        /// <summary>
        /// 递归删除当前的类别
        /// </summary>
        /// <param name="sid"></param>
        public void DeleteById(int sid)
        {
            //递归删除，可以写到业务逻辑层，因为递归删除没有涉及到页面上的控件
            //1.要删除获取sid下的所有子类别
            List<TScript> list = GetScriptsByParentId(sid);
            foreach (TScript item in list)
            {
                DeleteById(item.ScriptId);
            }

            dal.DeleteByScriptId(sid);            
        }


        /// <summary>
        /// 查询选中节点的内容
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public string GetScriptMsgScriptId(int sid)
        {
            //return dal.GetMsgByScriptId(sid).ToString();
            object objMsg = dal.GetMsgByScriptId(sid);
            if (objMsg!=null)
            {
                return objMsg.ToString();
            }
            else
            {
                return null;
            }
        }

    }
}
