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
    public partial class FForgetPassword : Form
    {
        private string emailsubmitted;
        private string captchaText;
        private Font captchaFont;
        int step = 0;
        public FForgetPassword()
        {
            InitializeComponent();
            Control[] controlsToRemove = { btnBack, lblTitle3, ptCapcha, ptRefresh, txtCapcha, btnSubmit, lblResetPw, txtNewPw, btnReset };
            Control[] controlsToAdd = { };
            AddRemoveControl(controlsToRemove, controlsToAdd);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (step == 1)
            {
                Control[] controlsToRemove = { btnBack, lblTitle3, ptCapcha, ptRefresh, txtCapcha, btnSubmit };
                Control[] controlsToAdd = { btnContinue, lblTitle1, lblTitle2, txtEmail };
                AddRemoveControl(controlsToRemove, controlsToAdd);
            }
            if(step == 2)
            {
                Control[] controlsToRemove = { lblResetPw, txtNewPw, btnReset };
                Control[] controlsToAdd = {  lblTitle3, ptCapcha, ptRefresh, txtCapcha, btnSubmit };
                AddRemoveControl(controlsToRemove, controlsToAdd);
            }  
            step--;  
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            emailsubmitted = txtEmail.Text.Trim();
            if(!string.IsNullOrEmpty(emailsubmitted))
            {
                step = 1;
                Control[] controlsToRemove = { btnContinue, lblTitle1, lblTitle2, txtEmail };
                Control[] controlsToAdd = { btnBack, lblTitle3, ptCapcha, ptRefresh, txtCapcha, btnSubmit };
                AddRemoveControl(controlsToRemove, controlsToAdd);
            }
            else
            {
                MessageBox.Show("Email has not been filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void GenerateCaptcha()
        {
            captchaText = GenerateRandomString(6);
            captchaFont = new Font("Roboto", 20, FontStyle.Bold);
        }
        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void ptCapcha_Paint(object sender, PaintEventArgs e)
        {
            GenerateCaptcha();
            // Draw captcha text on the picture box
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawString(captchaText, captchaFont, Brushes.Black, 20, 20);
        }
        private void ptRefresh_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
            ptCapcha.Refresh();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string capchasubmitted = txtCapcha.Text.Trim();
            if(capchasubmitted == captchaText)
            {
                step = 2;
                Control[] controlsToRemove = { lblTitle3, ptCapcha, ptRefresh, txtCapcha, btnSubmit };
                Control[] controlsToAdd = { lblResetPw, txtNewPw, btnReset };
                AddRemoveControl(controlsToRemove, controlsToAdd);
            }
            else
            {
                MessageBox.Show("Do not match with the characters above", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void AddRemoveControl(Control[] controlsToRemove, Control[] controlsToAdd)
        {
            foreach (Control control in controlsToRemove)
            {
                this.Controls.Remove(control);
            }
            foreach (Control control in controlsToAdd)
            {
                this.Controls.Add(control);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string newpwsubmitted = txtNewPw.Text.Trim();
            AccountDAO accountDAO = new AccountDAO();
            accountDAO.ResetPassword(emailsubmitted, newpwsubmitted);

        }
    }
}
