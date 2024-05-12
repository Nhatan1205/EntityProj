using EntityProj.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj
{
    internal class CancelInfoDAO
    {
        public void add(int productID, int buyerID, string reason, string extraInfo)
        {
            try
            {
                using (var dbContext = new Window_ProjectContext())
                {
                    Cancel_Info cancelinfo = new Cancel_Info
                    {
                        BuyerID = buyerID,
                        ProductID = productID,
                        Reason = reason,
                        ExtraInfo = extraInfo
                    };

                    dbContext.Cancel_Info.Add(cancelinfo);
                    dbContext.SaveChanges();

                    MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Cancel_Info> LoadList(int sellerId)
        {
            using (var context = new Window_ProjectContext())
            {
                var cancelInfos = context.Cancel_Info
                     .Join(context.Products,
                           cancel => cancel.ProductID,
                           product => product.ID,
                           (cancel, product) => new { Cancel = cancel, Product = product })
                     .Where(joined => joined.Product.SellerID == sellerId)
                     .Select(joined => joined.Cancel)
                     .ToList();

                return cancelInfos;
            }
        }

        public void Delete(int id)
        {
            using (var dbContext = new Window_ProjectContext())
            {
                // Find the CancelInfo entity with the specified ID
                var cancelInfo = dbContext.Cancel_Info.Find(id);

                if (cancelInfo != null)
                {
                    // Remove the CancelInfo entity from the DbSet
                    dbContext.Cancel_Info.Remove(cancelInfo);

                    // Save changes to the database
                    dbContext.SaveChanges();
                }
                else
                {
                    // Handle case where no CancelInfo entity was found with the specified ID
                    MessageBox.Show($"CancelInfo with ID = {id} not found.");
                }
            }
        }


    }
}
