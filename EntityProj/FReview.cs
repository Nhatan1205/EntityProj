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
    public partial class FReview : Form
    {
        private ImageDAO imageDAO = new ImageDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private ProductDAO productDAO = new ProductDAO();
        private Product product;
        private Account Seller = new Account();
        private RatingDAO ratingDAO = new RatingDAO();
        private List<Rating> ratingList = new List<Rating>();
        public FReview()
        {
            InitializeComponent();
            containerMenu.Visible = false;
            btnWatchReview.Visible = false;
        }
        public FReview(Account acc, Product pd)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            btnWatchReview.Visible = false;
            this.account = acc;
            this.product = pd;
            Seller = new Account(pd.SellerID);
            ratingList = ratingDAO.LoadList(Seller);
        }

        private void FReview_Load(object sender, EventArgs e)
        {
            foreach (Rating rating in ratingList)
            {
                UCReview uc = new UCReview(product, account, rating);
                flpRating.Controls.Add(uc);
            }
            lblNameSeller.Text = Seller.Name;
            convertByte(pbAvatarSeller, Seller.Avatar);
            lblStar.Text = Seller.AvgRating.ToString();
            rsStar.Value = Seller.AvgRating;
            lblArea.Text = "Area: " + Seller.Address;
            lblPhone.Text = "Contact Phone: " + Seller.Phone;
            DataTable dt = new DataTable();
            dt = ratingDAO.load(Seller);
            lblNumberRatings.Text = dt.Rows.Count.ToString() + " ratings";
            List<Product> listpd = new List<Product>();
            listpd = productDAO.LoadListWithCondition("", Seller.Id);
            lblNumberofproducts.Text = "Products: " + listpd.Count.ToString();
            int completed = 0;
            foreach (Product pd in listpd)
            {
                if (pd.OrderCondition == (int)ordercondition.Completed)
                {
                    completed++;
                }
            }
            lblSold.Text = "Sold: " + completed.ToString();

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

        private void pbLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
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

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVoucher f = new FVoucher(account);
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

        private void ratingMenuAccount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UCProduct_ProductDoubleClick(object sender, EventArgs e)
        {
            // Hide the current form (FBuy)
            this.Hide();
            // Open the FBuyDetail form
            FBuyDetail fBuyDetail = new FBuyDetail((sender as UCProduct).Product, account);
            fBuyDetail.Closed += (s, args) => this.Close();
            fBuyDetail.Show();
        }


        private void btnWatchReview_Click(object sender, EventArgs e)
        {
            btnWatchReview.Visible = false;
            btnWatchProducts.Visible = true;
            flpRating.Controls.Clear();
            foreach (Rating rating in ratingList)
            {
                UCReview uc = new UCReview(product, account, rating);
                flpRating.Controls.Add(uc);
            }
        }

        private void btnWatchProducts_Click_1(object sender, EventArgs e)
        {
            btnWatchProducts.Visible = false;
            btnWatchReview.Visible = true;
            flpRating.Controls.Clear();
            List<Product> products = productDAO.LoadListWithCondition("", Seller.Id);
            foreach (var pd in products)
            {
                if (pd.BuyerID <= 0 && pd.OrderCondition <= (int)ordercondition.Displaying)
                {
                    UCProduct uc = new UCProduct(pd, account);
                    uc.ProductDoubleClick += UCProduct_ProductDoubleClick;
                    flpRating.Controls.Add(uc);
                }
            }
        }
    }
}