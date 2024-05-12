using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj
{
    internal class FavoriteDAO
    {
        public bool checkProductinFavorite(int buyerId, int productId)
        {
            using (var context = new Window_ProjectContext())
            {
                bool isProductInFavorite = context.Favorites
                                               .Any(f => f.BuyerID == buyerId && f.ProductID == productId);

                return isProductInFavorite;
            }
        }

        public void add(int buyerid, int productid)
        {
            try
            {
                using (var context = new Window_ProjectContext())
                {
                    Favorite newFavorite = new Favorite
                    {
                        BuyerID = buyerid,
                        ProductID = productid
                    };

                    context.Favorites.Add(newFavorite);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding favorite" + ex.Message);
            }

        }

        public void delete(int buyerId, int productId)
        {
            try
            {
                using (var context = new Window_ProjectContext())
                {
                    Favorite favoriteToDelete = context.Favorites.FirstOrDefault(f => f.BuyerID == buyerId && f.ProductID == productId);

                    if (favoriteToDelete != null)
                    {
                        context.Favorites.Remove(favoriteToDelete);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting favorite" + ex.Message);
            }
        }

        public List<Product> loadListWithAccountID(int accountID)
        {
            try
            {
                List<Product> productList = new List<Product>();
                using (var dbContext = new Window_ProjectContext()) 
                {
                    var productIDs = dbContext.Favorites
                                              .Where(f => f.BuyerID == accountID)
                                              .Select(f => f.ProductID)
                                              .ToList();

                    productList = dbContext.Products
                                          .Where(p => productIDs.Contains(p.ID))
                                          .ToList();
                }

                return productList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading products for account ID {accountID}: {ex.Message}");
                return new List<Product>(); 
            }
        }
    }
}
