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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Otavio\Documents\dbIMS.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cm = new SqlCommand();
        public UserForm()
        {
            InitializeComponent();
            LoadUser();

            AddUserButton.Normal = Properties.Resources.AddImage;
            AddUserButton.Hover = Properties.Resources.AddImageGray;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            e.CellStyle.ForeColor = Color.Black; // For some reason , this is the only way for the text in the cells to be black

        }

        public void LoadUser()
        {
            int i = 1;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tb_User", con);
            con.Open();
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                dgvUser.Rows.Add(i++,dr["username"].ToString(), dr["fullname"].ToString(), dr["password"].ToString(), dr["phone"].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule = new UserModuleForm();
            userModule.saveButton.Enabled = true;
            userModule.updateButton.Enabled = false;
            userModule.clearButton.Enabled = true;
            userModule.ShowDialog();
            LoadUser();
        }
        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvUser.Columns[e.ColumnIndex].Name;
            if (e.RowIndex < 0) return;
            if (columnName == "Edit")
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.txtUserName.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtUserName.ReadOnly = true;
                userModule.txtFullName.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtPassword.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtPhone.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.saveButton.Enabled = false;
                userModule.updateButton.Enabled = true;
                userModule.clearButton.Enabled = true;
                userModule.ShowDialog();
                LoadUser();
            }
            else if (columnName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this user?","Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tb_User WHERE username = @username", con);
                    cm.Parameters.AddWithValue("@username", dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully deleted");
                    LoadUser();


                }
            }
        }
    }
}
