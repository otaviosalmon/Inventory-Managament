using System;
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
    public partial class CustomerButton : PictureBox
    {
        
        public CustomerButton()
        {
            InitializeComponent();
            this.MouseLeave += CustomerMouse_Leave;
            this.MouseEnter += CustomerMouse_Hover;
        }
        private Image NormalImage;
        private Image HoverImage;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Normal
        {
            get { return NormalImage; }
            set
            {   NormalImage = value;
                this.Image = NormalImage;}
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Hover
        {
            get { return HoverImage; }
            set { HoverImage = value; }
        }
        public void CustomerMouse_Hover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
            if (HoverImage != null)
                this.Image = HoverImage;
        }
        public void CustomerMouse_Leave(object sender, EventArgs e)
        {
            if (NormalImage != null)
                this.Image = NormalImage;
        }

    }
}
