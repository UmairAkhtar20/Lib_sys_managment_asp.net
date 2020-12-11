using Lib_Mang_Sys.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LMS.Entities;
using LMS.BOA;

namespace Lib_Mang_Sys
{
    /// <summary>
    /// Interaction logic for Admin_Login.xaml
    /// </summary>
    public partial class Admin_Login : Window
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void admin_login_Click(object sender, RoutedEventArgs e)
        {
            var dto = new LMS.Entities.AdminDTO();
            dto.Name = admin_user.Text;
            dto.Password = admin_pass.Password;
            var v = LMS.BOA.AdminBO.checkadmin(dto);
            if (v == 1)
            {
                Admin_Login a = new Admin_Login();
                a.Hide();
                Admin_Panel b = new Admin_Panel();
                b.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials");
            }
           

        }

        
    }
}
