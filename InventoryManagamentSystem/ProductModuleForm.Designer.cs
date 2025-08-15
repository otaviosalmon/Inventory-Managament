namespace InventoryManagementSystem
{
    partial class ProductModuleForm
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
            productModulePanel = new Panel();
            closeBox = new PictureBox();
            productModuleLabel = new Label();
            clearProductButton = new Button();
            updateProductButton = new Button();
            saveProductButton = new Button();
            txtDescription = new TextBox();
            descLabel = new Label();
            txtPrice = new TextBox();
            priceLabel = new Label();
            txtQty = new TextBox();
            qtyLabel = new Label();
            txtProductName = new TextBox();
            productNameLabel = new Label();
            productComboBox = new ComboBox();
            categorySelectLabel = new Label();
            productModulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeBox).BeginInit();
            SuspendLayout();
            // 
            // productModulePanel
            // 
            productModulePanel.BackColor = Color.FromArgb(0, 70, 160);
            productModulePanel.Controls.Add(closeBox);
            productModulePanel.Controls.Add(productModuleLabel);
            productModulePanel.Dock = DockStyle.Top;
            productModulePanel.Location = new Point(0, 0);
            productModulePanel.Name = "productModulePanel";
            productModulePanel.Size = new Size(687, 47);
            productModulePanel.TabIndex = 1;
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
            closeBox.Click += CloseBox_Click;
            // 
            // productModuleLabel
            // 
            productModuleLabel.AutoSize = true;
            productModuleLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productModuleLabel.ForeColor = Color.White;
            productModuleLabel.Location = new Point(12, 9);
            productModuleLabel.Name = "productModuleLabel";
            productModuleLabel.Size = new Size(164, 23);
            productModuleLabel.TabIndex = 1;
            productModuleLabel.Text = "Product Module";
            // 
            // clearProductButton
            // 
            clearProductButton.BackColor = Color.Red;
            clearProductButton.FlatAppearance.BorderSize = 0;
            clearProductButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            clearProductButton.ForeColor = Color.White;
            clearProductButton.Location = new Point(459, 357);
            clearProductButton.Name = "clearProductButton";
            clearProductButton.Size = new Size(124, 52);
            clearProductButton.TabIndex = 22;
            clearProductButton.Text = "Clear";
            clearProductButton.UseVisualStyleBackColor = false;
            clearProductButton.Click += ProductClearButton_Click;
            // 
            // updateProductButton
            // 
            updateProductButton.BackColor = Color.FromArgb(0, 70, 160);
            updateProductButton.FlatAppearance.BorderSize = 0;
            updateProductButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            updateProductButton.ForeColor = Color.White;
            updateProductButton.Location = new Point(318, 357);
            updateProductButton.Name = "updateProductButton";
            updateProductButton.Size = new Size(124, 52);
            updateProductButton.TabIndex = 21;
            updateProductButton.Text = "Update";
            updateProductButton.UseVisualStyleBackColor = false;
            updateProductButton.Click += ProductUpdateButton_Click;
            // 
            // saveProductButton
            // 
            saveProductButton.BackColor = Color.FromArgb(0, 70, 160);
            saveProductButton.FlatAppearance.BorderSize = 0;
            saveProductButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            saveProductButton.ForeColor = Color.White;
            saveProductButton.Location = new Point(173, 357);
            saveProductButton.Name = "saveProductButton";
            saveProductButton.Size = new Size(124, 52);
            saveProductButton.TabIndex = 20;
            saveProductButton.Text = "Save";
            saveProductButton.UseVisualStyleBackColor = false;
            saveProductButton.Click += ProductSaveButton_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(162, 239);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(443, 29);
            txtDescription.TabIndex = 19;
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(51, 247);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(92, 21);
            descLabel.TabIndex = 18;
            descLabel.Text = "Description:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(162, 179);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(443, 29);
            txtPrice.TabIndex = 17;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(96, 182);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(47, 21);
            priceLabel.TabIndex = 16;
            priceLabel.Text = "Price:";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(162, 122);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(443, 29);
            txtQty.TabIndex = 15;
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new Point(70, 125);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(73, 21);
            qtyLabel.TabIndex = 14;
            qtyLabel.Text = "Quantity:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(162, 69);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(443, 29);
            txtProductName.TabIndex = 13;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(76, 77);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(67, 21);
            productNameLabel.TabIndex = 12;
            productNameLabel.Text = "Product:";
            // 
            // productComboBox
            // 
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(162, 300);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(443, 29);
            productComboBox.TabIndex = 23;
            // 
            // categorySelectLabel
            // 
            categorySelectLabel.AutoSize = true;
            categorySelectLabel.Location = new Point(67, 303);
            categorySelectLabel.Name = "categorySelectLabel";
            categorySelectLabel.Size = new Size(76, 21);
            categorySelectLabel.TabIndex = 24;
            categorySelectLabel.Text = "Category:";
            // 
            // ProductModuleForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 423);
            Controls.Add(categorySelectLabel);
            Controls.Add(productComboBox);
            Controls.Add(clearProductButton);
            Controls.Add(updateProductButton);
            Controls.Add(saveProductButton);
            Controls.Add(txtDescription);
            Controls.Add(descLabel);
            Controls.Add(txtPrice);
            Controls.Add(priceLabel);
            Controls.Add(txtQty);
            Controls.Add(qtyLabel);
            Controls.Add(txtProductName);
            Controls.Add(productNameLabel);
            Controls.Add(productModulePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModuleForm";
            productModulePanel.ResumeLayout(false);
            productModulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closeBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel productModulePanel;
        private PictureBox closeBox;
        private Label productModuleLabel;
        public Button clearProductButton;
        public Button updateProductButton;
        public Button saveProductButton;
        public TextBox txtDescription;
        private Label descLabel;
        public TextBox txtPrice;
        private Label priceLabel;
        public TextBox txtQty;
        private Label qtyLabel;
        public TextBox txtProductName;
        private Label productNameLabel;
        private ComboBox productComboBox;
        private Label categorySelectLabel;
    }
}