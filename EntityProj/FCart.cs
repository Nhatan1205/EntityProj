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
    public partial class FCart : Form
    {
        private AccountDAO accountDAO = new AccountDAO();
        private CartDAO cartDAO = new CartDAO();
        private Account account = new Account();
        private List<Product> products = new List<Product>();
        private List<Product> productChosen = new List<Product>();
        private VoucherDAO voucherDAO = new VoucherDAO();

        public FCart()
        {
            InitializeComponent();
            containerMenu.Visible = false;
        }

        public FCart(Account acc)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            account = acc;
            lblTotalMoney.Text = "0" + " VND";
            lblNoOfItems.Text = "0";
        }

        private void FCart_Load(object sender, EventArgs e)
        {
            products = cartDAO.loadListWithAccountID(account.Id);
            foreach (var pd in products)
            {
                if (pd.BuyerID == 0)
                {
                    UCProductCart uc = new UCProductCart(pd, account);
                    uc.SelectedChanged += UC_SelectedChanged;
                    uc.DeleteClicked += UC_DeleteClicked;
                    flpCartList.Controls.Add(uc);
                } else
                {
                    cartDAO.delete(account.Id, pd.Id);
                }
            }
            //menu
            lblMenuAccountName.Text = account.Name;
            ratingMenuAccount.Value = account.AvgRating;
            convertByte(pbMenuAvatar, account.Avatar);
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
        private void SelectProduct()
        {
            foreach (Control control in flpCartList.Controls)
            {
                if (control is UCProductCart uc)
                {
                    if (uc.cbSelected.Checked)
                    {
                        productChosen.Add(uc.Pd);
                    }
                }
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            SelectProduct();
            if (productChosen.Count > 0)
            {
                this.Hide();
                FDelivery f = new FDelivery(account, productChosen);
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCart f = new FCart(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnPostProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSellDetail f = new FSellDetail(account);
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
            FTrackOrder f = new FTrackOrder(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FProductManagement f = new FProductManagement(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSavedProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSaveList f = new FSaveList(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnOrderAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOrderAnalysis f = new FOrderAnalysis(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FInformation f = new FInformation(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMoney f = new FMoney(account);
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

        private void pbLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        // Event handler for DeleteClicked event in UCProductCart
        private void UC_DeleteClicked(object sender, EventArgs e)
        {
            // Clear all controls from flpCartList
            flpCartList.Controls.Clear();
            // Reload the form
            UpdateTotal();
            FCart_Load(sender, e);
        }

        // Event handler for SelectedChanged event in UCProductCart
        private void UC_SelectedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        // Method to update total number of items and total money
        private void UpdateTotal()
        {
            double totalMoney = 0;
            int itemCount = 0;

            // Iterate through each UCProductCart
            foreach (Control control in flpCartList.Controls)
            {
                if (control is UCProductCart uc)
                {
                    // Check if the product is selected
                    if (uc.cbSelected.Checked)
                    {
                        itemCount++;
                        totalMoney += uc.Pd.SalePrice; // Assuming Product has a property 'Price'
                    }
                }
            }

            // Update labels
            lblNoOfItems.Text = itemCount.ToString();
            lblTotalMoney.Text = totalMoney.ToString("N0") + " VND";
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVoucher f = new FVoucher(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
