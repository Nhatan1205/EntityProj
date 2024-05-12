using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj.Forms
{
    public partial class UCApplyVoucher : UserControl
    {
        Voucher voucher = new Voucher();
        Account account = new Account();
        VoucherDAO voucherDAO = new VoucherDAO();

        public Voucher Voucher { get => voucher; set => voucher = value; }

        public event EventHandler<EventArgs> SelectedChanged;
        public UCApplyVoucher()
        {
            InitializeComponent();
            SetEventForAllControls(this);
        }

        public UCApplyVoucher(Voucher voucher,Account acc)
        {
            InitializeComponent();
            SetEventForAllControls(this);
            this.voucher = voucher;
            lblVoucherName.Text = voucher.Name.ToString();
            lblValue.Text = "- " + voucher.Value.ToString() + " VND";
            lblBeginDay.Text = voucher.BeginDay.ToString();
            lblEndDay.Text = voucher.EndDay.ToString();
            account = acc;
        }

        private void SetEventForAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += UCApplyVoucher_Click;
                if (control.HasChildren)
                {
                    SetEventForAllControls(control);
                }
            }

        }

        private void UCApplyVoucher_Click(object sender, EventArgs e)
        {
            SelectedChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
