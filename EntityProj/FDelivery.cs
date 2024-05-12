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
using Utilities.BunifuCheckBox.Transitions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EntityProj.Forms
{
    public partial class FDelivery : Form
    {
        private List<Product> products = new List<Product>();
        private VoucherDAO voucherDAO = new VoucherDAO();   
        private AccountDAO accountDAO = new AccountDAO();
        private FavoriteDAO favoriteDAO = new FavoriteDAO();
        private ProductDAO productDAO = new ProductDAO();
        ShippingDAO shippingDAO = new ShippingDAO();
        private CartDAO cartDAO = new CartDAO();
        private Account acc = new Account();
        private double total = 0;
        private double voucherValue = 0;
        private double subtotal = 0;
        private int payMethod = -1;


        public FDelivery()
        {
            InitializeComponent();
            containerMenu.Visible = false;
        }

        public FDelivery(Account acc, List<Product> products)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            this.acc = acc;
            this.products = products;
        }

        private void FDelivery_Load(object sender, EventArgs e)
        {
            subtotal = 0;
            total = 0;
            foreach (Product p in products)
            {
                UCProductCart uc = new UCProductCart(p, acc);
                uc.cbSelected.Visible = false;
                subtotal += (double)p.SalePrice;
                flpCartList.Controls.Add(uc);
            }
            total = subtotal;


            if (acc.Money < total)
            {
                rbtnCash.Checked = true;
                rbtnOnline.Checked = false;
                rbtnOnline.Enabled = false;
            }

            lblSubtotal.Text = subtotal.ToString("N0") + " VND";
            lblPrice.Text = total.ToString("N0") + " VND";
            lblNoOfItems.Text = products.Count.ToString();
            //
            Shipping shipping = shippingDAO.GetShipping(acc.SelectedShipping);
            if (shipping != null)
            {
                txtAddress.Text = shipping.Address;
                txtRecipientName.Text = shipping.RecipientName;
                txtPhone.Text = shipping.PhoneNo;
            }
            else
            {
                txtAddress.Text = "";
                txtRecipientName.Text = "";
                txtPhone.Text = "";
            }
            // menu
            lblMenuAccountName.Text = acc.Name;
            ratingMenuAccount.Value = acc.AvgRating;
            convertByte(pbMenuAvatar, acc.Avatar);

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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCart f = new FCart(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (containerMenu.Visible == false)
            {
                containerMenu.Visible = true;
            }
            else
            {
                containerMenu.Visible = false;
            }
        }

        private void btnPurchasesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FTrackOrder f = new FTrackOrder(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FProductManagement f = new FProductManagement(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSavedProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSaveList f = new FSaveList(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnOrderAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOrderAnalysis f = new FOrderAnalysis(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FInformation f = new FInformation(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMoney f = new FMoney(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignin f = new FSignin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSellDetail f = new FSellDetail(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void rbtnOnline_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnOnline.Checked)
            {
                payMethod = 1;
                rbtnCash.Checked = false;
            }
        }

        private void rbtnCash_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnCash.Checked)
            {
                payMethod = 0;
                rbtnOnline.Checked = false;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            /*
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone has not been filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address has not been filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
            if (payMethod == -1)
            {
                MessageBox.Show("Payment Method has not been chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(acc.SelectedShipping == 0)
            {
                MessageBox.Show("Shipping Method has not been chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Prompt the user with a message box
                DialogResult result = MessageBox.Show("Are you sure you want to buy these product?", "BUY PRODUCT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked "Yes"
                if (result == DialogResult.Yes)
                {
                    foreach (Product product in products)
                    {
                        // Update Buyer money
                        Account buyer = new Account(acc.Id);
                        // Check pay method (is it online or not)
                        if (payMethod == 1)
                        {
                            buyer.Money -= total;
                            accountDAO.update(buyer);
                            product.PayMethod = true;
                        } else
                        {
                            product.PayMethod = false;
                        }
                        //  Update Seller money
                        Account seller = new Account(product.SellerID);
                        seller.Money += product.SalePrice;
                        accountDAO.update(seller);
                        // Update product
                        Shipping shipping = shippingDAO.GetShipping(acc.SelectedShipping);
                        product.SelectedShipping = acc.SelectedShipping;
                        // Proceed with the purchase
                        if (favoriteDAO.checkProductinFavorite(acc.Id, product.Id))
                        {
                            favoriteDAO.delete(acc.Id, product.Id);
                        } 
                        if (cartDAO.checkProductinCart(acc.Id, product.Id))
                        {
                            cartDAO.delete(acc.Id, product.Id);
                        }
                        product.BuyerID = acc.Id;
                        product.OrderCondition = (int)ordercondition.WaitforConfirmation;
                        productDAO.Update(product);
                    }
                }
            }
        }

        private void llblAddAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FShipping fShipping = new FShipping(acc);
            fShipping.ShowDialog();
        }

        private void lblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lblEdit.Text == "Edit")
            {
                lblEdit.Text = "Save";
                lblPackage.Text = "List of your address";
                flpCartList.Controls.Clear();
                List<Shipping> shippings = shippingDAO.LoadList();
                foreach (var ship in shippings)
                {
                    if (acc.Id == ship.AccountId)
                    {
                        UCShipping uc = new UCShipping(ship);
                        uc.SelectedChanged += UC_ShippingSelectedChanged;
                        flpCartList.Controls.Add(uc);
                    }
                }
            }
            else
            {
                lblEdit.Text = "Edit";
                lblPackage.Text = "Package";
                flpCartList.Controls.Clear();
                FDelivery_Load(sender,e);
            }
        }

        private void UC_ShippingSelectedChanged(object sender, EventArgs e)
        {
            // Cast the sender object back to UCShipping to access its properties
            UCShipping selectedUC = sender as UCShipping;
            selectedUC.panelBorder.BorderColor = Color.Black;
            acc.SelectedShipping = selectedUC.Shipping.Id;
            accountDAO.update(acc);

            // Iterate through each UCShipping control in the flow layout panel
            foreach (UCShipping uc in flpCartList.Controls)
            {
                // Check if the current UCShipping control is not the one that triggered the event
                if (uc != selectedUC)
                {
                    // Disable the radio button in the current UCShipping control
                    uc.panelBorder.BorderColor = Color.Silver;
                }
            }
        }

        private void btnApplyVoucher_Click(object sender, EventArgs e)
        {
            if (btnApplyVoucher.Text == "Voucher")
            {
                btnApplyVoucher.Text = "CLOSE";
                lblPackage.Text = "All available vouchers";
                flpCartList.Controls.Clear();
                List<int> Voucherids = voucherDAO.GetVoucherIDsByBuyerID(acc.Id);
                foreach (var voucherID in Voucherids)
                {
                    Voucher voucher = voucherDAO.GetVoucher(voucherID);
                    if(voucher.Beginday <= DateTime.Now && DateTime.Now <= voucher.Endday)
                    {
                        UCApplyVoucher uc = new UCApplyVoucher(voucher, acc);
                        uc.SelectedChanged += UC_ApplyVoucherSelectedChanged;
                        flpCartList.Controls.Add(uc);
                    }
                }
            }
            else
            {
                btnApplyVoucher.Text = "Voucher";
                lblPackage.Text = "Package";
                flpCartList.Controls.Clear();
                foreach (Product p in products)
                {
                    UCProductCart uc = new UCProductCart(p, acc);
                    uc.cbSelected.Visible = false;
                    flpCartList.Controls.Add(uc);
                }
            }
        }

        private void UC_ApplyVoucherSelectedChanged(object sender, EventArgs e)
        {
            // Cast the sender object back to UCShipping to access its properties
            UCApplyVoucher selectedUC = sender as UCApplyVoucher;
            selectedUC.panelBorder.BorderColor = Color.Black;
            voucherValue = selectedUC.Voucher.Value;
            total = 0;
            total = subtotal < voucherValue ? 0 : subtotal - voucherValue;
            lblVoucherValue.Text = "-"+ voucherValue.ToString("N0") + " VND";
            lblPrice.Text = total.ToString("N0") + " VND";

            foreach (UCApplyVoucher uc in flpCartList.Controls)
            {
                // Check if the current UCShipping control is not the one that triggered the event
                if (uc != selectedUC)
                {
                    // Disable the radio button in the current UCShipping control
                    uc.panelBorder.BorderColor = Color.Silver;
                }
            }
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVoucher f = new FVoucher(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
