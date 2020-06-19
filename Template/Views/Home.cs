using System;
using System.Windows.Forms;
using Template.DataAccess.RetriveServices;
using Template.Models;
using Template.DataAccess.WriteServices;
using System.Collections.Generic;

namespace Template.Views
{
    public partial class Home : Form
    {
        //Services.
        private WriteServicesUsers WriteServicesUsers_;
        private RetriveServicesUsers RetriveServicesUsers_;

        // Models.
        private Users Users_;
        private List<Users> ListUsers_;

        public Home()
        {
            InitializeComponent();
            Lbl_User_LogIn.Text = "Welcome Back " + Login.UserName;
            SetDataGridView();
            GBox_UpdUser.Enabled = false;
            GBox_DelUser.Enabled = false;
            Btn_Cancel.Visible = false;
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                Users_.UserName = Txt_AddUserName.Text;
                Users_.Password = Txt_AddPassword.Text;
                Users_.Email = Txt_AddEmail.Text;
            
                WriteServicesUsers_.AddUser(Users_);
                MessageBox.Show("User has been add");
                SetDataGridView();
                CleanText();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_UpdUser_Click(object sender, EventArgs e)
        {
            try
            {
                Users_.UserName = Txt_UpdUserName.Text;
                Users_.Password = Txt_UpdPassword.Text;
                Users_.Email = Txt_UpdEmail.Text;
                Users_.Available = true;
                WriteServicesUsers_.UpdateUser(Users_);
                MessageBox.Show("User has been update");
                SetDataGridView();
                CleanText();
                GBox_AddUser.Enabled = true;
                GBox_UpdUser.Enabled = false;
                GBox_DelUser.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_DelUser_Click(object sender, EventArgs e)
        {
            try
            {
                WriteServicesUsers_.DeleteUser(Users_);
                MessageBox.Show("User has been Delete");
                SetDataGridView();
                CleanText();
                GBox_AddUser.Enabled = true;
                GBox_UpdUser.Enabled = false;
                GBox_DelUser.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetDataGridView()
        {
            ListUsers_ = null;
            Dgv_Users.Rows.Clear();
            try
            {
                Dgv_Users.ColumnCount = 6;
                Dgv_Users.Columns[0].Name = "User ID";
                Dgv_Users.Columns[1].Name = "UserName";
                Dgv_Users.Columns[2].Name = "Password";
                Dgv_Users.Columns[3].Name = "Email";
                Dgv_Users.Columns[4].Name = "LastUpdated";
                Dgv_Users.Columns[5].Name = "Available";
                RetriveServicesUsers_ = new RetriveServicesUsers();
                ListUsers_ = RetriveServicesUsers_.GetAllUsers();
                foreach (var list in ListUsers_)
                {
                    Dgv_Users.Rows.Add(list.UserID, list.UserName, list.Password, list.Email, list.LastUpdated, list.Available);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                RetriveServicesUsers_ = null;
                ListUsers_ = null;
            }
        }

        private void Dgv_Users_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                WriteServicesUsers_ = new WriteServicesUsers();
                Users_ = new Users()
                {
                    UserID = Convert.ToInt32(Dgv_Users.CurrentRow.Cells["User ID"].Value.ToString()),
                };
                Txt_UpdUserName.Text = Dgv_Users.CurrentRow.Cells["UserName"].Value.ToString();
                Txt_UpdPassword.Text = Dgv_Users.CurrentRow.Cells["Password"].Value.ToString();
                Txt_UpdEmail.Text = Dgv_Users.CurrentRow.Cells["Email"].Value.ToString();
                Txt_DelUserName.Text = Dgv_Users.CurrentRow.Cells["UserName"].Value.ToString();
                Txt_DelPassword.Text = Dgv_Users.CurrentRow.Cells["Password"].Value.ToString();
                Txt_DelEmail.Text = Dgv_Users.CurrentRow.Cells["Email"].Value.ToString();
                GBox_AddUser.Enabled = false;
                GBox_UpdUser.Enabled = true;
                GBox_DelUser.Enabled = true;
                Btn_Cancel.Visible = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void CleanText() {
            Txt_UpdUserName.Text = "";
            Txt_UpdPassword.Text = "";
            Txt_UpdEmail.Text = "";
            Txt_DelUserName.Text = "";
            Txt_DelPassword.Text = "";
            Txt_DelEmail.Text = "";
            Txt_AddUserName.Text = "";
            Txt_AddPassword.Text = "";
            Txt_AddEmail.Text = "";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            CleanText();
            GBox_AddUser.Enabled = true;
            GBox_UpdUser.Enabled = false;
            GBox_DelUser.Enabled = false;
            Btn_Cancel.Visible = false;

        }
    }
}
