using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj.Forms
{
    public partial class FShipping : Form
    {
        Account account = new Account();
        ShippingDAO shippingDAO = new ShippingDAO();
        public FShipping()
        {
            InitializeComponent();
        }

        public FShipping(Account acc)
        {
            this.account = acc;
            InitializeComponent();

        }

        private void FShipping_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            shippingDAO.add(account.ID, txtRecipientName.Text, txtPhoneNo.Text, txtAddress.Text);
            MessageBox.Show("Operation was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
