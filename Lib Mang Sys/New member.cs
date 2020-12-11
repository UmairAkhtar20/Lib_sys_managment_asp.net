using Lib_Mang_Sys.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Mang_Sys
{
    public partial class New_member : Form
    {
        public New_member()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            var dto = new LMS.Entities.NewMemberDTO();
            dto.MemberName= txt_membername.Text.Trim();
            dto.FatherName= txt_memberfather.Text.Trim();
            dto.Phone = text_memberphone.Text.Trim();
            dto.Email   = txt_memberemail.Text;
            dto.Password  = dto.MemberName + "123";
            dto.Cnic  = txt_membercnic.Text;
            dto.Picture  = "";
            if (pic_member.Image != null)
            {
                String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                String pathToSaveImage = applicationBasePath + @"\images\";

                dto.Picture = Guid.NewGuid().ToString() + ".jpg";
                String imgPath = pathToSaveImage + dto.Picture;

                pic_member.Image.Save(imgPath);
            }
            var v = LMS.BOA.NewMemebrBO.Addnewmember(dto);
            if (v == 1)
            {
                MessageBox.Show("Data Is saved");
            }
           


        }

        private void New_member_Load(object sender, EventArgs e)
        {
            String applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            System.IO.Directory.CreateDirectory(applicationBasePath + @"\images\");
        }
    }

      
    
}
