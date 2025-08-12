namespace InventoryManagementSystem
{
    partial class UserForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            BottomPanelUser = new Panel();
            AddUserButton = new CustomerButton();
            manageLabel = new Label();
            dgvUser = new DataGridView();
            NoColumn = new DataGridViewTextBoxColumn();
            UserNameColumn = new DataGridViewTextBoxColumn();
            FullNameColumn = new DataGridViewTextBoxColumn();
            PasswordColumn = new DataGridViewTextBoxColumn();
            PhoneColumn = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            BottomPanelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddUserButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // BottomPanelUser
            // 
            BottomPanelUser.BackColor = Color.FromArgb(0, 70, 160);
            BottomPanelUser.Controls.Add(AddUserButton);
            BottomPanelUser.Controls.Add(manageLabel);
            BottomPanelUser.Dock = DockStyle.Bottom;
            BottomPanelUser.Location = new Point(0, 448);
            BottomPanelUser.Name = "BottomPanelUser";
            BottomPanelUser.Size = new Size(992, 58);
            BottomPanelUser.TabIndex = 0;
            // 
            // AddUserButton
            // 
            AddUserButton.Image = Properties.Resources.AddImage;
            AddUserButton.Location = new Point(918, 10);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(67, 40);
            AddUserButton.SizeMode = PictureBoxSizeMode.Zoom;
            AddUserButton.TabIndex = 1;
            AddUserButton.TabStop = false;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // manageLabel
            // 
            manageLabel.AutoSize = true;
            manageLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageLabel.ForeColor = Color.White;
            manageLabel.Location = new Point(11, 19);
            manageLabel.Name = "manageLabel";
            manageLabel.Size = new Size(125, 19);
            manageLabel.TabIndex = 0;
            manageLabel.Text = "Manage Users";
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.ColumnHeadersHeight = 30;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { NoColumn, UserNameColumn, FullNameColumn, PasswordColumn, PhoneColumn, Edit, Delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.Location = new Point(0, 0);
            dgvUser.Name = "dgvUser";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.Size = new Size(992, 448);
            dgvUser.TabIndex = 1;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            dgvUser.CellPainting += dataGridView1_CellPainting;
            // 
            // NoColumn
            // 
            NoColumn.HeaderText = "No";
            NoColumn.MinimumWidth = 6;
            NoColumn.Name = "NoColumn";
            NoColumn.Width = 125;
            // 
            // UserNameColumn
            // 
            UserNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UserNameColumn.HeaderText = "UserName";
            UserNameColumn.MinimumWidth = 6;
            UserNameColumn.Name = "UserNameColumn";
            UserNameColumn.Width = 113;
            // 
            // FullNameColumn
            // 
            FullNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullNameColumn.HeaderText = "Full Name";
            FullNameColumn.MinimumWidth = 6;
            FullNameColumn.Name = "FullNameColumn";
            // 
            // PasswordColumn
            // 
            PasswordColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PasswordColumn.HeaderText = "Password";
            PasswordColumn.MinimumWidth = 6;
            PasswordColumn.Name = "PasswordColumn";
            PasswordColumn.Width = 104;
            // 
            // PhoneColumn
            // 
            PhoneColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PhoneColumn.HeaderText = "Phone";
            PhoneColumn.MinimumWidth = 6;
            PhoneColumn.Name = "PhoneColumn";
            PhoneColumn.Width = 83;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.Edit_Pencil;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 6;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.Cancel;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 506);
            Controls.Add(dgvUser);
            Controls.Add(BottomPanelUser);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            BottomPanelUser.ResumeLayout(false);
            BottomPanelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddUserButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BottomPanelUser;
        private DataGridView dgvUser;
        private Label manageLabel;
        private CustomerButton AddUserButton;
        private DataGridViewTextBoxColumn NoColumn;
        private DataGridViewTextBoxColumn UserNameColumn;
        private DataGridViewTextBoxColumn FullNameColumn;
        private DataGridViewTextBoxColumn PasswordColumn;
        private DataGridViewTextBoxColumn PhoneColumn;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}