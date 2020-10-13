using Dapper;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class AddressDAL
    {
        //显示
        public List<Address> GetList()
        {
            using (IDbConnection db=new SqlConnection("Data Source=.;Initial Catalog=WeChat;Integrated Security=True"))
            {
                string sql = "select * from Address";
                return db.Query<Address>(sql).ToList();
            }
        }
    }
}
