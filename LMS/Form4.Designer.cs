namespace Library_User_Management_System
{
    partial class Form4
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
            this.Profile = new System.Windows.Forms.Button();
            this.BooksRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.Location = new System.Drawing.Point(303, 163);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(181, 48);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // BooksRecord
            // 
            this.BooksRecord.Location = new System.Drawing.Point(303, 255);
            this.BooksRecord.Name = "BooksRecord";
            this.BooksRecord.Size = new System.Drawing.Size(181, 49);
            this.BooksRecord.TabIndex = 1;
            this.BooksRecord.Text = "Books Record";
            this.BooksRecord.UseVisualStyleBackColor = true;
            this.BooksRecord.Click += new System.EventHandler(this.BooksRecord_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 700);
            this.Controls.Add(this.BooksRecord);
            this.Controls.Add(this.Profile);
            this.Name = "Form4";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Button BooksRecord;
    }
}