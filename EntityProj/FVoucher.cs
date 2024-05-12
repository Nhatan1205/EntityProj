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
    public partial class FVoucher : Form
    {
        Account account = new Account();
        VoucherDAO voucherDAO = new VoucherDAO();
        public FVoucher()
        {
            InitializeComponent();
        }

        public FVoucher(Account acc)
        {
            InitializeComponent();
            this.account = acc;
        }



        private void lblAddVoucher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FAddVoucher fAddVoucher = new FAddVoucher(account);
            fAddVoucher.ShowDialog();
        }

        private void FVoucher_Load(object sender, EventArgs e)
        {
            for (int i = flpVoucher.Controls.Count - 1; i >= 0; i--)
            {
                Control control = flpVoucher.Controls[i];
                if (control is UserControl)
                {
                    flpVoucher.Controls.Remove(control);
                    control.Dispose();
                }
            }
            containerMenu.Visible = false;
            List<Voucher> vouchers = voucherDAO.LoadList();
            foreach (var voucher in vouchers)
            {
                UCVoucher uc = new UCVoucher(voucher,account);
                //uc.SelectedChanged += UC_SelectedChanged;
                flpVoucher.Controls.Add(uc);
                
            }
            //Menu
            lblMenuAccountName.Text = account.Name;
            AccountExtension accE = new AccountExtension(account.ID);
            ratingMenuAccount.Value = accE.AvgRating;
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

        private void btnVoucher_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FVoucher f = new FVoucher(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void llbnLoad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FVoucher_Load(sender, e);
        }
    }
}
