using _197通过MD5加密登陆;
using _217三层实现增删查改.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217三层实现增删查改.DAL
{
    public class TblPersonDal
    {
        /// <summary>
        /// 插入一条记录并返回刚插入的自动编号
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public object Insert(TblPerson model)
        {
            string sql = "insert into TblPerson output inserted.autoId values(@name,@age,@height,@gender)";
            SqlParameter[] pms = new SqlParameter[] { 
                new SqlParameter("@name",model.Uname),
                new SqlParameter("@age",model.Age),
                new SqlParameter("@height",model.Height==null?DBNull.Value:(object)model.Height),
                new SqlParameter("@gender",model.Gender==null?DBNull.Value:(object)model.Gender),
            };
            return SqlHelper.ExecuteScalar(sql, CommandType.Text, pms);
        }


        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="autoId"></param>
        /// <returns></returns>
        public int Delete(int autoId)
        {
            string sql = "delete from TblPerson where autoId=@id";
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, new SqlParameter("@id", autoId));
        }


        /// <summary>
        /// 查询所有的数据，返回一个集合
        /// </summary>
        /// <returns></returns>
        public List<TblPerson> SelectAll()
        {
            List<TblPerson> list = new List<TblPerson>();
            string sql = "select * from TblPerson";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TblPerson model = new TblPerson();
                        model.Age = reader.GetInt32(2);
                        model.AutoId = reader.GetInt32(0);
                        model.Gender = reader.IsDBNull(4) ? null : (bool?)reader.GetBoolean(4);
                        model.Height = reader.IsDBNull(3) ? null : (int?)reader.GetInt32(3);
                        model.Uname = reader.GetString(1);
                        list.Add(model);
                    }
                }
            }
            return list;
        }


        /// <summary>
        /// 更新行，返回所影响的行数
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Update(TblPerson model)
        {
            string sql = "update TblPerson set uname=@name,age=@age,height=@height,gender=@gender where autoId=@id";
            SqlParameter[] pms = new SqlParameter[] { 
                new SqlParameter("@name",model.Uname),
                new SqlParameter("@age",model.Age),
                new SqlParameter("@height",model.Height==null?DBNull.Value:(object)model.Height),
                new SqlParameter("@gender",model.Gender==null?DBNull.Value:(object)model.Gender),
                new SqlParameter("@id",model.AutoId),
            };
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, pms);
        }


        /// <summary>
        /// 更新行的内容，为了在Upadate数据的时候，不至于用户只更新一列的时候，其他列为空
        /// </summary>
        /// <param name="autoId"></param>
        /// <returns></returns>
        public TblPerson GetModelById(int autoId)
        {
            
            string sql = "select * from TblPerson where autoId=@id";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, new SqlParameter("@id", autoId)))
            {
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        TblPerson model = new TblPerson();
                        model.Age = reader.GetInt32(2);
                        model.AutoId = reader.GetInt32(0);
                        model.Gender = reader.IsDBNull(4) ? null : (bool?)reader.GetBoolean(4);
                        model.Height = reader.IsDBNull(3) ? null : (int?)reader.GetInt32(3);
                        model.Uname = reader.GetString(1);
                        return model;
                    }
                }
                return null;
            }
        }


    }
}
