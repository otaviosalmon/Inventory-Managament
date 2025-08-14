namespace InventoryManagementSystem
{
    partial class CategoriesForm
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
            this.dgvCategory = new DataGridView();
            this.BottomPanelCategory = new Panel();
            this.AddCategoryButton = new CustomerButton();
            manageCategoriesLabel = new Label();
            category_Number = new DataGridViewTextBoxColumn();
            category_id_Column = new DataGridViewTextBoxColumn();
            category_name_Column = new DataGridViewTextBoxColumn();
            Edit_Category = new DataGridViewImageColumn();
            Delete_Category = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)this.dgvCategory).BeginInit();
            this.BottomPanelCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.AddCategoryButton).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.ColumnHeadersHeight = 30;
            this.dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategory.Columns.AddRange(new DataGridViewColumn[] { category_Number, category_id_Column, category_name_Column, Edit_Category, Delete_Category });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategory.Dock = DockStyle.Fill;
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.Location = new Point(0, 0);
            this.dgvCategory.Name = "dgvCategory";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.Size = new Size(992, 482);
            this.dgvCategory.TabIndex = 5;
            // 
            // BottomPanelCategory
            // 
            this.BottomPanelCategory.BackColor = Color.FromArgb(0, 70, 160);
            this.BottomPanelCategory.Controls.Add(this.AddCategoryButton);
            this.BottomPanelCategory.Controls.Add(manageCategoriesLabel);
            this.BottomPanelCategory.Dock = DockStyle.Bottom;
            this.BottomPanelCategory.Location = new Point(0, 424);
            this.BottomPanelCategory.Name = "BottomPanelCategory";
            this.BottomPanelCategory.Size = new Size(992, 58);
            this.BottomPanelCategory.TabIndex = 6;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Image = Properties.Resources.AddImage;
            this.AddCategoryButton.Location = new Point(918, 10);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new Size(67, 40);
            this.AddCategoryButton.SizeMode = PictureBoxSizeMode.Zoom;
            this.AddCategoryButton.TabIndex = 1;
            this.AddCategoryButton.TabStop = false;
            // 
            // manageCategoriesLabel
            // 
            manageCategoriesLabel.AutoSize = true;
            manageCategoriesLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageCategoriesLabel.ForeColor = Color.White;
            manageCategoriesLabel.Location = new Point(11, 19);
            manageCategoriesLabel.Name = "manageCategoriesLabel";
            manageCategoriesLabel.Size = new Size(172, 19);
            manageCategoriesLabel.TabIndex = 0;
            manageCategoriesLabel.Text = "Manage Categories";
            // 
            // category_Number
            // 
            category_Number.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            category_Number.HeaderText = "No";
            category_Number.MinimumWidth = 6;
            category_Number.Name = "category_Number";
            category_Number.Width = 58;
            // 
            // category_id_Column
            // 
            category_id_Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            category_id_Column.HeaderText = "Category Id";
            category_id_Column.MinimumWidth = 6;
            category_id_Column.Name = "category_id_Column";
            category_id_Column.Width = 125;
            // 
            // category_name_Column
            // 
            category_name_Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            category_name_Column.HeaderText = "Name";
            category_name_Column.MinimumWidth = 6;
            category_name_Column.Name = "category_name_Column";
            // 
            // Edit_Category
            // 
            Edit_Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit_Category.HeaderText = "";
            Edit_Category.Image = Properties.Resources.Edit_Pencil;
            Edit_Category.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit_Category.MinimumWidth = 6;
            Edit_Category.Name = "Edit_Category";
            Edit_Category.Width = 6;
            // 
            // Delete_Category
            // 
            Delete_Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete_Category.HeaderText = "";
            Delete_Category.Image = Properties.Resources.Cancel;
            Delete_Category.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete_Category.MinimumWidth = 6;
            Delete_Category.Name = "Delete_Category";
            Delete_Category.Width = 6;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 482);
            Controls.Add(this.BottomPanelCategory);
            Controls.Add(this.dgvCategory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoriesForm";
            Text = "CategoriesForm";
            ((System.ComponentModel.ISupportInitialize)this.dgvCategory).EndInit();
            this.BottomPanelCategory.ResumeLayout(false);
            this.BottomPanelCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.AddCategoryButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategory;
        private Panel BottomPanelCategory;
        private CustomerButton AddCategoryButton;
        private Label manageCategoriesLabel;

        private DataGridViewTextBoxColumn category_Number;
        private DataGridViewTextBoxColumn category_id_Column;
        private DataGridViewTextBoxColumn category_name_Column;
        private DataGridViewImageColumn Edit_Category;
        private DataGridViewImageColumn Delete_Category;

    }
}