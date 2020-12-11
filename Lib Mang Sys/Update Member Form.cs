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
    public partial class Update_Member_Form : Form
    {
        int userid = 0;
        public Update_Member_Form()
        {
            InitializeComponent();
        }

    
        public void Loaddata(int id)
        {
            var dto = LMS.DAL.NewMemberDAO.loaddatainupdateform(id);
            
            txt_membername.Text = dto.MemberName;
            txt_memberfather.Text =dto.FatherName;
            text_memberphone.Text =dto.Phone;
            txt_membercnic.Text = dto.Cnic;
            txt_memberemail.Text =dto.Email;


                        String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                        String filePath = applicationBasePath + @"\images\" + dto.Picture;
                        pic_member.Image = Image.FromFile(filePath);

            userid = dto.Memberid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewMemberDTO dTO = new NewMemberDTO();

            dTO.MemberName= txt_membername.Text.Trim();
            dTO.FatherName = txt_memberfather.Text.Trim();
            dTO.Phone = text_memberphone.Text.Trim();
            dTO.Email = txt_memberemail.Text;
            dTO.Password = dTO + "123";
            dTO.Cnic= txt_membercnic.Text;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pic_member_Click(object sender, EventArgs e)
        {

        }

        private void txt_memberfather_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_memberphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_memberemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_membercnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_membername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
