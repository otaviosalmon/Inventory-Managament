namespace InventoryManagementSystem
{
    partial class CategoryModuleForm
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
            categoryModuleLabel = new Label();
            clearCategoryButton = new Button();
            updateCategoryButton = new Button();
            saveCategoryButton = new Button();
            txtCategoryName = new TextBox();
            categoryNameLabel = new Label();
            userModulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeBox).BeginInit();
            SuspendLayout();
            // 
            // userModulePanel
            // 
            userModulePanel.BackColor = Color.FromArgb(0, 70, 160);
            userModulePanel.Controls.Add(closeBox);
            userModulePanel.Controls.Add(categoryModuleLabel);
            userModulePanel.Dock = DockStyle.Top;
            userModulePanel.Location = new Point(0, 0);
            userModulePanel.Name = "userModulePanel";
            userModulePanel.Size = new Size(687, 47);
            userModulePanel.TabIndex = 2;
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
            // 
            // categoryModuleLabel
            // 
            categoryModuleLabel.AutoSize = true;
            categoryModuleLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryModuleLabel.ForeColor = Color.White;
            categoryModuleLabel.Location = new Point(12, 9);
            categoryModuleLabel.Name = "categoryModuleLabel";
            categoryModuleLabel.Size = new Size(182, 23);
            categoryModuleLabel.TabIndex = 1;
            categoryModuleLabel.Text = "Category Module";
            // 
            // clearCategoryButton
            // 
            clearCategoryButton.BackColor = Color.Red;
            clearCategoryButton.FlatAppearance.BorderSize = 0;
            clearCategoryButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            clearCategoryButton.ForeColor = Color.White;
            clearCategoryButton.Location = new Point(451, 146);
            clearCategoryButton.Name = "clearCategoryButton";
            clearCategoryButton.Size = new Size(124, 52);
            clearCategoryButton.TabIndex = 29;
            clearCategoryButton.Text = "Clear";
            clearCategoryButton.UseVisualStyleBackColor = false;
            // 
            // updateCategoryButton
            // 
            updateCategoryButton.BackColor = Color.FromArgb(0, 70, 160);
            updateCategoryButton.FlatAppearance.BorderSize = 0;
            updateCategoryButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            updateCategoryButton.ForeColor = Color.White;
            updateCategoryButton.Location = new Point(310, 146);
            updateCategoryButton.Name = "updateCategoryButton";
            updateCategoryButton.Size = new Size(124, 52);
            updateCategoryButton.TabIndex = 28;
            updateCategoryButton.Text = "Update";
            updateCategoryButton.UseVisualStyleBackColor = false;
            // 
            // saveCategoryButton
            // 
            saveCategoryButton.BackColor = Color.FromArgb(0, 70, 160);
            saveCategoryButton.FlatAppearance.BorderSize = 0;
            saveCategoryButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            saveCategoryButton.ForeColor = Color.White;
            saveCategoryButton.Location = new Point(165, 146);
            saveCategoryButton.Name = "saveCategoryButton";
            saveCategoryButton.Size = new Size(124, 52);
            saveCategoryButton.TabIndex = 27;
            saveCategoryButton.Text = "Save";
            saveCategoryButton.UseVisualStyleBackColor = false;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(163, 84);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(443, 29);
            txtCategoryName.TabIndex = 24;
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new Point(77, 87);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new Size(55, 21);
            categoryNameLabel.TabIndex = 23;
            categoryNameLabel.Text = "Name:";
            // 
            // CategoryModuleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 227);
            Controls.Add(clearCategoryButton);
            Controls.Add(updateCategoryButton);
            Controls.Add(saveCategoryButton);
            Controls.Add(txtCategoryName);
            Controls.Add(categoryNameLabel);
            Controls.Add(userModulePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryModuleForm";
            userModulePanel.ResumeLayout(false);
            userModulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel userModulePanel;
        private PictureBox closeBox;
        private Label categoryModuleLabel;
        public Button clearCategoryButton;
        public Button updateCategoryButton;
        public Button saveCategoryButton;
        public TextBox txtCategoryName;
        private Label categoryNameLabel;
    }
}