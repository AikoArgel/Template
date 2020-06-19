using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Template.DataAccess.RetriveServices;
using Template.Models;

namespace Template.Views
{
    public partial class TestDataGrid : Form
    {
        // Services.
        private RetriveServicesUsers RetriveServicesUsers_;

        // Models.
        private List<Users> ListUsers_;

        public TestDataGrid()
        {
            InitializeComponent();
            Dgv_Users.ColumnCount = 6;
            Dgv_Users.Columns[0].Name = "User ID";
            Dgv_Users.Columns[1].Name = "UserName";
            Dgv_Users.Columns[2].Name = "Password";
            Dgv_Users.Columns[3].Name = "Email";
            Dgv_Users.Columns[4].Name = "LastUpdated";
            Dgv_Users.Columns[5].Name = "Available";            
            SetDataGridView();
        }
        private void SetDataGridView()
        {
            try
            {
                RetriveServicesUsers_ = new RetriveServicesUsers();
                ListUsers_ = RetriveServicesUsers_.GetAllUsers();
                foreach(var list in ListUsers_)
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

        private void Dgv_Users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string UserName = Dgv_Users.CurrentRow.Cells["UserName"].Value.ToString();
            string Email = Dgv_Users.CurrentRow.Cells["Email"].Value.ToString();
            MessageBox.Show(UserName +","+ Email);
        }
    }
}
