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
    public partial class ProductModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Otavio\Documents\dbIMS.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cm = new SqlCommand();
        public ProductModuleForm()
        {
            InitializeComponent();
            this.Load += ProductModuleForm_Load;
        }

        private void ProductSaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtProductName.Text) || String.IsNullOrWhiteSpace(txtQty.Text) || String.IsNullOrWhiteSpace(txtPrice.Text) || String.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please fill in all spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(productComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var categoryId = (int)productComboBox.SelectedValue;

            var sql = @"INSERT INTO tb_Products (product_name, product_qty, price, description, category_id) VALUES (@product_name, @product_qty, @price, @description, @category_id)";

            try
            {
                if (MessageBox.Show("Are you sure you want to save this product?", "Saving Record.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (cm = new SqlCommand(sql, con)) {
                        cm.Parameters.Add("@product_name", SqlDbType.NVarChar, 50).Value = txtProductName.Text.Trim();
                        cm.Parameters.Add("@product_qty", SqlDbType.Int).Value = txtQty.Text.Trim();
                        cm.Parameters.Add("@price",SqlDbType.Decimal).Value = txtPrice.Text.Trim();
                        cm.Parameters["@price"].Precision = 10;
                        cm.Parameters["@price"].Scale = 2;
                        cm.Parameters.Add("@description", SqlDbType.NVarChar, 255).Value = txtDescription.Text.Trim();
                        cm.Parameters.Add("@category_id", SqlDbType.Int).Value = categoryId;
                        con.Open();
                        cm.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Product successfully added.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                Clear();
            }
        }
        private void ProductUpdateButton_Click(object sender , EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtProductName.Text) || (String.IsNullOrWhiteSpace(txtQty.Text) || String.IsNullOrWhiteSpace(txtPrice.Text) || (String.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please fill in all spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (productComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var categoryId = (int)productComboBox.SelectedValue;
            var sql = @"UPDATE tb_Products SET product_name = @product_name, product_qty = @product_qty, price = @price, description = @description, category_id = @category_id WHERE product_id = @product_id";
            try
            {
                if (MessageBox.Show("Are you sure you want to update this product?", "Update Product.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (cm = new SqlCommand(sql, con))
                    {
                        cm.Parameters.Add("@product_name", SqlDbType.NVarChar, 50).Value = txtProductName.Text.Trim();
                        cm.Parameters.Add("product_qty", SqlDbType.Int).Value = txtQty.Text.Trim();
                        cm.Parameters.Add("@price", SqlDbType.Decimal).Value = txtPrice.Text.Trim();
                        cm.Parameters["@price"].Precision = 10;
                        cm.Parameters["@price"].Scale = 2;
                        cm.Parameters.Add("@description", SqlDbType.NVarChar, 255).Value = txtDescription.Text.Trim();
                        cm.Parameters.Add("@category_id", SqlDbType.Int).Value = categoryId;
                        con.Open();
                        cm.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Product successfully updated.");
                }
            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadCategory()
        {
            productComboBox.DataSource = null;
            productComboBox.DisplayMember = null;
            productComboBox.ValueMember = null;
            var dataTable = new DataTable();

            try
            {
                using (cm = new SqlCommand("SELECT category_id, category_name FROM tb_Categories ORDER BY category_name", con))
                {
                    con.Open();
                    using (var dataAdapter = new SqlDataAdapter(cm))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
                productComboBox.DataSource = dataTable;
                productComboBox.DisplayMember = "category_name";
                productComboBox.ValueMember = "category_id";
                productComboBox.SelectedIndex = -1;
                productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void ProductModuleForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        private void CloseBox_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ProductClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
            txtQty.Clear();
        }

    }
}
