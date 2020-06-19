namespace Template.Views
{
    partial class Home
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
            this.Lbl_User_LogIn = new System.Windows.Forms.Label();
            this.GBox_Users = new System.Windows.Forms.GroupBox();
            this.GBox_DelUser = new System.Windows.Forms.GroupBox();
            this.Txt_DelEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_DelPassword = new System.Windows.Forms.TextBox();
            this.Btn_DelUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_DelUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GBox_UpdUser = new System.Windows.Forms.GroupBox();
            this.Txt_UpdEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_UpdPassword = new System.Windows.Forms.TextBox();
            this.Btn_UpdUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_UpdUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GBox_AddUser = new System.Windows.Forms.GroupBox();
            this.Txt_AddEmail = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_AddPassword = new System.Windows.Forms.TextBox();
            this.Btn_AddUser = new System.Windows.Forms.Button();
            this.LbL_Password = new System.Windows.Forms.Label();
            this.Txt_AddUserName = new System.Windows.Forms.TextBox();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.Dgv_Users = new System.Windows.Forms.DataGridView();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.GBox_Users.SuspendLayout();
            this.GBox_DelUser.SuspendLayout();
            this.GBox_UpdUser.SuspendLayout();
            this.GBox_AddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_User_LogIn
            // 
            this.Lbl_User_LogIn.AutoSize = true;
            this.Lbl_User_LogIn.Location = new System.Drawing.Point(12, 9);
            this.Lbl_User_LogIn.Name = "Lbl_User_LogIn";
            this.Lbl_User_LogIn.Size = new System.Drawing.Size(10, 13);
            this.Lbl_User_LogIn.TabIndex = 0;
            this.Lbl_User_LogIn.Text = ".";
            // 
            // GBox_Users
            // 
            this.GBox_Users.Controls.Add(this.Btn_Cancel);
            this.GBox_Users.Controls.Add(this.Dgv_Users);
            this.GBox_Users.Controls.Add(this.GBox_DelUser);
            this.GBox_Users.Controls.Add(this.GBox_UpdUser);
            this.GBox_Users.Controls.Add(this.GBox_AddUser);
            this.GBox_Users.Location = new System.Drawing.Point(15, 35);
            this.GBox_Users.Name = "GBox_Users";
            this.GBox_Users.Size = new System.Drawing.Size(634, 366);
            this.GBox_Users.TabIndex = 1;
            this.GBox_Users.TabStop = false;
            this.GBox_Users.Text = "Actions Panel";
            // 
            // GBox_DelUser
            // 
            this.GBox_DelUser.Controls.Add(this.Txt_DelEmail);
            this.GBox_DelUser.Controls.Add(this.label4);
            this.GBox_DelUser.Controls.Add(this.Txt_DelPassword);
            this.GBox_DelUser.Controls.Add(this.Btn_DelUser);
            this.GBox_DelUser.Controls.Add(this.label5);
            this.GBox_DelUser.Controls.Add(this.Txt_DelUserName);
            this.GBox_DelUser.Controls.Add(this.label6);
            this.GBox_DelUser.Location = new System.Drawing.Point(394, 28);
            this.GBox_DelUser.Name = "GBox_DelUser";
            this.GBox_DelUser.Size = new System.Drawing.Size(177, 157);
            this.GBox_DelUser.TabIndex = 7;
            this.GBox_DelUser.TabStop = false;
            this.GBox_DelUser.Text = "Delete User";
            // 
            // Txt_DelEmail
            // 
            this.Txt_DelEmail.Location = new System.Drawing.Point(69, 81);
            this.Txt_DelEmail.Name = "Txt_DelEmail";
            this.Txt_DelEmail.Size = new System.Drawing.Size(100, 20);
            this.Txt_DelEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // Txt_DelPassword
            // 
            this.Txt_DelPassword.Location = new System.Drawing.Point(69, 55);
            this.Txt_DelPassword.Name = "Txt_DelPassword";
            this.Txt_DelPassword.Size = new System.Drawing.Size(100, 20);
            this.Txt_DelPassword.TabIndex = 2;
            // 
            // Btn_DelUser
            // 
            this.Btn_DelUser.Location = new System.Drawing.Point(6, 120);
            this.Btn_DelUser.Name = "Btn_DelUser";
            this.Btn_DelUser.Size = new System.Drawing.Size(75, 23);
            this.Btn_DelUser.TabIndex = 4;
            this.Btn_DelUser.Text = "Delete";
            this.Btn_DelUser.UseVisualStyleBackColor = true;
            this.Btn_DelUser.Click += new System.EventHandler(this.Btn_DelUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // Txt_DelUserName
            // 
            this.Txt_DelUserName.Location = new System.Drawing.Point(69, 29);
            this.Txt_DelUserName.Name = "Txt_DelUserName";
            this.Txt_DelUserName.Size = new System.Drawing.Size(100, 20);
            this.Txt_DelUserName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "UserName";
            // 
            // GBox_UpdUser
            // 
            this.GBox_UpdUser.Controls.Add(this.Txt_UpdEmail);
            this.GBox_UpdUser.Controls.Add(this.label1);
            this.GBox_UpdUser.Controls.Add(this.Txt_UpdPassword);
            this.GBox_UpdUser.Controls.Add(this.Btn_UpdUser);
            this.GBox_UpdUser.Controls.Add(this.label2);
            this.GBox_UpdUser.Controls.Add(this.Txt_UpdUserName);
            this.GBox_UpdUser.Controls.Add(this.label3);
            this.GBox_UpdUser.Location = new System.Drawing.Point(200, 28);
            this.GBox_UpdUser.Name = "GBox_UpdUser";
            this.GBox_UpdUser.Size = new System.Drawing.Size(188, 157);
            this.GBox_UpdUser.TabIndex = 6;
            this.GBox_UpdUser.TabStop = false;
            this.GBox_UpdUser.Text = "Update User";
            // 
            // Txt_UpdEmail
            // 
            this.Txt_UpdEmail.Location = new System.Drawing.Point(69, 81);
            this.Txt_UpdEmail.Name = "Txt_UpdEmail";
            this.Txt_UpdEmail.Size = new System.Drawing.Size(100, 20);
            this.Txt_UpdEmail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // Txt_UpdPassword
            // 
            this.Txt_UpdPassword.Location = new System.Drawing.Point(69, 55);
            this.Txt_UpdPassword.Name = "Txt_UpdPassword";
            this.Txt_UpdPassword.Size = new System.Drawing.Size(100, 20);
            this.Txt_UpdPassword.TabIndex = 2;
            // 
            // Btn_UpdUser
            // 
            this.Btn_UpdUser.Location = new System.Drawing.Point(9, 120);
            this.Btn_UpdUser.Name = "Btn_UpdUser";
            this.Btn_UpdUser.Size = new System.Drawing.Size(75, 23);
            this.Btn_UpdUser.TabIndex = 4;
            this.Btn_UpdUser.Text = "Update";
            this.Btn_UpdUser.UseVisualStyleBackColor = true;
            this.Btn_UpdUser.Click += new System.EventHandler(this.Btn_UpdUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // Txt_UpdUserName
            // 
            this.Txt_UpdUserName.Location = new System.Drawing.Point(69, 29);
            this.Txt_UpdUserName.Name = "Txt_UpdUserName";
            this.Txt_UpdUserName.Size = new System.Drawing.Size(100, 20);
            this.Txt_UpdUserName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "UserName";
            // 
            // GBox_AddUser
            // 
            this.GBox_AddUser.Controls.Add(this.Txt_AddEmail);
            this.GBox_AddUser.Controls.Add(this.Lbl_Email);
            this.GBox_AddUser.Controls.Add(this.Txt_AddPassword);
            this.GBox_AddUser.Controls.Add(this.Btn_AddUser);
            this.GBox_AddUser.Controls.Add(this.LbL_Password);
            this.GBox_AddUser.Controls.Add(this.Txt_AddUserName);
            this.GBox_AddUser.Controls.Add(this.Lbl_UserName);
            this.GBox_AddUser.Location = new System.Drawing.Point(6, 28);
            this.GBox_AddUser.Name = "GBox_AddUser";
            this.GBox_AddUser.Size = new System.Drawing.Size(188, 157);
            this.GBox_AddUser.TabIndex = 5;
            this.GBox_AddUser.TabStop = false;
            this.GBox_AddUser.Text = "Add User";
            // 
            // Txt_AddEmail
            // 
            this.Txt_AddEmail.Location = new System.Drawing.Point(69, 81);
            this.Txt_AddEmail.Name = "Txt_AddEmail";
            this.Txt_AddEmail.Size = new System.Drawing.Size(100, 20);
            this.Txt_AddEmail.TabIndex = 3;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(6, 84);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Email.TabIndex = 4;
            this.Lbl_Email.Text = "Email";
            // 
            // Txt_AddPassword
            // 
            this.Txt_AddPassword.Location = new System.Drawing.Point(69, 55);
            this.Txt_AddPassword.Name = "Txt_AddPassword";
            this.Txt_AddPassword.Size = new System.Drawing.Size(100, 20);
            this.Txt_AddPassword.TabIndex = 2;
            // 
            // Btn_AddUser
            // 
            this.Btn_AddUser.Location = new System.Drawing.Point(9, 120);
            this.Btn_AddUser.Name = "Btn_AddUser";
            this.Btn_AddUser.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddUser.TabIndex = 4;
            this.Btn_AddUser.Text = "Add";
            this.Btn_AddUser.UseVisualStyleBackColor = true;
            this.Btn_AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // LbL_Password
            // 
            this.LbL_Password.AutoSize = true;
            this.LbL_Password.Location = new System.Drawing.Point(6, 58);
            this.LbL_Password.Name = "LbL_Password";
            this.LbL_Password.Size = new System.Drawing.Size(53, 13);
            this.LbL_Password.TabIndex = 2;
            this.LbL_Password.Text = "Password";
            // 
            // Txt_AddUserName
            // 
            this.Txt_AddUserName.Location = new System.Drawing.Point(69, 29);
            this.Txt_AddUserName.Name = "Txt_AddUserName";
            this.Txt_AddUserName.Size = new System.Drawing.Size(100, 20);
            this.Txt_AddUserName.TabIndex = 1;
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Location = new System.Drawing.Point(6, 32);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(57, 13);
            this.Lbl_UserName.TabIndex = 0;
            this.Lbl_UserName.Text = "UserName";
            // 
            // Dgv_Users
            // 
            this.Dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Users.Location = new System.Drawing.Point(-6, 191);
            this.Dgv_Users.Name = "Dgv_Users";
            this.Dgv_Users.Size = new System.Drawing.Size(657, 183);
            this.Dgv_Users.TabIndex = 8;
            this.Dgv_Users.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Users_CellContentDoubleClick);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(572, 148);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(58, 23);
            this.Btn_Cancel.TabIndex = 9;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 413);
            this.Controls.Add(this.GBox_Users);
            this.Controls.Add(this.Lbl_User_LogIn);
            this.Name = "Home";
            this.Text = "Home";
            this.GBox_Users.ResumeLayout(false);
            this.GBox_DelUser.ResumeLayout(false);
            this.GBox_DelUser.PerformLayout();
            this.GBox_UpdUser.ResumeLayout(false);
            this.GBox_UpdUser.PerformLayout();
            this.GBox_AddUser.ResumeLayout(false);
            this.GBox_AddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_User_LogIn;
        private System.Windows.Forms.GroupBox GBox_Users;
        private System.Windows.Forms.Button Btn_DelUser;
        private System.Windows.Forms.Button Btn_UpdUser;
        private System.Windows.Forms.Button Btn_AddUser;
        private System.Windows.Forms.GroupBox GBox_AddUser;
        private System.Windows.Forms.TextBox Txt_AddPassword;
        private System.Windows.Forms.Label LbL_Password;
        private System.Windows.Forms.TextBox Txt_AddUserName;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.GroupBox GBox_UpdUser;
        private System.Windows.Forms.TextBox Txt_UpdEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_UpdPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_UpdUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_AddEmail;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.GroupBox GBox_DelUser;
        private System.Windows.Forms.TextBox Txt_DelEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_DelPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_DelUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Dgv_Users;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}