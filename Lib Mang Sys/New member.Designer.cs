namespace Lib_Mang_Sys
{
    partial class New_member
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_membername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_membercnic = new System.Windows.Forms.TextBox();
            this.txt_memberemail = new System.Windows.Forms.TextBox();
            this.text_memberphone = new System.Windows.Forms.TextBox();
            this.txt_memberfather = new System.Windows.Forms.TextBox();
            this.pic_member = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.picdialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic_member)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_membername
            // 
            this.txt_membername.Location = new System.Drawing.Point(144, 22);
            this.txt_membername.Name = "txt_membername";
            this.txt_membername.Size = new System.Drawing.Size(100, 20);
            this.txt_membername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Father Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(15, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cnic";
            // 
            // txt_membercnic
            // 
            this.txt_membercnic.Location = new System.Drawing.Point(144, 233);
            this.txt_membercnic.Name = "txt_membercnic";
            this.txt_membercnic.Size = new System.Drawing.Size(100, 20);
            this.txt_membercnic.TabIndex = 6;
            // 
            // txt_memberemail
            // 
            this.txt_memberemail.Location = new System.Drawing.Point(144, 179);
            this.txt_memberemail.Name = "txt_memberemail";
            this.txt_memberemail.Size = new System.Drawing.Size(100, 20);
            this.txt_memberemail.TabIndex = 7;
            // 
            // text_memberphone
            // 
            this.text_memberphone.Location = new System.Drawing.Point(144, 127);
            this.text_memberphone.Name = "text_memberphone";
            this.text_memberphone.Size = new System.Drawing.Size(100, 20);
            this.text_memberphone.TabIndex = 8;
            // 
            // txt_memberfather
            // 
            this.txt_memberfather.Location = new System.Drawing.Point(144, 73);
            this.txt_memberfather.Name = "txt_memberfather";
            this.txt_memberfather.Size = new System.Drawing.Size(100, 20);
            this.txt_memberfather.TabIndex = 9;
            // 
            // pic_member
            // 
            this.pic_member.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_member.Location = new System.Drawing.Point(470, 0);
            this.pic_member.Name = "pic_member";
            this.pic_member.Size = new System.Drawing.Size(162, 93);
            this.pic_member.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_member.TabIndex = 10;
            this.pic_member.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.Location = new System.Drawing.Point(374, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Picture";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // New_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 402);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pic_member);
            this.Controls.Add(this.txt_memberfather);
            this.Controls.Add(this.text_memberphone);
            this.Controls.Add(this.txt_memberemail);
            this.Controls.Add(this.txt_membercnic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_membername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_member";
            this.Load += new System.EventHandler(this.New_member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_member)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_membername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_membercnic;
        private System.Windows.Forms.TextBox txt_memberemail;
        private System.Windows.Forms.TextBox text_memberphone;
        private System.Windows.Forms.TextBox txt_memberfather;
        private System.Windows.Forms.PictureBox pic_member;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog picdialog;
    }
}