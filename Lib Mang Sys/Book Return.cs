using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Mang_Sys
{
    public partial class Book_Return : Form
    {
        public Book_Return()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                
                    string user = Username.name;
            var dt = LMS.DAL.issuebooksDAO.loaddatainbooksgrid(user);
                   
                    dataGridView1.DataSource = dt;

             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                var v = LMS.DAL.issuebooksDAO.returnbook(id);
                if (v == 1)
                {
                    MessageBox.Show("Record Has been Updated" +
                      "Return Book to Counter");
                }
            }
        }
 
    }
}
