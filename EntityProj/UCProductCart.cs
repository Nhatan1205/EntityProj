using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj.Forms
{
    public partial class UCProductCart : UserControl
    {
        private ImageDAO imageDAO = new ImageDAO();
        private CartDAO cartDAO = new CartDAO();
        private Product pd;
        private Account acc;
        // Declare an event to be raised when the checkbox is checked or unchecked
        public event EventHandler<EventArgs> SelectedChanged;
        // Declare an event to be raised when the delete button is clicked
        public event EventHandler<EventArgs> DeleteClicked;

        public Product Pd { get => pd; set => pd = value; }

        public UCProductCart()
        {
            InitializeComponent();
        }

        public UCProductCart(Product pd, Account account)
        {
            InitializeComponent();
            this.pd = pd;
            acc = account;
        }

        

        private void UCProductCart_Load(object sender, EventArgs e)
        {
            lblPrice.Text = pd.SalePrice.ToString("N0") + " VND";
            lblProductName.Text = pd.Name;
            lblSellerName.Text = acc.Name;
            convertByte(pbProduct, imageDAO.GetImageProductData(pd.ID));
        }

        private void convertByte(PictureBox pic, byte[] imageData)
        {

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuyDetail f = new FBuyDetail(pd, acc);
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cartDAO.delete(acc.ID, pd.ID);
            // Raise the DeleteClicked event
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void cbSelected_Click(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void cbSelected_CheckedChanged(object sender, EventArgs e)
        {
            // Raise the SelectedChanged event
            SelectedChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
