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
    public partial class UCProductCondition : UserControl
    {
        public UCProductCondition()
        {
            InitializeComponent();
        }

        private void btnNextState_MouseEnter(object sender, EventArgs e)
        {
            btnNextState.BackColor = Color.FromArgb(239, 250, 253);
            btnNextState.ForeColor = Color.FromArgb(54, 50, 132);
        }

        private void btnNextState_MouseLeave(object sender, EventArgs e)
        {
            btnNextState.BackColor = Color.FromArgb(54, 50, 132);
            btnNextState.ForeColor = Color.FromArgb(239, 250, 253);
        }
    }
}
