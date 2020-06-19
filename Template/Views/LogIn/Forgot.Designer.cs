namespace Template.Views
{
    partial class Forgot
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
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.GBox_Email = new System.Windows.Forms.GroupBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.GBox_NewPassword = new System.Windows.Forms.GroupBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Txt_NewPassword = new System.Windows.Forms.TextBox();
            this.Btn_SetNewPassword = new System.Windows.Forms.Button();
            this.GBox_Email.SuspendLayout();
            this.GBox_NewPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(6, 31);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(83, 13);
            this.Lbl_Email.TabIndex = 0;
            this.Lbl_Email.Text = "Write your Email";
            // 
            // GBox_Email
            // 
            this.GBox_Email.Controls.Add(this.Btn_Search);
            this.GBox_Email.Controls.Add(this.Txt_Email);
            this.GBox_Email.Controls.Add(this.Lbl_Email);
            this.GBox_Email.Location = new System.Drawing.Point(12, 12);
            this.GBox_Email.Name = "GBox_Email";
            this.GBox_Email.Size = new System.Drawing.Size(224, 104);
            this.GBox_Email.TabIndex = 1;
            this.GBox_Email.TabStop = false;
            this.GBox_Email.Text = "Forgot Account";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(9, 73);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(204, 23);
            this.Btn_Search.TabIndex = 3;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(9, 47);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(204, 20);
            this.Txt_Email.TabIndex = 2;
            // 
            // GBox_NewPassword
            // 
            this.GBox_NewPassword.Controls.Add(this.Btn_SetNewPassword);
            this.GBox_NewPassword.Controls.Add(this.Txt_NewPassword);
            this.GBox_NewPassword.Controls.Add(this.Lbl_Password);
            this.GBox_NewPassword.Location = new System.Drawing.Point(12, 122);
            this.GBox_NewPassword.Name = "GBox_NewPassword";
            this.GBox_NewPassword.Size = new System.Drawing.Size(222, 104);
            this.GBox_NewPassword.TabIndex = 2;
            this.GBox_NewPassword.TabStop = false;
            this.GBox_NewPassword.Text = "New Password";
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(6, 26);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(78, 13);
            this.Lbl_Password.TabIndex = 0;
            this.Lbl_Password.Text = "New Password";
            // 
            // Txt_NewPassword
            // 
            this.Txt_NewPassword.Location = new System.Drawing.Point(9, 42);
            this.Txt_NewPassword.Name = "Txt_NewPassword";
            this.Txt_NewPassword.Size = new System.Drawing.Size(204, 20);
            this.Txt_NewPassword.TabIndex = 1;
            this.Txt_NewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_NewPassword_KeyDown);
            // 
            // Btn_SetNewPassword
            // 
            this.Btn_SetNewPassword.Location = new System.Drawing.Point(9, 68);
            this.Btn_SetNewPassword.Name = "Btn_SetNewPassword";
            this.Btn_SetNewPassword.Size = new System.Drawing.Size(204, 23);
            this.Btn_SetNewPassword.TabIndex = 2;
            this.Btn_SetNewPassword.Text = "Set New Password";
            this.Btn_SetNewPassword.UseVisualStyleBackColor = true;
            this.Btn_SetNewPassword.Click += new System.EventHandler(this.Btn_SetNewPassword_Click);
            // 
            // Forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 233);
            this.Controls.Add(this.GBox_NewPassword);
            this.Controls.Add(this.GBox_Email);
            this.Name = "Forgot";
            this.Text = "Forgot";
            this.GBox_Email.ResumeLayout(false);
            this.GBox_Email.PerformLayout();
            this.GBox_NewPassword.ResumeLayout(false);
            this.GBox_NewPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.GroupBox GBox_Email;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.GroupBox GBox_NewPassword;
        private System.Windows.Forms.Button Btn_SetNewPassword;
        private System.Windows.Forms.TextBox Txt_NewPassword;
        private System.Windows.Forms.Label Lbl_Password;
    }
}