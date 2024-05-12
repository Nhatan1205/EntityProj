using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj.Forms
{
    public partial class UCVoucher : UserControl
    {
        Voucher voucher = new Voucher();
        Account account = new Account();
        VoucherDAO voucherDAO = new VoucherDAO();
        AccountDAO accountDAO = new AccountDAO();
        public UCVoucher()
        {
            InitializeComponent();
        }

        public UCVoucher(Voucher voucher, Account account)
        {
            InitializeComponent();
            this.voucher = voucher;
            lblVoucherName.Text = voucher.Name.ToString();
            lblValue.Text = "- " + voucher.Value.ToString() + " VND";
            lblBeginDay.Text = voucher.Beginday.ToString();
            lblEndDay.Text = voucher.Endday.ToString();
            Account seller = accountDAO.Retrieve(voucher.SellerId);
            lblSellerName.Text = seller.Name.ToString();    
            this.account = account;
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            if(voucher.SellerId == account.Id)
            {
                MessageBox.Show("You cannot collect your own voucher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                voucherDAO.collectVoucher(voucher.VoucherId, account.Id);
            }
        }
    }
}
