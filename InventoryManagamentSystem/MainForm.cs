using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ProductButton.Normal = Properties.Resources.products;
            ProductButton.Hover = Properties.Resources.productslightgray;

            UsersButton.Normal = Properties.Resources.usersicon;
            UsersButton.Hover = Properties.Resources.usersicongray;

            CategoriesButton.Normal = Properties.Resources.categories;
            CategoriesButton.Hover = Properties.Resources.categoriesgray;

            OrdersButton.Normal = Properties.Resources.orders;
            OrdersButton.Hover = Properties.Resources.ordersgray;

            CustomersButton.Normal = Properties.Resources.costumer;
            CustomersButton.Hover = Properties.Resources.costumersgray;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(childForm);
            PanelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        private void UsersButton_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }
        private void CustomersButton_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());
        }
        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoriesForm());
        }
        private void ProductButton_Click(Object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
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

