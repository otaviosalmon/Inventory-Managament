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
        public string customerId;
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
        private void Customer_ButtonSave_Click(object sender, EventArgs e)
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
        private void Customer_Button_Update_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please fill in all spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (MessageBox.Show("Do you want to update this customer?", "Update Record.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tb_Customers SET customer_name = @customer_name, customer_phone = @customer_phone WHERE customer_id = @customer_id" , con);
                    cm.Parameters.AddWithValue("@customer_name", txtName.Text);
                    cm.Parameters.AddWithValue("@customer_phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@customer_id", customerId);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Customer updated successfully!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Customer_Button_Clear_Click(object sender, EventArgs e)
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
