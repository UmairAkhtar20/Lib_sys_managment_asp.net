using Lib_Mang_Sys.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Lib_Mang_Sys
{
    /// <summary>
    /// Interaction logic for Member_Login.xaml
    /// </summary>
    public partial class Member_Login : Window
    {
        public Member_Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dto = new LMS.Entities.NewMemberDTO();
           dto.MemberName = txt_memberusername.Text;
            dto.Password = userpassword.Password;
           
           Username.name = dto.MemberName;
            var v = LMS.DAL.NewMemberDAO.checkmember(dto);
            if (v == 1)
            {
                Admin_Login a = new Admin_Login();
                a.Hide();
                Member_Panel b = new Member_Panel();
                b.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
           
        }

        private void txt_memberusername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
    }
}
