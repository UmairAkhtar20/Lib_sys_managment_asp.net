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
using Lib_Mang_Sys.Properties;

namespace Lib_Mang_Sys
{
    public partial class Update_Member : Form
    {
        public Update_Member()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }
   

        private void button1_Click(object sender, EventArgs e)
        {
           var dAL =LMS.BOA.NewMemebrBO.loaddataindatagrid();
           
            dataGridView1.DataSource =dAL ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)

            {

                var id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Update_Member_Form update = new Update_Member_Form();
                update.Loaddata(id);
                update.Show();
            }
        }
    }
}
