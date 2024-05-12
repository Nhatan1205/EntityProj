using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProj
{
    internal class ProductDAO
    {
        public List<Product> LoadList()
        {
            using (var context = new Window_ProjectContext())
            {
                // Lấy danh sách sản phẩm đã được sắp xếp theo ViewCount giảm dần
                var products = context.Products
                                      .OrderByDescending(p => p.ViewCount)
                                      .ToList();

                return products;
            }
        }

        public List<Product> LoadRecommendList(string type)
        {
            using (var context = new Window_ProjectContext())
            {
                // Lấy danh sách sản phẩm được đề xuất (top 3) cho một loại (type) cụ thể
                var recommendedProducts = context.Products
                                                   .Where(p => p.Type == type)
                                                   .OrderByDescending(p => p.ViewCount)
                                                   .Take(3)
                                                   .ToList();

                return recommendedProducts;
            }
        }

        public void Update(Product pd, bool check)
        {
            using (var context = new Window_ProjectContext())
            {
                context.Products.AddOrUpdate(pd);
            }
        }

        public void Update(Product product)
        {
            using (var context = new Window_ProjectContext())
            {
                context.Products.AddOrUpdate(product);
            }
        }

        public List<Product> LoadSimilarProducts(int productId, string type)
        {
            using (var context = new Window_ProjectContext())
            {
                // Use LINQ to query products similar to the specified type and exclude the specified productId
                var similarProducts = context.Products
                    .Where(p => p.Type == type && p.Id != productId)
                    .ToList();

                // Convert the list of Product entities to a list of Product objects
                List<Product> productList = similarProducts
                    .Select(p => new Product
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Type = p.Type,
                        // Assign other properties as needed
                    })
                    .ToList();

                return productList;
            }
        }

        public void DeleteBuyerID(Product product)
        {
            using (var context = new Window_ProjectContext())
            {
                var productEntity = context.Products.Find(product.Id);
                if (productEntity != null)
                {
                    productEntity.BuyerID = 0;
                    context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException($"Product with ID {product.Id} not found.");
                }
            }
        }

        public List<Product> LoadListWithCondition(string name, int sellerId)
        {
            using (var context = new Window_ProjectContext())
            {
                IQueryable<Product> query = context.Products.Where(p => p.SellerID == sellerId);

                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(p => p.Name.Contains(name));
                }

                return query.ToList();
            }
        }

        public DataTable LoadRegularCustomer(int sellerId, DateTime start, DateTime end)
        {
            using (var context = new Window_ProjectContext())
            {
                // Query completed orders within the specified date range
                var completedOrders = context.Orders
                    .Where(o => o.SellerID == sellerId && o.OrderDate >= start && o.OrderDate <= end && o.Status == "Completed")
                    .ToList();

                // Aggregate regular customer data
                var regularCustomers = completedOrders
                    .GroupBy(o => o.BuyerID)
                    .Select(g => new RegularCustomer
                    {
                        BuyerID = g.Key,
                        Name = g.First().Buyer.Name, // Assuming Buyer is a navigation property in Order referencing the Account table
                        Times = g.Count(),
                        TotalPurchase = g.Sum(o => o.TotalPrice)
                    })
                    .ToList();

                // Create DataTable to hold the aggregated data
                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Number of Product Purchases", typeof(int));
                dt.Columns.Add("Total Purchases", typeof(string));

                // Populate DataTable with aggregated data
                foreach (var customer in regularCustomers)
                {
                    dt.Rows.Add(customer.Name, customer.Times, $"{customer.TotalPurchase:N0} VND");
                }

                return dt;
            }
        }
    }
}
