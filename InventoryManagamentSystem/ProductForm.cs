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
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Otavio\Documents\dbIMS.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cm = new SqlCommand();
        public ProductForm()
        {
            InitializeComponent();
            AddProductButton.Normal = Properties.Resources.AddImage;
            AddProductButton.Hover = Properties.Resources.AddImageGray;
            LoadProducts();
        }
        private void LoadProducts()
        {
            int i = 1;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tb_Products", con);
            con.Open();
            SqlDataReader dataReader = cm.ExecuteReader();
            while (dataReader.Read())
            {
                dgvProduct.Rows.Add(i++, dataReader["product_id"].ToString(), dataReader["product_name"].ToString(), dataReader["product_qty"].ToString(), dataReader["price"].ToString(), dataReader["description"].ToString());
            }
            dataReader.Close();
            con.Close();
        }
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductModuleForm productModule = new ProductModuleForm();
            productModule.saveProductButton.Enabled = true;
            productModule.updateProductButton.Enabled = false;
            productModule.clearProductButton.Enabled = true;
            productModule.ShowDialog();

        }
        private void dgvProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.Black; // For some reason , this is the only way for the text in the cells to be black
        }

    }
}
