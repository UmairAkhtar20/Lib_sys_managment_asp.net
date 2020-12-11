using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Entities
{
    public class NewMemberDTO
    {
        public int Memberid { get; set; }
        public int isMember { get; set; }
        public string MemberName { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cnic { get; set; }
        public string Password { get; set; }
        public string Picture { get; set; }
        public string Dateofregistration { get; set; }
    }
}
