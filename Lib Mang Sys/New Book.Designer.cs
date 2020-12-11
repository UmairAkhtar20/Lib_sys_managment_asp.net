namespace Lib_Mang_Sys
{
    partial class New_Book
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
            this.txt_AuthorName = new System.Windows.Forms.TextBox();
            this.txt_isbnnmbr = new System.Windows.Forms.TextBox();
            this.txt_publishdate = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_AuthorName
            // 
            this.txt_AuthorName.Location = new System.Drawing.Point(169, 76);
            this.txt_AuthorName.Name = "txt_AuthorName";
            this.txt_AuthorName.Size = new System.Drawing.Size(100, 20);
            this.txt_AuthorName.TabIndex = 19;
            // 
            // txt_isbnnmbr
            // 
            this.txt_isbnnmbr.Location = new System.Drawing.Point(169, 138);
            this.txt_isbnnmbr.Name = "txt_isbnnmbr";
            this.txt_isbnnmbr.Size = new System.Drawing.Size(100, 20);
            this.txt_isbnnmbr.TabIndex = 18;
            // 
            // txt_publishdate
            // 
            this.txt_publishdate.Location = new System.Drawing.Point(169, 209);
            this.txt_publishdate.Name = "txt_publishdate";
            this.txt_publishdate.Size = new System.Drawing.Size(100, 20);
            this.txt_publishdate.TabIndex = 17;
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(169, 276);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(100, 20);
            this.txt_category.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.Location = new System.Drawing.Point(35, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F);
            this.label4.Location = new System.Drawing.Point(26, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Publish Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F);
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "ISBN Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Author Name";
            // 
            // txt_bookName
            // 
            this.txt_bookName.Location = new System.Drawing.Point(169, 24);
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.Size = new System.Drawing.Size(100, 20);
            this.txt_bookName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // New_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_AuthorName);
            this.Controls.Add(this.txt_isbnnmbr);
            this.Controls.Add(this.txt_publishdate);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_Book";
            this.Text = "New_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AuthorName;
        private System.Windows.Forms.TextBox txt_isbnnmbr;
        private System.Windows.Forms.TextBox txt_publishdate;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}