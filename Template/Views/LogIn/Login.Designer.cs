namespace Template
{
    partial class Login
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
            this.GBox_Login = new System.Windows.Forms.GroupBox();
            this.Btn_Forgot = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_User = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_User = new System.Windows.Forms.Label();
            this.GBox_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBox_Login
            // 
            this.GBox_Login.Controls.Add(this.Btn_Forgot);
            this.GBox_Login.Controls.Add(this.Btn_Login);
            this.GBox_Login.Controls.Add(this.Txt_Password);
            this.GBox_Login.Controls.Add(this.Txt_User);
            this.GBox_Login.Controls.Add(this.Lbl_Password);
            this.GBox_Login.Controls.Add(this.Lbl_User);
            this.GBox_Login.Location = new System.Drawing.Point(12, 12);
            this.GBox_Login.Name = "GBox_Login";
            this.GBox_Login.Size = new System.Drawing.Size(240, 154);
            this.GBox_Login.TabIndex = 0;
            this.GBox_Login.TabStop = false;
            this.GBox_Login.Text = "Login";
            // 
            // Btn_Forgot
            // 
            this.Btn_Forgot.Location = new System.Drawing.Point(129, 123);
            this.Btn_Forgot.Name = "Btn_Forgot";
            this.Btn_Forgot.Size = new System.Drawing.Size(98, 23);
            this.Btn_Forgot.TabIndex = 4;
            this.Btn_Forgot.Text = "Forgot Password";
            this.Btn_Forgot.UseVisualStyleBackColor = true;
            this.Btn_Forgot.Click += new System.EventHandler(this.Btn_Forgot_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(9, 123);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(75, 23);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "Log In";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(9, 86);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(218, 20);
            this.Txt_Password.TabIndex = 2;
            this.Txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Password_KeyDown);
            // 
            // Txt_User
            // 
            this.Txt_User.Location = new System.Drawing.Point(9, 42);
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(218, 20);
            this.Txt_User.TabIndex = 1;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(6, 70);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.Lbl_Password.TabIndex = 1;
            this.Lbl_Password.Text = "Password";
            // 
            // Lbl_User
            // 
            this.Lbl_User.AutoSize = true;
            this.Lbl_User.Location = new System.Drawing.Point(6, 26);
            this.Lbl_User.Name = "Lbl_User";
            this.Lbl_User.Size = new System.Drawing.Size(66, 13);
            this.Lbl_User.TabIndex = 0;
            this.Lbl_User.Text = "User o Email";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 171);
            this.Controls.Add(this.GBox_Login);
            this.Name = "Login";
            this.Text = "Log In";
            this.GBox_Login.ResumeLayout(false);
            this.GBox_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBox_Login;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_User;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Label Lbl_User;
        private System.Windows.Forms.Button Btn_Forgot;
        private System.Windows.Forms.Button Btn_Login;
    }
}

