using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Lib_Mang_Sys
{
    public partial class Member_Panel : Form
    {
        public Member_Panel()
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
            MainPanel.Controls.Add(chilfrom);
            MainPanel.Tag = chilfrom;
            chilfrom.BringToFront();
            chilfrom.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openchilfrom(new Issue_Book());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchilfrom(new Book_Return());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchilfrom(new View_Acc());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openchilfrom(new UpDAte_Member_Acc());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
            Member_Login member = new Member_Login();
            member.Hide();
            MainWindow main = new MainWindow();
            main.Show();
           

        }
    }
}
