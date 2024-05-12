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

    public partial class FProductManagement : Form
    {
        private ProductDAO productDAO = new ProductDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();   
        private CancelInfoDAO cancelInfoDAO = new CancelInfoDAO();
        public FProductManagement()
        {
            InitializeComponent();
            containerMenu.Visible = false;
        }

        public FProductManagement(Account acc)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            account = acc;
        }

        private void FProductManagement_Load(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadList();
            lblSellerName.Text = account.Name;
            //account = accountDAO.Retrieve(account.Id);
            lblBalance.Text = account.Money.ToString("N0") + " VND";
            foreach (var pd in products)
            {
                if(pd.SellerID == account.Id)
                {
                    UCProductSell uc = new UCProductSell(pd, account, pd.OrderCondition > (int)ordercondition.Displaying);
                    uc.btnCancel.Visible = false;
                    if (pd.OrderCondition <= (int)ordercondition.Displaying)
                    {
                        tpDisplay.Controls.Add(uc);
                        uc.btnCancel.Visible = true;
                    }
                    else if(pd.OrderCondition == (int)ordercondition.WaitforConfirmation)
                    {
                        tpWaitConfirm.Controls.Add(uc); 
                    }
                    else if(pd.OrderCondition == (int)ordercondition.Completed)
                    {
                        tpCompleted.Controls.Add(uc);
                    }
                    else if(pd.OrderCondition == (int)ordercondition.hidden)
                    {
                        tpHidden.Controls.Add(uc);
                    }
                }
            }
            //Menu
            convertByte(pBSellerAvatar, account.Avatar);
            lblMenuAccountName.Text = account.Name;
            ratingMenuAccount.Value = account.AvgRating;
            convertByte(pbMenuAvatar, account.Avatar);
            // Cancel Notification
            List<CancelInfo> list = cancelInfoDAO.loadList(account.Id);
            foreach (CancelInfo ci in list)
            {
                UCProductCancel uc = new UCProductCancel(ci);
                flpCancelledProducts.Controls.Add(uc);
            }
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            tpCompleted.Controls.Clear();
            tpDisplay.Controls.Clear();
            tpHidden.Controls.Clear();
            tpWaitConfirm.Controls.Clear();
            flpCancelledProducts.Controls.Clear();
            FProductManagement_Load(sender, e);
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

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            this.Hide();
            FVoucher f = new FVoucher(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void flpCancelledProducts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
