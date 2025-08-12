using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class CostumerModuleForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Otavio\Documents\dbIMS.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cm = new SqlCommand();
        public CostumerModuleForm()
        {
            InitializeComponent();

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }
        private void closeBox_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (MessageBox.Show("Are you sure you want to save this customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tb_Customers (customer_name, customer_phone) VALUES (@customer_name, @customer_phone)", con);
                    cm.Parameters.AddWithValue("@customer_name", txtName.Text);
                    cm.Parameters.AddWithValue("@customer_phone", txtPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button_Update_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please fill in all spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (MessageBox.Show("Do you want to update this user?", "Update Record.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE");
                }
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txtName.Clear();
            txtPhone.Clear();
        }

    }
}
