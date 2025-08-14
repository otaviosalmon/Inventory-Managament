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
    public partial class CategoryModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Otavio\Documents\dbIMS.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cm = new SqlCommand();
        public CategoryModuleForm()
        {
            InitializeComponent();
        }
        private void CloseBox_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Category_Save_Button_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Pleas fill in the name to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (MessageBox.Show("Are you sure you want to save this category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                {
                    cm = new SqlCommand("INSERT INTO tb_Categories (category_name) VALUES (@category_name)", con);
                    cm.Parameters.AddWithValue("@category_name", txtCategoryName.Text);
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

        private  void Category_Update_Button_Click(object sender, EventArgs e)
        {
            if(txtCategoryName.Text == "")
            {
                MessageBox.Show("Please inform the category that you want changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (MessageBox.Show("Are you sure you want to update this category?", "Update Record.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tb_Categories SET category_name = @category_name WHERE category_id = @category_id");
                    cm.Parameters.AddWithValue("@category_name", txtCategoryName.Text);
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
        private void Category_Clear_Button_Click(Object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtCategoryName.Clear();
        }
    }
}

