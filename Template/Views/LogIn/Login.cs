using System;
using System.Windows.Forms;
using Template.Views;
using Template.DataAccess.RetriveServices;

namespace Template
{
    public partial class Login : Form
    {
        // Services
        private RetriveServicesUsers RetriveServicesUsers_;

        // Windows.
        private Forgot Forgot_;
        private Home Home_;

        // Variables
        public static string UserName;

        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Log_in();
        }

        private void Txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Log_in();
        }

        private void Btn_Forgot_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Forgot_ = new Forgot();
                Forgot_.ShowDialog();
                Clean();
                Show();                
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Log_in()
        {
            try
            {
                if (Txt_User.Text.Length <= 0 || Txt_Password.Text.Length <= 0) throw new Exception("Any field is empty");
                RetriveServicesUsers_ = new RetriveServicesUsers();
                var User = RetriveServicesUsers_.GetUserLogin(Txt_User.Text, Txt_Password.Text);
                UserName = User.UserName;
                Hide();
                Home_ = new Home();
                Home_.ShowDialog();
                Clean();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                RetriveServicesUsers_ = null;
            }
        }
        private void Clean()
        {
            Txt_User.Text = "";
            Txt_Password.Text = "";
            Txt_User.Focus();
        }
    }
}
