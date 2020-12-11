using Lib_Mang_Sys.Properties;
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
    public partial class Cancel_Member : Form
    {
        public Cancel_Member()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = LMS.DAL.NewMemberDAO.loaddataintupdatemembergrid();
              
                    dataGridView1.DataSource = dt;

              
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)

            {
                
                var id =(int)dataGridView1.CurrentRow.Cells[0].Value;

                var dal =LMS.DAL.NewMemberDAO.cancelmembership(id);
                if (dal == 1)
                {
                    MessageBox.Show("Memship is Cancelled");
                }
            }
        }
    }
}
