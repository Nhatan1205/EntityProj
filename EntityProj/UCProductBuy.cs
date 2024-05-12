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
    public partial class UCProductBuy : UserControl
    {
        private ImageDAO imageDAO = new ImageDAO();
        private AccountDAO accountDAO = new AccountDAO();
        private ProductDAO productDAO = new ProductDAO();
        private CartDAO cartDAO = new CartDAO();
        private FavoriteDAO favoriteDAO = new FavoriteDAO();
        private Account account = new Account();
        private Product product;
        private bool checkCart; // false for favorite, true for cart

        public UCProductBuy()
        {
            InitializeComponent();
            SetEventForAllControls(this);
            btnRate.Visible = false;
        }

        public UCProductBuy(Product pd, Account acc)
        {
            InitializeComponent();
            SetEventForAllControls(this);
            InitializeUCProductBuy(pd, acc);
            //Check for Cancel function
            ProductExtension pdE = new ProductExtension(pd);
            if (DateTime.Now > pdE.CancelDate() || pd.OrderCondition == (int)ordercondition.Completed)
            {
                btnCancel.Visible = false;
            }
        }

        public UCProductBuy(Product pd, Account acc, bool checkCart)
        {
            InitializeComponent();
            SetEventForAllControls(this);
            InitializeUCProductBuy(pd, acc);
            this.checkCart = checkCart;
        }

        private void InitializeUCProductBuy(Product pd, Account acc)
        {
            this.Dock = DockStyle.Top;
            btnRate.Visible = false;
            this.product = pd;
            account = acc;
            lblPrice.Text = pd.SalePrice.ToString("N0") + " VND";
            lblProductCondition.Visible = false;
            lblProductName.Text = pd.Name;

            byte[] imageData = imageDAO.GetImageProductData(pd.ID);

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pbProduct.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
        }

        private void UCProductBuy_Load(object sender, EventArgs e)
        {
            SetEventForAllControls(this);
            Account seller = accountDAO.Retrieve(product.SellerID.Value);
            lblSellerName.Text = "Seller name: " + seller.Name;
            
            if(product.OrderCondition == (int)ordercondition.Completed)
            {
                btnCancel.Visible = false;
                btnRate.Visible = true;
            }
        }

        private void UCProductBuy_MouseEnter(object sender, EventArgs e)
        {
            panelBody.BorderColor = Color.FromArgb(110, 110, 110);
        }

        private void UCProductBuy_MouseLeave(object sender, EventArgs e)
        {
            panelBody.BorderColor = Color.FromArgb(250, 250, 250);
        }

        private void SetEventForAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.MouseEnter += UCProductBuy_MouseEnter;
                control.MouseLeave += UCProductBuy_MouseLeave;
                if (control.HasChildren)
                {
                    SetEventForAllControls(control);
                }
            }
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            FRating f = new FRating(product);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FBuyDetail trackDetail = new FBuyDetail(product, account);
            trackDetail.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            /*// Buyed
            if (product.BuyerID != 0)
            {
                //update status for product
                product.OrderCondition = (int)ordercondition.Displaying;
                productDAO.Update(product);
                productDAO.DeleteBuyerID(product);
                //get seller
                if (product.PayMethod)
                {
                    Account Seller = accountDAO.Retrieve(product.SellerID);
                    Seller.Money -= product.SalePrice;
                    accountDAO.update(Seller);
                }
                //refund if product is allowed to refund && Online payment
                if (product.CancelRefund && product.PayMethod)
                {
                    Account Buyer = accountDAO.Retrieve(product.BuyerID);
                    Buyer.Money += product.SalePrice;
                    accountDAO.update(Buyer);
                }
            }
            // Not buyed yet
            else
            {
                if (checkCart)
                {
                    cartDAO.delete(account.Id, product.Id);
                }
                else
                {
                    favoriteDAO.delete(account.Id, product.Id);
                }
            }
            */
            // Buyed
            if (product.BuyerID != 0)
            {

                FCancelInfo fCancelInfo = new FCancelInfo(account, product);
                fCancelInfo.ShowDialog();
            }
            // Not buyed yet
            else
            {
                if (checkCart)
                {
                    cartDAO.delete(account.ID, product.ID);
                }
                else
                {
                    favoriteDAO.delete(account.ID, product.ID);
                }
            }
        }
    }
}
