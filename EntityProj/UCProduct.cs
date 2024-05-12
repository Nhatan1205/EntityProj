using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EntityProj.Forms
{
    public partial class UCProduct : UserControl
    {
        public EventHandler onSelect = null;
        private ImageDAO imageDAO = new ImageDAO();
        Account account = new Account();
        // Define an event to notify when the UserControl is double-clicked
        public event EventHandler<EventArgs> ProductDoubleClick;
        RecommendDAO recommendDAO = new RecommendDAO();

        private Product product;

        public Product Product { get => product; set => product = value; }

        public UCProduct()
        {
            InitializeComponent();
            SetEventForAllControls(this);
        }

        public UCProduct(Product pd, Account acc)
        {
            InitializeComponent();
            SetEventForAllControls(this);
            account = acc;
            this.product = pd;
            lblBuyPrice.Text = pd.OriginalPrice.ToString("N0") + " VND";
            lblSellPrice.Text = pd.SalePrice.ToString("N0") + " VND";
            lblProductName.Text = pd.Name.ToString();
            lblArea.Text = pd.Area.ToString();
            if(pd.PostedTime.Date == DateTime.Now.Date)
            {
                lblPostingTime.Text = (DateTime.Now.Hour - pd.PostedTime.Hour) + " hours ago";
            }
            else
            {
                lblPostingTime.Text = pd.PostedTime.ToString("dd-MM-yyyy");
            }


            byte[] imageData = imageDAO.GetImageProductData(pd.Id);

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pbProductImage.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
        }





        private void lblItemPrice_Click(object sender, EventArgs e)
        {

        }

        private void UCProduct_MouseEnter(object sender, EventArgs e)
        {
            panelBorder.BorderColor = Color.FromArgb(110, 110, 110);
        }

        private void UCProduct_MouseLeave(object sender, EventArgs e)
        {
            panelBorder.BorderColor = Color.Gainsboro;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void ratingProduct_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void UCProduct_DoubleClick(object sender, EventArgs e)
        {
            //if seller id is account id => not update recommned list
            if (!(product.SellerID == account.Id))
            {
                recommendDAO.update(product.Type, account.Id);
            }
            // Raise the ProductDoubleClick event
            ProductDoubleClick?.Invoke(this, EventArgs.Empty);
        }

        private void SetEventForAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += UCProduct_DoubleClick;
                control.MouseEnter += UCProduct_MouseEnter;
                control.MouseLeave += UCProduct_MouseLeave;
                if (control.HasChildren)
                {
                    SetEventForAllControls(control);
                }
            }

        }


        private void UCProduct_Click(object sender, EventArgs e)
        {
          
        }

        private void UCProduct_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
