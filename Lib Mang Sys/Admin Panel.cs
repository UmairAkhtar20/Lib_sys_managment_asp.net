using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Mang_Sys
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }
        private Form activateform = null;
        private void openchilfrom(Form chilfrom)
        {
            if (activateform != null)
            {
                activateform.Close();
            }
            activateform = chilfrom;
            chilfrom.TopLevel = false;
            chilfrom.FormBorderStyle = FormBorderStyle.None;
            chilfrom.Dock = DockStyle.Fill;
            panelchild.Controls.Add(chilfrom);
            panelchild.Tag = chilfrom;
            chilfrom.BringToFront();
            chilfrom.Show();
        }

        private void btn_addnewmem_Click(object sender, EventArgs e)
        {
            openchilfrom(new New_member());
        }

        private void btn_addnewbook_Click(object sender, EventArgs e)
        {
            openchilfrom(new New_Book());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchilfrom(new Cancel_Member());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openchilfrom(new Update_Member());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
