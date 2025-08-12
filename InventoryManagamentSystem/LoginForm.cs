namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void checkPassowrdChanged(object sender, EventArgs e)
        {
           if (checkPassword.Checked)
            {
                passwordText.UseSystemPasswordChar = false;
            }
            else
            {
                passwordText.UseSystemPasswordChar = true;
            }

        }
        private void closeBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
      
        
       
    }
}
