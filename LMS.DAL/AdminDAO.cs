using LMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
    public static class AdminDAO
    {
        public static int checkadmin(AdminDTO dTO)
        {
            string squery = @"select * from dbo.Admin";
            using(DBHelper helper=new DBHelper())
            {
                var reader = helper.ExecuteReader(squery);
                while (reader.Read())
                {
                    string Name= reader.GetString(reader.GetOrdinal("Name"));
                    string Password= reader.GetString(reader.GetOrdinal("Password"));
                    if (dTO.Name == Name  && dTO.Password ==Password)
                    {
                        return 1;
                    }

                }
            }

            return 0;
        }
    }
}
