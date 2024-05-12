using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
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
    }
}
