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
            dgvCategory = new DataGridView();
            category_Number = new DataGridViewTextBoxColumn();
            category_id_Column = new DataGridViewTextBoxColumn();
            category_name_Column = new DataGridViewTextBoxColumn();
            Edit_Category = new DataGridViewImageColumn();
            Delete_Category = new DataGridViewImageColumn();
            BottomPanelCategory = new Panel();
            AddCategoryButton = new CustomerButton();
            manageCategoriesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            BottomPanelCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddCategoryButton).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 70, 160);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategory.ColumnHeadersHeight = 30;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { category_Number, category_id_Column, category_name_Column, Edit_Category, Delete_Category });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategory.Dock = DockStyle.Fill;
            dgvCategory.EnableHeadersVisualStyles = false;
            dgvCategory.Location = new Point(0, 0);
            dgvCategory.Name = "dgvCategory";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(992, 482);
            dgvCategory.TabIndex = 5;
            dgvCategory.CellContentClick += dgvCategory_CellContentClick;
            dgvCategory.CellFormatting += dgvCategory_CellFormatting;
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
            // BottomPanelCategory
            // 
            BottomPanelCategory.BackColor = Color.FromArgb(0, 70, 160);
            BottomPanelCategory.Controls.Add(AddCategoryButton);
            BottomPanelCategory.Controls.Add(manageCategoriesLabel);
            BottomPanelCategory.Dock = DockStyle.Bottom;
            BottomPanelCategory.Location = new Point(0, 424);
            BottomPanelCategory.Name = "BottomPanelCategory";
            BottomPanelCategory.Size = new Size(992, 58);
            BottomPanelCategory.TabIndex = 6;
            // 
            // AddCategoryButton
            // 
            AddCategoryButton.Image = Properties.Resources.AddImage;
            AddCategoryButton.Location = new Point(918, 10);
            AddCategoryButton.Name = "AddCategoryButton";
            AddCategoryButton.Size = new Size(67, 40);
            AddCategoryButton.SizeMode = PictureBoxSizeMode.Zoom;
            AddCategoryButton.TabIndex = 1;
            AddCategoryButton.TabStop = false;
            AddCategoryButton.Click += AddCategoriesButton_Click;
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
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 482);
            Controls.Add(BottomPanelCategory);
            Controls.Add(dgvCategory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoriesForm";
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            BottomPanelCategory.ResumeLayout(false);
            BottomPanelCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddCategoryButton).EndInit();
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