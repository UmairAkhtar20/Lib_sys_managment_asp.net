using LMS.Entities;
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
    public partial class UpDAte_Member_Acc : Form
    {
        int userid = 0;
        public UpDAte_Member_Acc()
        {
            InitializeComponent();
        }

        private void UpDAte_Member_Acc_Load(object sender, EventArgs e)
        {
            
                    string user = Username.name;
            var dto = LMS.DAL.NewMemberDAO.loaddatainupdatememberform(user);
            txt_membername.Text = dto.MemberName;
            txt_memberfather.Text = dto.FatherName;
            text_memberphone.Text = dto.Phone;
            txt_membercnic.Text = dto.Cnic;
            txt_memberemail.Text = dto.Email;


            String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            String filePath = applicationBasePath + @"\images\" + dto.Picture;
            pic_member.Image = Image.FromFile(filePath);

            userid = dto.Memberid;






        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewMemberDTO dTO = new NewMemberDTO();

            dTO.MemberName = txt_membername.Text.Trim();
            dTO.FatherName = txt_memberfather.Text.Trim();
            dTO.Phone = text_memberphone.Text.Trim();
            dTO.Email = txt_memberemail.Text;
            dTO.Password = dTO + "123";
            dTO.Cnic = txt_membercnic.Text;
            dTO.Picture = "";
            if (pic_member.Image != null)
            {
                String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                String pathToSaveImage = applicationBasePath + @"\images\";

                dTO.Picture = Guid.NewGuid().ToString() + ".jpg";
                String imgPath = pathToSaveImage + dTO.Picture;

                pic_member.Image.Save(imgPath);
            }
            var v = LMS.DAL.NewMemberDAO.updatedataintable(dTO, userid);
            if (v == 1)
            {
                MessageBox.Show("Data is saved");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = picdialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var filePath = picdialog.FileName;
                pic_member.Image = Image.FromFile(filePath);
            }
        }
    }
}
