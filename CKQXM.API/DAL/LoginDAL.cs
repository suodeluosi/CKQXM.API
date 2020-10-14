using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CKQXM.API.Model;
using SqlSugar;
namespace CKQXM.API.DAL
{
    public class LoginDAL : LDAL
    {
        SqlSugarClient db = new SqlSugarClient(
            new ConnectionConfig
            {
                ConnectionString = @"Data Source=10.3.186.30;Initial Catalog=G6_Project;User ID=sa;Pwd=123456",
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
            }
            );
        public int Login(string name, string pwd)
        {
            List<LoginModel> list = db.Queryable<LoginModel>().Where(s => s.Account == name && s.AccountPassword == pwd).ToList();
            if (list.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
