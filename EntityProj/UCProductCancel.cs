using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj.Forms
{
    public partial class UCProductCancel : UserControl
    {
        private Product pd;
        private Account acc;
        private CancelInfo ci; 
        private ProductDAO productDAO = new ProductDAO();
        private AccountDAO accountDAO = new AccountDAO();
        private ImageDAO imageDAO = new ImageDAO(); 
        private CancelInfoDAO cancelInfoDAO = new CancelInfoDAO();

        public UCProductCancel()
        {
            InitializeComponent();
        }

        public UCProductCancel(Cancel_Info ci)
        {
            InitializeComponent();
            pd = productDAO.Retrieve(ci.ProductID.Value);
            acc = accountDAO.Retrieve(ci.BuyerID.Value);
            this.ci = ci;
        }

        private void UCProductCancel_Load(object sender, EventArgs e)
        {
            lblMoney.Text = pd.SalePrice.ToString("N0") + " VND";
            lblProductName.Text = pd.Name;
            lblReason.Text = ci.Reason;
            lblSellerName.Text = acc.Name;
            txtDescription.Text = ci.ExtraInfo;
            convertByte(pbProduct, imageDAO.GetImageProductData(ci.ProductID));
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you delete this notification?", "DELETE NOTIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked "Yes"
            if (result == DialogResult.Yes)
            {
                cancelInfoDAO.delete(ci.Id);
            }
        }
    }
}
