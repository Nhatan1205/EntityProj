using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
