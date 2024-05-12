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
    public partial class FSignup : Form
    {
        AccountDAO accountDAO = new AccountDAO();
        public FSignup()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            using(var db = new Window_ProjectContext())
            {
                var acc = new Account
                {
                    Name = txtUsername.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                };
                db.Accounts.Add(acc);
                db.SaveChanges();
                MessageBox.Show("Account's created successfully", "Signup", MessageBoxButtons.OK);
            }
        }

        private void btnSignin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FSignin f = new FSignin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
