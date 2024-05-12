using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

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
    }
}
