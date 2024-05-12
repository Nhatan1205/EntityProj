using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
    }
}
