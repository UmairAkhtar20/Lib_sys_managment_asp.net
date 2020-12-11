using LMS.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BOA
{
   public class NewMemebrBO
    {
        public static int Addnewmember(NewMemberDTO dTO)
        {
            return LMS.DAL.NewMemberDAO.Addnewmember(dTO);
        }
        public static DataTable loaddataindatagrid()
        {
            return LMS.DAL.NewMemberDAO.loaddataindatagrid();
        }
    }
}
