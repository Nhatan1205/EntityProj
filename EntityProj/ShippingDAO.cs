using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EntityProj
{
    internal class ShippingDAO
    {
        public ShippingInfo GetShipping(int id)
        {
            using (var context = new Window_ProjectContext())
            {
                return context.ShippingInfoes.FirstOrDefault(s => s.ID == id);
            }
        }

        public List<ShippingInfo> LoadList()
        {
            using (var context = new Window_ProjectContext())
            {
                return context.ShippingInfoes.ToList();
            }
        }

        public void add(int accountid, string RecipientName, string PhoneNumber, string Address)
        {
            using (var db = new Window_ProjectContext())
            {
                var shipping = new ShippingInfo
                {
                    AccountID = accountid,
                    RecipientName = RecipientName,
                    PhoneNumber = PhoneNumber,
                    Address = Address
                };
                db.ShippingInfoes.Add(shipping);
                db.SaveChanges();
            }
        }
    }
}
