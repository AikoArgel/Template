using System;
using System.Windows.Forms;
using Template.DataAccess.RetriveServices;
using Template.DataAccess.WriteServices;
using Template.Models;

namespace Template.Views
{
    public partial class Forgot : Form
    {
        // Services
        private RetriveServicesUsers RetriveServicesUsers_;
        private WriteServicesUsers WriteServicesUsers_;

        // Models
        private Users Users_;

        public Forgot()
        {
            InitializeComponent();
            Users_ = Users_?? null;
            GBox_NewPassword.Enabled = false;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Forgot_Login();
        }
        private void Txt_NewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Forgot_Login();
        }
        private void Btn_SetNewPassword_Click(object sender, EventArgs e)
        {
            try
            {
                WriteServicesUsers_ = new WriteServicesUsers();
                Users_.Password = Txt_NewPassword.Text;
                Users_.Available = true;
                WriteServicesUsers_.UpdateUser(Users_);
                MessageBox.Show("Password saved");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                WriteServicesUsers_ = null;
                Users_ = null;
                Txt_NewPassword.Text = "";
                GBox_NewPassword.Enabled = false;
                GBox_Email.Enabled = true;
            }
        }
        
        private void Forgot_Login()
        {
            try
            {
                Users_ = new Users();
                RetriveServicesUsers_ = new RetriveServicesUsers();
                Users_ = RetriveServicesUsers_.GetUserByEmail(Txt_Email.Text);
                if (Users_ == null) throw new Exception("This Email not exist");
                GBox_NewPassword.Enabled = true;
                GBox_Email.Enabled = false;
                MessageBox.Show("Save your new password");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                RetriveServicesUsers_ = null;
                Txt_Email.Text = "";
            }
        }
    }
}
