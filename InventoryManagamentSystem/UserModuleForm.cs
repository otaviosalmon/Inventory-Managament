using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class UserModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Otavio\Documents\dbIMS.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cm = new SqlCommand();
        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void UserModuleForm_Load(object sender, EventArgs e)
        {

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }
        private void closeBox_Click(object sender, EventArgs e)
        {
             Close();
        }
        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtFullName.Text == "" || txtPassword.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tb_User(username , fullname ,password ,phone) VALUES(@username ,@fullname ,@password ,@phone)", con);
                    cm.Parameters.AddWithValue("@username", txtUserName.Text);
                    cm.Parameters.AddWithValue("@fullname", txtFullName.Text);
                    cm.Parameters.AddWithValue("@password", txtPassword.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully Saved");
                    Clear();
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
              
        }
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txtUserName.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtUserName.Focus();
        }


    }
}
