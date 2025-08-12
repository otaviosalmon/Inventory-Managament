namespace InventoryManagementSystem
{
    partial class CostumerModuleForm
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
            customerModuleLabel = new Label();
            clearButton = new Button();
            updateButton = new Button();
            saveButton = new Button();
            txtPhone = new TextBox();
            phoneLabel = new Label();
            txtName = new TextBox();
            nameLabel = new Label();
            idLabel = new Label();
            userModulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeBox).BeginInit();
            SuspendLayout();
            // 
            // userModulePanel
            // 
            userModulePanel.BackColor = Color.FromArgb(0, 70, 160);
            userModulePanel.Controls.Add(closeBox);
            userModulePanel.Controls.Add(customerModuleLabel);
            userModulePanel.Dock = DockStyle.Top;
            userModulePanel.Location = new Point(0, 0);
            userModulePanel.Name = "userModulePanel";
            userModulePanel.Size = new Size(687, 47);
            userModulePanel.TabIndex = 1;
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
            // customerModuleLabel
            // 
            customerModuleLabel.AutoSize = true;
            customerModuleLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerModuleLabel.ForeColor = Color.White;
            customerModuleLabel.Location = new Point(12, 9);
            customerModuleLabel.Name = "customerModuleLabel";
            customerModuleLabel.Size = new Size(184, 23);
            customerModuleLabel.TabIndex = 1;
            customerModuleLabel.Text = "Customer Module";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Red;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(451, 225);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(124, 52);
            clearButton.TabIndex = 22;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += Button_Clear_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(0, 70, 160);
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(310, 225);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(124, 52);
            updateButton.TabIndex = 21;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(0, 70, 160);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(165, 225);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(124, 52);
            saveButton.TabIndex = 20;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += ButtonSave_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(163, 129);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(443, 29);
            txtPhone.TabIndex = 19;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(67, 132);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(57, 21);
            phoneLabel.TabIndex = 18;
            phoneLabel.Text = "Phone:";
            // 
            // txtName
            // 
            txtName.Location = new Point(163, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(443, 29);
            txtName.TabIndex = 15;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(77, 74);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(55, 21);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Name:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(227, 180);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(98, 21);
            idLabel.TabIndex = 12;
            idLabel.Text = "Customer id:";
            idLabel.Click += usernameLabel_Click;
            // 
            // CostumerModuleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 317);
            Controls.Add(clearButton);
            Controls.Add(updateButton);
            Controls.Add(saveButton);
            Controls.Add(txtPhone);
            Controls.Add(phoneLabel);
            Controls.Add(txtName);
            Controls.Add(nameLabel);
            Controls.Add(idLabel);
            Controls.Add(userModulePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CostumerModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CostumerModuleForm";
            userModulePanel.ResumeLayout(false);
            userModulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel userModulePanel;
        private PictureBox closeBox;
        private Label customerModuleLabel;
        public Button clearButton;
        public Button updateButton;
        public Button saveButton;
        public TextBox txtPhone;
        private Label phoneLabel;
        public TextBox txtName;
        private Label nameLabel;
        private Label idLabel;
    }
}