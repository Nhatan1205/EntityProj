using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj.Forms
{
    public partial class FMoney : Form
    {
        private Account acc;
        private double money = 0;
        private AccountDAO accountDAO = new AccountDAO();
        public FMoney()
        {
            InitializeComponent();
            containerMenu.Visible = false;
        }

        public FMoney(Account acc)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            this.acc = accountDAO.Retrieve(acc.Id);
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            double.TryParse(txtMoney.Text, out double money);
            if (txtPassword.Text == "" || txtMoney.Text == "")
            {
                MessageBox.Show("You have to fill all information");
            } 
            else if (money < 0)
            {
                MessageBox.Show("Invalid money");
            } 
            else if (txtPassword.Text != acc.Password)
            {
                MessageBox.Show("Wrong Password");
            } 
            else {
                acc.Money += money;
                accountDAO.update(acc);
                MessageBox.Show("Recharge Sucessfull");
            }
            txtPassword.Text = "";
            txtMoney.Text = "";
            FMoney_Load(sender, e);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double.TryParse(txtMoney.Text, out double money);
            if (txtPassword.Text == "" || txtMoney.Text == "")
            {
                MessageBox.Show("You have to fill all information");
            }
            else if (money < 0)
            {
                MessageBox.Show("Invalid money");
            }
            else if (txtPassword.Text != acc.Password)
            {
                MessageBox.Show("Wrong Password");
            }
            else if (money > acc.Money)
            {
                MessageBox.Show("You do not have enough money to withdraw");
            }
            else
            {
                acc.Money -= money;
                accountDAO.update(acc);
                MessageBox.Show("Withdraw Sucessfull");
            }
            txtPassword.Text = "";
            txtMoney.Text = "";
            FMoney_Load(sender, e);
        }

        private void FMoney_Load(object sender, EventArgs e)
        {

            lblTotalMoney.Text = (acc.Money > 0) ? acc.Money.ToString("N0") + " VND" : "N/A";
            lblName.Text = acc.Name;
            if (acc.Avatar != null && acc.Avatar.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(acc.Avatar))
                {
                    // Attempt to create Image object
                    try
                    {
                        pbAvatar.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
            //Menu
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

        private void btn50_Click(object sender, EventArgs e)
        {
            money += 50000;
            txtMoney.Text = money.ToString();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            money += 100000;
            txtMoney.Text = money.ToString();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            money += 200000;
            txtMoney.Text = money.ToString();
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            money += 500000;
            txtMoney.Text = money.ToString();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCart f = new FCart(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnPostProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSellDetail f = new FSellDetail(acc);
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

        private void pbLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
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
