namespace Template.Views
{
    partial class TestDataGrid
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
            this.Dgv_Users = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Users
            // 
            this.Dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Users.Location = new System.Drawing.Point(12, 38);
            this.Dgv_Users.Name = "Dgv_Users";
            this.Dgv_Users.Size = new System.Drawing.Size(776, 198);
            this.Dgv_Users.TabIndex = 0;
            this.Dgv_Users.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Users_CellDoubleClick);
            // 
            // TestDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_Users);
            this.Name = "TestDataGrid";
            this.Text = "TestDataGrid";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Users;
    }
}