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
    public partial class CategoriesForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Otavio\Documents\dbIMS.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cm = new SqlCommand();
        public CategoriesForm()
        {
            InitializeComponent();
            LoadCategories();

            AddCategoryButton.Normal = Properties.Resources.AddImage;
            AddCategoryButton.Hover = Properties.Resources.AddImageGray;
        }

        private void LoadCategories()
        {
            int i = 1;
            dgvCategory.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tb_Categories");
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvCategory.Rows.Add(i++, dr["category_id"].ToString(), dr["category_name"].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void AddCategoriesButton_Click(object sender, EventArgs e)
        {
            CategoryModuleForm categoryModuleForm = new CategoryModuleForm();
            categoryModuleForm.saveCategoryButton.Enabled = true;
            categoryModuleForm.updateCategoryButton.Enabled = false;
            categoryModuleForm.clearCategoryButton.Enabled = true;
            categoryModuleForm.ShowDialog();

            LoadCategories();
        }
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvCategory.Columns[e.ColumnIndex].Name;

            if (e.ColumnIndex < 0) return;

            if (columnName == "Edit_Category")
            {
                CategoryModuleForm categoryModuleForm = new CategoryModuleForm();
                categoryModuleForm.txtCategoryName.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                categoryModuleForm.saveCategoryButton.Enabled = false;
                categoryModuleForm.updateCategoryButton.Enabled = true;
                categoryModuleForm.clearCategoryButton.Enabled = true;
                categoryModuleForm.ShowDialog();
            }
            else if (columnName == "Delete_Category")
            {
                if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tb_Categories WHERE category_id = @category_id", con);
                    cm.Parameters.AddWithValue("@customer_id", dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category successfully deleted!");
                    LoadCategories();
                }

            }
        }


        private void dgvCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.ForeColor = Color.Black; // For some reason , this is the only way for the text in the cells to be black
        }
    }
}
