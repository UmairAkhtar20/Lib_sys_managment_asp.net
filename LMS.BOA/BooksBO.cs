using LMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BOA
{
    public class BooksBO
    {
        public static int addnewbooks(BooksDTO dTO)
        {
            return LMS.DAL.BooksDAO.addnewbooks(dTO);
        }
    }
}
