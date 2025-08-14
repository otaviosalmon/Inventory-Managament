namespace InventoryManagementSystem
{
    partial class UserModuleForm
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
            userModulePanel = new Panel();
            closeBox = new PictureBox();
            userModuleLabel = new Label();
            usernameLabel = new Label();
            txtUserName = new TextBox();
            txtFullName = new TextBox();
            fullnameLabel = new Label();
            txtPassword = new TextBox();
            passwordLabel = new Label();
            txtPhone = new TextBox();
            phoneLabel = new Label();
            saveButton = new Button();
            updateButton = new Button();
            clearButton = new Button();
            userModulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeBox).BeginInit();
            SuspendLayout();
            // 
            // userModulePanel
            // 
            userModulePanel.BackColor = Color.FromArgb(0, 70, 160);
            userModulePanel.Controls.Add(closeBox);
            userModulePanel.Controls.Add(userModuleLabel);
            userModulePanel.Dock = DockStyle.Top;
            userModulePanel.Location = new Point(0, 0);
            userModulePanel.Name = "userModulePanel";
            userModulePanel.Size = new Size(687, 47);
            userModulePanel.TabIndex = 0;
            // 
            // closeBox
            // 
            closeBox.Image = Properties.Resources.Close_Window;
            closeBox.Location = new Point(662, 0);
            closeBox.Name = "closeBox";
            closeBox.Size = new Size(25, 23);
            closeBox.SizeMode = PictureBoxSizeMode.Zoom;
            closeBox.TabIndex = 12;
            closeBox.TabStop = false;
            closeBox.Click += closeBox_Click;
            // 
            // userModuleLabel
            // 
            userModuleLabel.AutoSize = true;
            userModuleLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userModuleLabel.ForeColor = Color.White;
            userModuleLabel.Location = new Point(12, 9);
            userModuleLabel.Name = "userModuleLabel";
            userModuleLabel.Size = new Size(131, 23);
            userModuleLabel.TabIndex = 1;
            userModuleLabel.Text = "User Module";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(47, 73);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(101, 21);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "UserName:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(166, 70);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(443, 28);
            txtUserName.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(166, 123);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(443, 28);
            txtFullName.TabIndex = 4;
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.Location = new Point(47, 126);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new Size(95, 21);
            fullnameLabel.TabIndex = 3;
            fullnameLabel.Text = "Full Name:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(166, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(443, 28);
            txtPassword.TabIndex = 6;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(47, 183);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(93, 21);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(166, 240);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(443, 28);
            txtPhone.TabIndex = 8;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(59, 243);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(67, 21);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Phone:";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(0, 70, 160);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(180, 304);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(124, 52);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += User_Button_Save_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(0, 70, 160);
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(325, 304);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(124, 52);
            updateButton.TabIndex = 10;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += User_Button_Update_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Red;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(466, 304);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(124, 52);
            clearButton.TabIndex = 11;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += User_Button_Clear_Click;
            // 
            // UserModuleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 379);
            Controls.Add(clearButton);
            Controls.Add(updateButton);
            Controls.Add(saveButton);
            Controls.Add(txtPhone);
            Controls.Add(phoneLabel);
            Controls.Add(txtPassword);
            Controls.Add(passwordLabel);
            Controls.Add(txtFullName);
            Controls.Add(fullnameLabel);
            Controls.Add(txtUserName);
            Controls.Add(usernameLabel);
            Controls.Add(userModulePanel);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserModuleForm";
          
            userModulePanel.ResumeLayout(false);
            userModulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel userModulePanel;
        private Label userModuleLabel;
        private Label usernameLabel;
        private Label fullnameLabel;
        private Label passwordLabel;
        private Label phoneLabel;
        private PictureBox closeBox;
        public Button saveButton;
        public Button updateButton;
        public Button clearButton;
        public TextBox txtUserName;
        public TextBox txtFullName;
        public TextBox txtPassword;
        public TextBox txtPhone;
    }
}