using LMS.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
    public static class BooksDAO
    {
        public static int addnewbooks(BooksDTO dTO)
        {
            string query = string.Format(@"INSERT INTO dbo.Books(Name,AuthorName,ISBN,PublishDAte,Category,DOE) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')"
                                , dTO.BookName,dTO.BookAuthor,dTO.BookISBN,dTO.BookPublishdate, dTO.BooKCategory, DateTime.Now.ToString());
            using (DBHelper helper = new DBHelper())
            {
                var count = helper.ExecuteQuery(query);
                return count;
            }
        }
        public static DataTable loaddatainbooksgrid()
        {
            string query = "Select ID,Name,AuthorName,PublishDAte,Category from dbo.Books";
            using(DBHelper helper=new DBHelper())
            {
                var reader = helper.ExecuteReader(query);
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }
        public static int issuebooks(int id ,string user)
        {
            string query = string.Format(@"Select ID,Name,AuthorName,PublishDAte,Category from dbo.Books where ID={0}", id);
            using(DBHelper helper=new DBHelper())
            {
                var reader = helper.ExecuteReader(query);
                BooksDTO dTO = new BooksDTO();
                while (reader.Read())
                {
                   dTO.BookName= reader.GetString(reader.GetOrdinal("Name"));
                   dTO.BookAuthor= reader.GetString(reader.GetOrdinal("AuthorName"));
                   dTO.BooKCategory  = reader.GetString(reader.GetOrdinal("Category"));
                   string MemberName = user;
                    var v = LMS.DAL.issuebooksDAO.enterdatainissuebooks(dTO, MemberName);
                    return v;
                }
            }
            return 0;
        }
        
    }
}
