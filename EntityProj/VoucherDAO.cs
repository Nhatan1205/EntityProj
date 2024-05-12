using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj
{
    internal class VoucherDAO
    {
        public List<int> GetVoucherIDsByBuyerID(int buyerID)
        {
            using (var context = new Window_ProjectContext())
            {
                return context.Voucher_Account
                 .Where(va => va.BuyerID.Value == buyerID)
                 .Select(va => va.VoucherID.Value)
                 .ToList();
            }
        }

        public Voucher GetVoucher(int id)
        {
            using (var context = new Window_ProjectContext())
            {
                return context.Vouchers.FirstOrDefault(v => v.VoucherID == id);
            }
        }

        public List<Voucher> LoadList()
        {
            using (var dbContext = new Window_ProjectContext())
            {
                // Query using Entity Framework to get all vouchers
                var vouchers = dbContext.Vouchers.ToList();

                return vouchers;
            }
        }

        public void CollectVoucher(int voucherId, int buyerId)
        {
            using (var dbContext = new Window_ProjectContext())
            {
                // Check if the (VoucherId, BuyerId) pair already exists in Voucher_Account
                bool exists = dbContext.Voucher_Account.Any(va => va.VoucherID == voucherId && va.BuyerID == buyerId);

                if (exists)
                {
                    MessageBox.Show("This voucher has already been collected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop further execution
                }

                // If the pair does not exist, create a new VoucherAccount record
                var newVoucherAccount = new Voucher_Account
                {
                    VoucherID = voucherId,
                    BuyerID = buyerId
                };

                // Add the new VoucherAccount record to the DbSet
                dbContext.Voucher_Account.Add(newVoucherAccount);

                // Save changes to the database
                dbContext.SaveChanges();

                MessageBox.Show("Voucher successfully collected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
