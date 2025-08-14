namespace InventoryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            PanelTop = new Panel();
            ordersButtonLabel = new Label();
            usersButtonLabel = new Label();
            categoriesButtonLabel = new Label();
            customersButtonLabel = new Label();
            productButtonLabel = new Label();
            OrdersButton = new CustomerButton();
            UsersButton = new CustomerButton();
            CategoriesButton = new CustomerButton();
            CustomersButton = new CustomerButton();
            ProductButton = new CustomerButton();
            companyLabel_2 = new Label();
            companyLabel_1 = new Label();
            minimizeBox = new PictureBox();
            closeBox = new PictureBox();
            softwareLabel = new Label();
            PanelBottom = new Panel();
            PanelMain = new Panel();
            PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsersButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CategoriesButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomersButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).BeginInit();
            SuspendLayout();
            // 
            // PanelTop
            // 
            PanelTop.BackColor = Color.FromArgb(0, 70, 160);
            PanelTop.Controls.Add(ordersButtonLabel);
            PanelTop.Controls.Add(usersButtonLabel);
            PanelTop.Controls.Add(categoriesButtonLabel);
            PanelTop.Controls.Add(customersButtonLabel);
            PanelTop.Controls.Add(productButtonLabel);
            PanelTop.Controls.Add(OrdersButton);
            PanelTop.Controls.Add(UsersButton);
            PanelTop.Controls.Add(CategoriesButton);
            PanelTop.Controls.Add(CustomersButton);
            PanelTop.Controls.Add(ProductButton);
            PanelTop.Controls.Add(companyLabel_2);
            PanelTop.Controls.Add(companyLabel_1);
            PanelTop.Controls.Add(minimizeBox);
            PanelTop.Controls.Add(closeBox);
            PanelTop.Controls.Add(softwareLabel);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(0, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(984, 116);
            PanelTop.TabIndex = 0;
            // 
            // ordersButtonLabel
            // 
            ordersButtonLabel.AutoSize = true;
            ordersButtonLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordersButtonLabel.Location = new Point(856, 80);
            ordersButtonLabel.Name = "ordersButtonLabel";
            ordersButtonLabel.Size = new Size(66, 18);
            ordersButtonLabel.TabIndex = 19;
            ordersButtonLabel.Text = "OREDRS";
            // 
            // usersButtonLabel
            // 
            usersButtonLabel.AutoSize = true;
            usersButtonLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersButtonLabel.Location = new Point(760, 80);
            usersButtonLabel.Name = "usersButtonLabel";
            usersButtonLabel.Size = new Size(51, 18);
            usersButtonLabel.TabIndex = 18;
            usersButtonLabel.Text = "USERS";
            // 
            // categoriesButtonLabel
            // 
            categoriesButtonLabel.AutoSize = true;
            categoriesButtonLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoriesButtonLabel.Location = new Point(626, 80);
            categoriesButtonLabel.Name = "categoriesButtonLabel";
            categoriesButtonLabel.Size = new Size(100, 18);
            categoriesButtonLabel.TabIndex = 17;
            categoriesButtonLabel.Text = "CATEGORIES";
            // 
            // customersButtonLabel
            // 
            customersButtonLabel.AutoSize = true;
            customersButtonLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customersButtonLabel.Location = new Point(520, 80);
            customersButtonLabel.Name = "customersButtonLabel";
            customersButtonLabel.Size = new Size(96, 18);
            customersButtonLabel.TabIndex = 16;
            customersButtonLabel.Text = "CUSTOMERS";
            // 
            // productButtonLabel
            // 
            productButtonLabel.AutoSize = true;
            productButtonLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productButtonLabel.Location = new Point(421, 80);
            productButtonLabel.Name = "productButtonLabel";
            productButtonLabel.Size = new Size(77, 18);
            productButtonLabel.TabIndex = 0;
            productButtonLabel.Text = "PRODUCT";
            // 
            // OrdersButton
            // 
            OrdersButton.Image = Properties.Resources.orders;
            OrdersButton.InitialImage = (Image)resources.GetObject("OrdersButton.InitialImage");
            OrdersButton.Location = new Point(857, 37);
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(67, 40);
            OrdersButton.SizeMode = PictureBoxSizeMode.Zoom;
            OrdersButton.TabIndex = 15;
            OrdersButton.TabStop = false;
            // 
            // UsersButton
            // 
            UsersButton.Image = Properties.Resources.usersicon;
            UsersButton.Location = new Point(752, 37);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(67, 40);
            UsersButton.SizeMode = PictureBoxSizeMode.Zoom;
            UsersButton.TabIndex = 14;
            UsersButton.TabStop = false;
            UsersButton.Click += UsersButton_Click;
            // 
            // CategoriesButton
            // 
            CategoriesButton.Image = Properties.Resources.categories;
            CategoriesButton.Location = new Point(641, 37);
            CategoriesButton.Name = "CategoriesButton";
            CategoriesButton.Size = new Size(67, 40);
            CategoriesButton.SizeMode = PictureBoxSizeMode.Zoom;
            CategoriesButton.TabIndex = 13;
            CategoriesButton.TabStop = false;
            CategoriesButton.Click += CategoriesButton_Click;
            // 
            // CustomersButton
            // 
            CustomersButton.Image = Properties.Resources.costumer;
            CustomersButton.Location = new Point(533, 37);
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(67, 40);
            CustomersButton.SizeMode = PictureBoxSizeMode.Zoom;
            CustomersButton.TabIndex = 12;
            CustomersButton.TabStop = false;
            CustomersButton.Click += CustomersButton_Click;
            // 
            // ProductButton
            // 
            ProductButton.Image = Properties.Resources.products;
            ProductButton.Location = new Point(426, 37);
            ProductButton.Name = "ProductButton";
            ProductButton.Size = new Size(67, 40);
            ProductButton.SizeMode = PictureBoxSizeMode.Zoom;
            ProductButton.TabIndex = 0;
            ProductButton.TabStop = false;
            // 
            // companyLabel_2
            // 
            companyLabel_2.AutoSize = true;
            companyLabel_2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            companyLabel_2.ForeColor = Color.White;
            companyLabel_2.Location = new Point(44, 18);
            companyLabel_2.Name = "companyLabel_2";
            companyLabel_2.Size = new Size(69, 34);
            companyLabel_2.TabIndex = 0;
            companyLabel_2.Text = "ogo";
            // 
            // companyLabel_1
            // 
            companyLabel_1.AutoSize = true;
            companyLabel_1.Font = new Font("Impact", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            companyLabel_1.ForeColor = Color.White;
            companyLabel_1.Location = new Point(15, 0);
            companyLabel_1.Name = "companyLabel_1";
            companyLabel_1.Size = new Size(41, 54);
            companyLabel_1.TabIndex = 0;
            companyLabel_1.Text = "L";
            // 
            // minimizeBox
            // 
            minimizeBox.Image = Properties.Resources.Minimize_Window;
            minimizeBox.Location = new Point(936, 0);
            minimizeBox.Name = "minimizeBox";
            minimizeBox.Size = new Size(25, 23);
            minimizeBox.SizeMode = PictureBoxSizeMode.Zoom;
            minimizeBox.TabIndex = 11;
            minimizeBox.TabStop = false;
            minimizeBox.Click += minimizeBox_Click;
            // 
            // closeBox
            // 
            closeBox.Image = Properties.Resources.Close_Window;
            closeBox.Location = new Point(957, 0);
            closeBox.Name = "closeBox";
            closeBox.Size = new Size(25, 23);
            closeBox.SizeMode = PictureBoxSizeMode.Zoom;
            closeBox.TabIndex = 10;
            closeBox.TabStop = false;
            closeBox.Click += closeBox_Click;
            // 
            // softwareLabel
            // 
            softwareLabel.AutoSize = true;
            softwareLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            softwareLabel.ForeColor = Color.LightGray;
            softwareLabel.Location = new Point(15, 54);
            softwareLabel.Name = "softwareLabel";
            softwareLabel.Size = new Size(314, 23);
            softwareLabel.TabIndex = 9;
            softwareLabel.Text = "Inventory Management System";
            // 
            // PanelBottom
            // 
            PanelBottom.BackColor = Color.FromArgb(0, 70, 160);
            PanelBottom.Dock = DockStyle.Bottom;
            PanelBottom.ForeColor = Color.Red;
            PanelBottom.Location = new Point(0, 622);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(984, 17);
            PanelBottom.TabIndex = 1;
            // 
            // PanelMain
            // 
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PanelMain.ForeColor = Color.White;
            PanelMain.Location = new Point(0, 116);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(984, 506);
            PanelMain.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 639);
            Controls.Add(PanelMain);
            Controls.Add(PanelBottom);
            Controls.Add(PanelTop);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CategoriesButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomersButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelTop;
        private Panel PanelBottom;
        private Panel PanelMain;
        private Label softwareLabel;
        private PictureBox closeBox;
        private PictureBox minimizeBox;
        private Label companyLabel_1;
        private Label companyLabel_2;
        private CustomerButton ProductButton;
        private CustomerButton UsersButton;
        private CustomerButton CategoriesButton;
        private CustomerButton CustomersButton;
        private Label productButtonLabel;
        private CustomerButton OrdersButton;
        private Label categoriesButtonLabel;
        private Label customersButtonLabel;
        private Label ordersButtonLabel;
        private Label usersButtonLabel;
    }
}