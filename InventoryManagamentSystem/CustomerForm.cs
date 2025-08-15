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
    public partial class CustomerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Otavio\Documents\dbIMS.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cm = new SqlCommand();
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomer();
            AddCustomerButton.Normal = Properties.Resources.AddImage;
            AddCustomerButton.Hover = Properties.Resources.AddImageGray;
        }
        public void LoadCustomer()
        {
            int i = 1;
            dgvCostumer.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tb_Customers", con);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                dgvCostumer.Rows.Add(i++, dr["customer_id"].ToString(), dr["customer_name"].ToString(), dr["customer_phone"].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerModuleForm customerModule = new CustomerModuleForm();
            customerModule.saveButton.Enabled = true;
            customerModule.updateButton.Enabled = false;
            customerModule.clearButton.Enabled = true;
            customerModule.ShowDialog();

            LoadCustomer();
        }
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvCostumer.Columns[e.ColumnIndex].Name;

            if (e.RowIndex < 0) return;

            if (columnName == "Edit_Customer")
            {
                CustomerModuleForm costumerModule = new CustomerModuleForm();
                costumerModule.txtName.Text = dgvCostumer.Rows[e.RowIndex].Cells[2].Value.ToString();
                costumerModule.txtPhone.Text = dgvCostumer.Rows[e.RowIndex].Cells[3].Value.ToString();
                costumerModule.customerId = dgvCostumer.Rows[e.RowIndex].Cells[1].Value.ToString();
                costumerModule.saveButton.Enabled = false;
                costumerModule.updateButton.Enabled = true;
                costumerModule.clearButton.Enabled = true;
                costumerModule.ShowDialog();
                LoadCustomer();
            }
            else if (columnName == "Delete_Customer")
            {
                if (MessageBox.Show("Are you sure you want to delete this customer?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tb_Customers WHERE customer_id = @customer_id", con);
                    cm.Parameters.AddWithValue("@customer_id", dgvCostumer.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Costomer successfully deleted!");
                    LoadCustomer();
                }
            }

        }

        private void dgvCustomer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.Black; // For some reason , this is the only way for the text in the cells to be black
        }
    }

}
