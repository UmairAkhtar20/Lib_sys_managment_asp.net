using LMS.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
   public static class NewMemberDAO
    {
        public static int Addnewmember(NewMemberDTO dTO)
        {
            string query = string.Format(@"INSERT INTO dbo.NewMember(Name,FatherName,Email,Phone,Cnic,Password,Picture,DOR,IsMember) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')"
                                ,dTO.MemberName,dTO.FatherName, dTO.Email, dTO.Phone, dTO.Cnic,dTO.Password , dTO.Picture, DateTime.Now.ToString(), 1);
            using(DBHelper helper=new DBHelper())
            {
                var count = helper.ExecuteQuery(query);
                return count;
            }
        }
        public static DataTable loaddataindatagrid()
        {
            string query = @"Select ID,Name,FatherName,DOR from dbo.NewMember where IsMember='1';";
            using(DBHelper helper=new DBHelper())
            {
                var reader = helper.ExecuteReader(query);
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }
        public static NewMemberDTO loaddatainupdateform(int id)
        {
            string query = string.Format(@"Select * from dbo.NewMember where ID='{0}'", id);
            using (DBHelper helper = new DBHelper())
            {
                
                var reader = helper.ExecuteReader(query);
                NewMemberDTO dTO = new NewMemberDTO();
                while (reader.Read())
                {
                    dTO.Memberid = reader.GetInt32(reader.GetOrdinal("ID"));
                   dTO.MemberName = reader.GetString(reader.GetOrdinal("Name"));
                   dTO.FatherName  = reader.GetString(reader.GetOrdinal("FatherName"));
                   dTO.Phone  = reader.GetString(reader.GetOrdinal("Phone"));
                   dTO.Cnic  = reader.GetString(reader.GetOrdinal("Cnic"));
                   dTO.Email  = reader.GetString(reader.GetOrdinal("Email"));
                   dTO.Picture  = reader.GetString(reader.GetOrdinal("Picture"));
                }
                return dTO;
            }
        }
        public static int updatedataintable(NewMemberDTO dTO,int userid)
        {
            string query = string.Format(@"UPDATE dbo.NewMember SET Name='{0}',FatherName='{1}',Email='{2}',Phone='{3}',Cnic='{4}',Password='{5}',Picture='{6}',DOR='{7}',IsMember='{8}' Where ID='{9}'"
                                 , dTO.MemberName, dTO.FatherName, dTO.Email, dTO.Phone, dTO.Cnic, dTO.Password, dTO.Picture, DateTime.Now.ToString(), 1, userid);
            using (DBHelper helper = new DBHelper())
            {
                var count = helper.ExecuteQuery(query);
                return count;
            }
        }
        public static DataTable loaddataintupdatemembergrid()
        {
            string query = @"Select ID,Name,FatherName,DOR from dbo.NewMember where IsMember='1';";
            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }
        public static int cancelmembership(int id)
        {
            string query = string.Format(@"UPDATE dbo.NewMember SET IsMember='{0}' WHERE ID='{1}'", 0, id);
            using(DBHelper helper=new DBHelper())
            {
                var count = helper.ExecuteQuery(query);
                return count;
            }
        }
        public static int checkmember(NewMemberDTO dTO)
        {
            string query = string.Format("Select * from dbo.NewMember where Name='{0}' ", dTO.MemberName);
            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);
                while (reader.Read())
                {
                    string Name = reader.GetString(reader.GetOrdinal("Name"));
                    string Password = reader.GetString(reader.GetOrdinal("Password"));
                    if (dTO.MemberName == Name && dTO.Password == Password)
                    {
                        return 1;
                    }

                }
                return 0;
            }
        }
        public static NewMemberDTO loaddatainupdatememberform(string user)
        {
            string query = string.Format(@"Select * from dbo.NewMember where Name='{0}'", user);
            using (DBHelper helper = new DBHelper())
            {

                var reader = helper.ExecuteReader(query);
                NewMemberDTO dTO = new NewMemberDTO();
                while (reader.Read())
                {
                    dTO.Memberid = reader.GetInt32(reader.GetOrdinal("ID"));
                    dTO.MemberName = reader.GetString(reader.GetOrdinal("Name"));
                    dTO.FatherName = reader.GetString(reader.GetOrdinal("FatherName"));
                    dTO.Phone = reader.GetString(reader.GetOrdinal("Phone"));
                    dTO.Cnic = reader.GetString(reader.GetOrdinal("Cnic"));
                    dTO.Email = reader.GetString(reader.GetOrdinal("Email"));
                    dTO.Picture = reader.GetString(reader.GetOrdinal("Picture"));
                }
                return dTO;
            }
        }
        public static DataSet loaddatainmvc()
        {
            string query = @"Select ID,Name,FatherName,DOR from dbo.NewMember where IsMember='1';";
            using (DBHelper helper = new DBHelper())
            {
                
                var reader = helper.DataAdapter(query);
                DataSet ds = new DataSet();
                reader.Fill(ds);
                return ds;
                
               
            }
        }
    }
}
