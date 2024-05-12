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
    public partial class UCShipping : UserControl
    {
        ShippingInfo shipping = new ShippingInfo();

        public ShippingInfo Shipping { get => shipping; set => shipping = value; }

        public event EventHandler<EventArgs> SelectedChanged;

        public UCShipping()
        {
            InitializeComponent();
            SetEventForAllControls(this);

        }

        public UCShipping(ShippingInfo ship)
        {
            InitializeComponent();
            SetEventForAllControls(this);
            shipping = ship;
            lblRecipientName.Text = shipping.RecipientName.ToString();
            lblAddress.Text = shipping.Address.ToString();
            lblPhoneNo.Text = shipping.PhoneNumber.ToString();
        }

        

        private void SetEventForAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += UCShipping_Click;
                if (control.HasChildren)
                {
                    SetEventForAllControls(control);
                }
            }

        }

        private void UCShipping_Click(object sender, EventArgs e)
        {
            SelectedChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
