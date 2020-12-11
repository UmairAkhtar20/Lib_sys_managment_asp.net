using LMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BOA
{
    public class AdminBO
    {
        public static int checkadmin(AdminDTO dTO)
        {
            return LMS.DAL.AdminDAO.checkadmin(dTO);
        }
    }
}
