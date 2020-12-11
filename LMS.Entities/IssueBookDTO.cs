using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    public class IssueBookDTO
    {
        public int Bookid { get; set; }
        public int Bookreturn { get; set; }
        public string MemberName { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string issuedate { get; set; }
        public string BooKCategory { get; set; }
        public string BookDateofreturn { get; set; }

    }
}
