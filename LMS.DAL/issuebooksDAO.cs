using LMS.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DAL
{
    public static class issuebooksDAO
    {
        public static int enterdatainissuebooks(BooksDTO dTO,string user)
        {
            string query = string.Format(@"INSERT INTO dbo.issuebook(MemberName,BookName,AuthorName,Category,issueDAte,BookReturn,ReturnDAte) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')"
                               , user, dTO.BookName,dTO.BookAuthor, dTO.BooKCategory, DateTime.Now.ToString(), 0, "No Return");
            using(DBHelper helper=new DBHelper())
            {
                var count = helper.ExecuteQuery(query);
                return count;
            }
        }
        public static DataTable loaddatainbooksgrid(string user)
        {
           
            string query = string.Format(@"Select ID,BookName,AuthorName,Category,IssueDAte from dbo.issuebook where BookReturn='{0}' and MemberName='{1}' ", 0, user);
            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }
        public static int returnbook(int id)
        {
            string query =string.Format(@"UPDATE dbo.issuebook SET BookReturn='{0}',ReturnDAte='{1}' Where ID='{2}'", 1, DateTime.Now.ToString(), id);
            using (DBHelper helper = new DBHelper())
            {
                var count = helper.ExecuteQuery(query);
                return count;
            }
        }
        public static DataTable loaddatainveiwaccgrid(string user)
        {

            string query = string.Format(@"Select * from dbo.issuebook where MemberName='{0}' ", user);
            using (DBHelper helper = new DBHelper())
            {
                var reader = helper.ExecuteReader(query);
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
        }
    }
    
}
