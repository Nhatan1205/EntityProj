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
            /*
            List<Shipping> shippings = shippingDAO.LoadList();
            foreach (var ship in shippings)
            {
                if (account.Id == ship.AccountId)
                {
                    UCShipping uc = new UCShipping(ship);
                    uc.SelectedChanged += UC_SelectedChanged;
                    flpAddresses.Controls.Add(uc);
                }
            }
            */
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Shipping shipping = new Shipping(account.Id, txtRecipientName.Text, txtPhoneNo.Text, txtAddress.Text);
            shippingDAO.add(shipping);
            MessageBox.Show("Operation was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
private void UC_SelectedChanged(object sender, EventArgs e)
{
// Cast the sender object back to UCShipping to access its properties
UCShipping selectedUC = sender as UCShipping;
selectedUC.panelBorder.BorderColor = Color.Black;


// Iterate through each UCShipping control in the flow layout panel
foreach (UCShipping uc in flpAddresses.Controls)
{
// Check if the current UCShipping control is not the one that triggered the event
if (uc != selectedUC)
{
  // Disable the radio button in the current UCShipping control
  uc.panelBorder.BorderColor = Color.Silver;
}
}
}
*/

    }
}
