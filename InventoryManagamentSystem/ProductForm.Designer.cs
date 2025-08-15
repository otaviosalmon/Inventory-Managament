namespace InventoryManagementSystem
{
    partial class ProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvProduct = new DataGridView();
            BottomPanelProduct = new Panel();
            AddProductButton = new CustomerButton();
            manageProductsLabel = new Label();
            category_Number = new DataGridViewTextBoxColumn();
            product_id_Column = new DataGridViewTextBoxColumn();
            product_name_Column = new DataGridViewTextBoxColumn();
            product_qty_Column = new DataGridViewTextBoxColumn();
            product_price_Column = new DataGridViewTextBoxColumn();
            product_desc_Column = new DataGridViewTextBoxColumn();
            Edit_Product = new DataGridViewImageColumn();
            Delete_Product = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            BottomPanelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddProductButton).BeginInit();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProduct.ColumnHeadersHeight = 30;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { category_Number, product_id_Column, product_name_Column, product_qty_Column, product_price_Column, product_desc_Column, Edit_Product, Delete_Product });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle5;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(992, 482);
            dgvProduct.TabIndex = 6;
            dgvProduct.CellFormatting += dgvProduct_CellFormatting;
            // 
            // BottomPanelProduct
            // 
            BottomPanelProduct.BackColor = Color.FromArgb(0, 70, 160);
            BottomPanelProduct.Controls.Add(AddProductButton);
            BottomPanelProduct.Controls.Add(manageProductsLabel);
            BottomPanelProduct.Dock = DockStyle.Bottom;
            BottomPanelProduct.Location = new Point(0, 424);
            BottomPanelProduct.Name = "BottomPanelProduct";
            BottomPanelProduct.Size = new Size(992, 58);
            BottomPanelProduct.TabIndex = 7;
            // 
            // AddProductButton
            // 
            AddProductButton.Image = Properties.Resources.AddImage;
            AddProductButton.Location = new Point(918, 10);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(67, 40);
            AddProductButton.SizeMode = PictureBoxSizeMode.Zoom;
            AddProductButton.TabIndex = 1;
            AddProductButton.TabStop = false;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // manageProductsLabel
            // 
            manageProductsLabel.AutoSize = true;
            manageProductsLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageProductsLabel.ForeColor = Color.White;
            manageProductsLabel.Location = new Point(11, 19);
            manageProductsLabel.Name = "manageProductsLabel";
            manageProductsLabel.Size = new Size(153, 19);
            manageProductsLabel.TabIndex = 0;
            manageProductsLabel.Text = "Manage Products";
            // 
            // category_Number
            // 
            category_Number.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            category_Number.HeaderText = "No";
            category_Number.MinimumWidth = 6;
            category_Number.Name = "category_Number";
            category_Number.Width = 58;
            // 
            // product_id_Column
            // 
            product_id_Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            product_id_Column.HeaderText = "Product id";
            product_id_Column.MinimumWidth = 6;
            product_id_Column.Name = "product_id_Column";
            product_id_Column.Width = 111;
            // 
            // product_name_Column
            // 
            product_name_Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            product_name_Column.HeaderText = "Name";
            product_name_Column.MinimumWidth = 6;
            product_name_Column.Name = "product_name_Column";
            product_name_Column.Width = 82;
            // 
            // product_qty_Column
            // 
            product_qty_Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            product_qty_Column.HeaderText = "Qty";
            product_qty_Column.MinimumWidth = 6;
            product_qty_Column.Name = "product_qty_Column";
            product_qty_Column.Width = 63;
            // 
            // product_price_Column
            // 
            product_price_Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            product_price_Column.HeaderText = "Price";
            product_price_Column.MinimumWidth = 6;
            product_price_Column.Name = "product_price_Column";
            product_price_Column.Width = 74;
            // 
            // product_desc_Column
            // 
            product_desc_Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            product_desc_Column.HeaderText = "Description";
            product_desc_Column.MinimumWidth = 6;
            product_desc_Column.Name = "product_desc_Column";
            // 
            // Edit_Product
            // 
            Edit_Product.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit_Product.HeaderText = "";
            Edit_Product.Image = Properties.Resources.Edit_Pencil;
            Edit_Product.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit_Product.MinimumWidth = 6;
            Edit_Product.Name = "Edit_Product";
            Edit_Product.Width = 6;
            // 
            // Delete_Product
            // 
            Delete_Product.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete_Product.HeaderText = "";
            Delete_Product.Image = Properties.Resources.Cancel;
            Delete_Product.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete_Product.MinimumWidth = 6;
            Delete_Product.Name = "Delete_Product";
            Delete_Product.Width = 6;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 482);
            Controls.Add(BottomPanelProduct);
            Controls.Add(dgvProduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            BottomPanelProduct.ResumeLayout(false);
            BottomPanelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddProductButton).EndInit();
            ResumeLayout(false);
        }

        private void DgvProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dgvProduct;
        private Panel BottomPanelProduct;
        private CustomerButton AddProductButton;
        private Label manageProductsLabel;
        private DataGridViewTextBoxColumn category_Number;
        private DataGridViewTextBoxColumn product_id_Column;
        private DataGridViewTextBoxColumn product_name_Column;
        private DataGridViewTextBoxColumn product_qty_Column;
        private DataGridViewTextBoxColumn product_price_Column;
        private DataGridViewTextBoxColumn product_desc_Column;
        private DataGridViewImageColumn Edit_Product;
        private DataGridViewImageColumn Delete_Product;
    }
}