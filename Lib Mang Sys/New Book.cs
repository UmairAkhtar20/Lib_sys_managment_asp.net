using Lib_Mang_Sys.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Mang_Sys
{
    public partial class New_Book : Form
    {
        public New_Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dto = new LMS.Entities.BooksDTO();
            dto.BookName = txt_bookName.Text;
            dto.BookAuthor= txt_AuthorName.Text;
            dto.BookISBN = txt_isbnnmbr.Text;
            dto.BookPublishdate = txt_publishdate.Text;
            dto.BooKCategory = txt_category.Text;
            var v = LMS.BOA.BooksBO.addnewbooks(dto);
            if (v == 1)
            {
                MessageBox.Show("Data Is saveed");
            }
           
            
        }
    }
}
