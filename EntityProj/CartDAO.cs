using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj
{
    internal class CartDAO
    {
        public void add(int buyerid, int productid)
        {
            try
            {
                using (var dbContext = new Window_ProjectContext())
                {
                    Cart cartItem = new Cart
                    {
                        BuyerID = buyerid,
                        ProductID = productid
                    };

                    dbContext.Carts.Add(cartItem);
                    dbContext.SaveChanges();

                    MessageBox.Show("Product added to cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool checkProductinCart(int buyerid, int productid)
        {
            using (var dbContext = new Window_ProjectContext())
            {
                return dbContext.Carts.Any(c => c.BuyerID == buyerid && c.ProductID == productid);
            }
        }

        public void delete(int buyerId, int productId)
        {
            try
            {
                using (var dbContext = new Window_ProjectContext())
                {
                    var cartItem = dbContext.Carts.FirstOrDefault(c => c.BuyerID == buyerId && c.ProductID == productId);
                    if (cartItem != null)
                    {
                        dbContext.Carts.Remove(cartItem);
                        dbContext.SaveChanges();
                        MessageBox.Show("Product removed from cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Product not found in cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Product> loadListWithAccountID(int accountID)
        {
            List<Product> productsInCart = new List<Product>();

            using (var dbContext = new Window_ProjectContext())
            {
                var cartItems = dbContext.Carts
                                         .Where(c => c.BuyerID == accountID)
                                         .Select(c => c.ProductID)
                                         .ToList();

                foreach (var productId in cartItems)
                {
                    // Assuming you have a Product entity in your DbContext
                    Product product = dbContext.Products.Find(productId);
                    if (product != null)
                    {
                        productsInCart.Add(product);
                    }
                }
            }

            return productsInCart;
        }

    }
}
