using _197通过MD5加密登陆;
using _216通过三层实现用户登录.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _216通过三层实现用户登录.DAL
{
    public class TScriptsDal
    {
        //ScriptId, ScriptTitle, ScriptMsg, ScriptParenId


        /// <summary>
        /// 根据父Id获取所有子类别
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        public List<TScript> GetScriptsByParentId(int pid)
        {
            List<TScript> list = new List<TScript>();
            string sql = "select ScriptId,ScriptTitle from T_Scripts where ScriptParenId=@pid";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, new SqlParameter("pid", pid)))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TScript model = new TScript();
                        model.ScriptId = reader.GetInt32(0);
                        model.ScriptTile = reader.GetString(1);
                        list.Add(model);
                    }
                }
            }
            return list;
        }


        /// <summary>
        /// 根据节点Id，删除某个节点
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteByScriptId(int id)
        {
            string sql = "delete from T_Scripts where ScriptId=@id";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@id", id));
        }


        public object GetMsgByScriptId(int sid)
        {
            string sql = "select ScriptMsg from T_Scripts where ScriptId=@id";
            return SqlHelper.ExecuteScalar(sql, CommandType.Text, new SqlParameter("@id", sid));
        }

    }
}
