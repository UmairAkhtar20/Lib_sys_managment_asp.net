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
    public partial class View_Acc : Form
    {
        public View_Acc()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                    string user = Username.name;
            var dt = LMS.DAL.issuebooksDAO.loaddatainveiwaccgrid(user);
                    dataGridView1.DataSource = dt;

              
            
        }
    }
}
