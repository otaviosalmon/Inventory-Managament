namespace InventoryManagementSystem
{
    partial class CostumerForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvUser = new DataGridView();
            NoColumn = new DataGridViewTextBoxColumn();
            UserNameColumn = new DataGridViewTextBoxColumn();
            FullNameColumn = new DataGridViewTextBoxColumn();
            PasswordColumn = new DataGridViewTextBoxColumn();
            PhoneColumn = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            BottomPanelCustomer = new Panel();
            AddCustomerButton = new CustomerButton();
            manageCustomersLabel = new Label();
            dgvCustomer = new DataGridView();
            customer_Number = new DataGridViewTextBoxColumn();
            customer_id_Column = new DataGridViewTextBoxColumn();
            customer_name_Column = new DataGridViewTextBoxColumn();
            customer_phone_Column = new DataGridViewTextBoxColumn();
            Edit_Costumer = new DataGridViewImageColumn();
            Delete_Costumer = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            BottomPanelCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddCustomerButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            dgvUser.Size = new Size(992, 482);
            dgvUser.TabIndex = 2;
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
            UserNameColumn.Width = 114;
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
            PasswordColumn.Width = 108;
            // 
            // PhoneColumn
            // 
            PhoneColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            PhoneColumn.HeaderText = "Phone";
            PhoneColumn.MinimumWidth = 6;
            PhoneColumn.Name = "PhoneColumn";
            PhoneColumn.Width = 85;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.Edit_Pencil;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 41;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.Cancel;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 64;
            // 
            // BottomPanelCustomer
            // 
            BottomPanelCustomer.BackColor = Color.FromArgb(0, 70, 160);
            BottomPanelCustomer.Controls.Add(AddCustomerButton);
            BottomPanelCustomer.Controls.Add(manageCustomersLabel);
            BottomPanelCustomer.Dock = DockStyle.Bottom;
            BottomPanelCustomer.Location = new Point(0, 424);
            BottomPanelCustomer.Name = "BottomPanelCustomer";
            BottomPanelCustomer.Size = new Size(992, 58);
            BottomPanelCustomer.TabIndex = 3;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Image = Properties.Resources.AddImage;
            AddCustomerButton.Location = new Point(918, 10);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(67, 40);
            AddCustomerButton.SizeMode = PictureBoxSizeMode.Zoom;
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.TabStop = false;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // manageCustomersLabel
            // 
            manageCustomersLabel.AutoSize = true;
            manageCustomersLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageCustomersLabel.ForeColor = Color.White;
            manageCustomersLabel.Location = new Point(11, 19);
            manageCustomersLabel.Name = "manageCustomersLabel";
            manageCustomersLabel.Size = new Size(169, 19);
            manageCustomersLabel.TabIndex = 0;
            manageCustomersLabel.Text = "Manage Customers";
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomer.ColumnHeadersHeight = 30;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { customer_Number, customer_id_Column, customer_name_Column, customer_phone_Column, Edit_Costumer, Delete_Costumer });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvCustomer.DefaultCellStyle = dataGridViewCellStyle5;
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.Location = new Point(0, 0);
            dgvCustomer.Name = "dgvCustomer";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(992, 424);
            dgvCustomer.TabIndex = 4;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            dgvCustomer.CellFormatting += dgvCustomer_CellFormatting;
            // 
            // customer_Number
            // 
            customer_Number.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customer_Number.HeaderText = "No";
            customer_Number.MinimumWidth = 6;
            customer_Number.Name = "customer_Number";
            customer_Number.Width = 58;
            // 
            // customer_id_Column
            // 
            customer_id_Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customer_id_Column.HeaderText = "Customer id";
            customer_id_Column.MinimumWidth = 6;
            customer_id_Column.Name = "customer_id_Column";
            customer_id_Column.Width = 125;
            // 
            // customer_name_Column
            // 
            customer_name_Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer_name_Column.HeaderText = "Name";
            customer_name_Column.MinimumWidth = 6;
            customer_name_Column.Name = "customer_name_Column";
            // 
            // customer_phone_Column
            // 
            customer_phone_Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customer_phone_Column.HeaderText = "Phone";
            customer_phone_Column.MinimumWidth = 6;
            customer_phone_Column.Name = "customer_phone_Column";
            customer_phone_Column.Width = 83;
            // 
            // Edit_Costumer
            // 
            Edit_Costumer.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit_Costumer.HeaderText = "";
            Edit_Costumer.Image = Properties.Resources.Edit_Pencil;
            Edit_Costumer.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit_Costumer.MinimumWidth = 6;
            Edit_Costumer.Name = "Edit_Costumer";
            Edit_Costumer.Width = 6;
            // 
            // Delete_Costumer
            // 
            Delete_Costumer.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete_Costumer.HeaderText = "";
            Delete_Costumer.Image = Properties.Resources.Cancel;
            Delete_Costumer.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete_Costumer.MinimumWidth = 6;
            Delete_Costumer.Name = "Delete_Costumer";
            Delete_Costumer.Width = 6;
            // 
            // CostumerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 482);
            Controls.Add(dgvCustomer);
            Controls.Add(BottomPanelCustomer);
            Controls.Add(dgvUser);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CostumerForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "~;";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            BottomPanelCustomer.ResumeLayout(false);
            BottomPanelCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddCustomerButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUser;
        private DataGridViewTextBoxColumn NoColumn;
        private DataGridViewTextBoxColumn UserNameColumn;
        private DataGridViewTextBoxColumn FullNameColumn;
        private DataGridViewTextBoxColumn PasswordColumn;
        private DataGridViewTextBoxColumn PhoneColumn;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Panel BottomPanelCustomer;
        private CustomerButton AddCustomerButton;
        private Label manageCustomersLabel;
        private DataGridView dgvCustomer;
        private DataGridViewTextBoxColumn customer_Number;
        private DataGridViewTextBoxColumn customer_id_Column;
        private DataGridViewTextBoxColumn customer_name_Column;
        private DataGridViewTextBoxColumn customer_phone_Column;
        private DataGridViewImageColumn Edit_Costumer;
        private DataGridViewImageColumn Delete_Costumer;
    }
}