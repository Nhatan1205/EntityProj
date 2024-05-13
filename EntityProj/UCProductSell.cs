using System;
using System.CodeDom;
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
    public partial class UCProductSell : UserControl
    {
        private ImageDAO imageDAO = new ImageDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private ProductDAO productDAO = new ProductDAO();
        private bool completed = false;
        private Product product;

        public UCProductSell()
        {
            InitializeComponent();
        }

        public UCProductSell(Product pd, Account acc)
        {
            InitializeComponent();
            this.product = pd;
            account = acc;
        }

        public UCProductSell(Product pd, Account acc, bool check)
        {
            InitializeComponent();
            this.product = pd;
            account = acc;
            completed = check;
        }

        private void pbProduct_Click(object sender, EventArgs e)
        {

        }

        private void lblSellerName_Click(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void lblProductCondition_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnFunction_DoubleClick(object sender, EventArgs e)
        {

        }


        private void UCProductSell_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Top;
            if(!(product.BuyerID <=0 || product.BuyerID == null))
            {
                Account Buyer = accountDAO.Retrieve(product.BuyerID.Value);
                lblBuyerName.Text = "Buyer name: " + Buyer.Name;
            }
            else
            {
                lblBuyerName.Text = "No one buy yet";
            }
            if (product.OrderCondition == (int)ordercondition.Displaying)
            {
                btnFunction.Text = "Hide product";
                btnFunction.Enabled = true;
            }
            else if (product.OrderCondition == (int)ordercondition.WaitforConfirmation)
            {
                btnFunction.Text = "Confirm";
                btnFunction.Enabled = true;
            }
            else if (product.OrderCondition == (int)ordercondition.Completed)
            {
                btnFunction.Text = "Completed";
                btnCancel.Enabled = false;
                btnFunction.Enabled = false;
            }
            else if (product.OrderCondition == (int)ordercondition.hidden)
            {
                btnFunction.Text = "Display product";
                btnFunction.Enabled = true;
            }

            lblPrice.Text = product.SalePrice.ToString("N0") + " VND";
            lblProductCondition.Visible = false;
            lblProductName.Text = product.Name;
            ProductExtension pdE = new ProductExtension(product);
            lblProductCondition.Text = pdE.GetBillStatus();
            convertByte(pbProduct, imageDAO.GetImageProductData(product.ID));
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("The product will be deleted in the system. Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            account.Money -= (float)product.SalePrice;
            accountDAO.Update(account);
            //get seller


            Account Buyer = accountDAO.Retrieve(product.BuyerID.Value);
            if (Buyer != null && product.PayMethod==true)
            {
                Buyer.Money += (float)product.SalePrice;
                accountDAO.Update(Buyer);
            }

            if (result == DialogResult.Yes)
            {
                productDAO.Delete(product);
                imageDAO.Delete(product.ID);
                MessageBox.Show("The product has been successfully deleted from the system.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (completed)
            {
                FSellDetail trackDetail = new FSellDetail(product, account, true);
                trackDetail.Show();

            } else
            {
                FSellDetail trackDetail = new FSellDetail(product, account);
                trackDetail.Show();
            }
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (product.OrderCondition <= (int)ordercondition.Displaying)
            {
                product.OrderCondition = (int)ordercondition.hidden;
                productDAO.UpdateOrderCondition(product);
            }
            else if (product.OrderCondition == (int)ordercondition.WaitforConfirmation)
            {
                product.OrderCondition = (int)ordercondition.Completed;
                product.CompleteTime = DateTime.Now;
                productDAO.UpdateOrderCondition(product);
            }
            else if (product.OrderCondition == (int)ordercondition.hidden)
            {
                product.OrderCondition = (int)ordercondition.Displaying;
                productDAO.UpdateOrderCondition(product);
            }
        }
    }
}
