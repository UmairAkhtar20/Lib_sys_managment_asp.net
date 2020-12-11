using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Mang_Sys
{
    public partial class Issue_Book : Form
    {
        int id = 0;
        public Issue_Book()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = LMS.DAL.BooksDAO.loaddatainbooksgrid();
                    dataGridView1.DataSource = dt;

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                 id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                string username = Username.name;
                var v = LMS.DAL.BooksDAO.issuebooks(id, username);
                if (v == 1)
                {
                    MessageBox.Show("BOOK Has been Issued to your account " +
                      "collect it from counter");
                }
            }
        }
      
     
        
    }
}
