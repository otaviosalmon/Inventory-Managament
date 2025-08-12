namespace InventoryManagementSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            minimizeBox = new PictureBox();
            closeBox = new PictureBox();
            softwareLabel = new Label();
            logoPic = new PictureBox();
            usernameText = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            passwordText = new TextBox();
            button1 = new Button();
            cardboxPic = new PictureBox();
            loginLabel = new Label();
            checkPassword = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimizeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardboxPic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 160);
            panel1.Controls.Add(minimizeBox);
            panel1.Controls.Add(closeBox);
            panel1.Controls.Add(softwareLabel);
            panel1.Controls.Add(logoPic);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 82);
            panel1.TabIndex = 0;
            // 
            // minimizeBox
            // 
            minimizeBox.Image = Properties.Resources.Minimize_Window;
            minimizeBox.Location = new Point(313, 0);
            minimizeBox.Name = "minimizeBox";
            minimizeBox.Size = new Size(25, 23);
            minimizeBox.SizeMode = PictureBoxSizeMode.Zoom;
            minimizeBox.TabIndex = 10;
            minimizeBox.TabStop = false;
            minimizeBox.Click += minimizeBox_Click;
            // 
            // closeBox
            // 
            closeBox.Image = Properties.Resources.Close_Window;
            closeBox.Location = new Point(334, 0);
            closeBox.Name = "closeBox";
            closeBox.Size = new Size(25, 23);
            closeBox.SizeMode = PictureBoxSizeMode.Zoom;
            closeBox.TabIndex = 9;
            closeBox.TabStop = false;
            closeBox.Click += closeBox_Click;
            // 
            // softwareLabel
            // 
            softwareLabel.AutoSize = true;
            softwareLabel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            softwareLabel.ForeColor = Color.White;
            softwareLabel.Location = new Point(84, 29);
            softwareLabel.Name = "softwareLabel";
            softwareLabel.Size = new Size(263, 19);
            softwareLabel.TabIndex = 8;
            softwareLabel.Text = "Inventory Managament System";
            // 
            // logoPic
            // 
            logoPic.Image = Properties.Resources.products;
            logoPic.Location = new Point(3, 12);
            logoPic.Name = "logoPic";
            logoPic.Size = new Size(74, 50);
            logoPic.SizeMode = PictureBoxSizeMode.Zoom;
            logoPic.TabIndex = 7;
            logoPic.TabStop = false;
            // 
            // usernameText
            // 
            usernameText.Location = new Point(52, 254);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(251, 28);
            usernameText.TabIndex = 1;
            usernameText.TextChanged += textBox1_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(52, 230);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(101, 21);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "UserName:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(52, 321);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(93, 21);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(52, 345);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(251, 28);
            passwordText.TabIndex = 4;
            passwordText.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 70, 160);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(52, 456);
            button1.Name = "button1";
            button1.Size = new Size(251, 40);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // cardboxPic
            // 
            cardboxPic.Image = Properties.Resources.Box;
            cardboxPic.Location = new Point(108, 116);
            cardboxPic.Name = "cardboxPic";
            cardboxPic.Size = new Size(125, 62);
            cardboxPic.SizeMode = PictureBoxSizeMode.Zoom;
            cardboxPic.TabIndex = 6;
            cardboxPic.TabStop = false;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.FromArgb(0, 70, 160);
            loginLabel.Location = new Point(138, 197);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(62, 23);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "Login";
            // 
            // checkPassword
            // 
            checkPassword.AutoSize = true;
            checkPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkPassword.Location = new Point(95, 404);
            checkPassword.Name = "checkPassword";
            checkPassword.Size = new Size(158, 23);
            checkPassword.TabIndex = 8;
            checkPassword.Text = "Show Password";
            checkPassword.UseVisualStyleBackColor = true;
            checkPassword.CheckedChanged += checkPassowrdChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 613);
            Controls.Add(checkPassword);
            Controls.Add(loginLabel);
            Controls.Add(cardboxPic);
            Controls.Add(button1);
            Controls.Add(passwordText);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(usernameText);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minimizeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardboxPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox usernameText;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordText;
        private Button button1;
        private PictureBox cardboxPic;
        private Label softwareLabel;
        private PictureBox logoPic;
        private Label loginLabel;
        private CheckBox checkPassword;
        private PictureBox minimizeBox;
        private PictureBox closeBox;

        

        }
}
