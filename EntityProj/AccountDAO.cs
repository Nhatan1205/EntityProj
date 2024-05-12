using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Data.Entity.Migrations;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace EntityProj
{
    internal class AccountDAO
    {
        public Account CheckAccount(Account account)
        {
            using (var context = new Window_ProjectContext())
            {
                var matchedAccount = context.Accounts.FirstOrDefault(a => a.Email == account.Email && a.Password == account.Password);
                if (matchedAccount != null)
                {
                    return matchedAccount;
                }
                else
                {
                    return null;
                }
            }
        }

        public Account Retrieve(int id)
        {
            using (var context = new Window_ProjectContext())
            {
                var matchedAccount = context.Accounts.FirstOrDefault(a => a.ID == id);
                if (matchedAccount != null)
                {
                    return matchedAccount;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Update(Account account)
        {
            using (var context = new Window_ProjectContext())
            {
                context.Accounts.AddOrUpdate(account);
            }
            AddOrUpdateAvatar(account, account.Avatar);
        }

        public void AddOrUpdateAvatar(Account account, byte[] imgData)
        {
            using (var context = new Window_ProjectContext())
            {
                if (imgData != null)
                {
                    var existingAccount = context.Accounts.Find(account.ID);
                    if (existingAccount != null)
                    {
                        existingAccount.Avatar = imgData;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new ArgumentException("Account not found.");
                    }
                }
            }
        }

        public void ResetPassword(string emailSubmitted, string pwSubmitted)
        {
            if(CheckEmailExisted(emailSubmitted))
            {
                using (var context = new Window_ProjectContext())
                {
                    var account = context.Accounts.FirstOrDefault(a => a.Email == emailSubmitted);
                    if (account != null)
                    {
                        account.Password = pwSubmitted;
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Email has not been found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public bool CheckEmailExisted(string email)
        {
            using (var context = new Window_ProjectContext())
            {
                return context.Accounts.Any(a => a.Email == email);

            }
        }
    }
}
