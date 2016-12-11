using _197通过MD5加密登陆;
using _221话术搜索Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221话术搜索DAL
{
    public class TScriptDal
    {
        public List<TScript> GetDataByParentId(int pid)
        {
            List<TScript> list = new List<TScript>();
            string sql = "select ScriptId,ScriptTitle from T_Scripts where ScriptParenId=@id";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, new SqlParameter("@id", pid)))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TScript model = new TScript();
                        model.ScriptId = reader.GetInt32(0);
                        model.ScriptTitle = reader.GetString(1);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
    }
}
