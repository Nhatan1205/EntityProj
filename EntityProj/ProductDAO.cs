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
                    .Where(p => p.Type == type && p.ID != productId)
                    .ToList();

                // Convert the list of Product entities to a list of Product objects
                List<Product> productList = similarProducts
                    .Select(p => new Product
                    {
                        ID = p.ID,
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
                var productEntity = context.Products.Find(product.ID);
                if (productEntity != null)
                {
                    productEntity.BuyerID = 0;
                    context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException($"Product with ID {product.ID} not found.");
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

        public DataTable LoadRegularCustomer(int id, DateTime start, DateTime end)
        {
            List<Product> list = LoadListCompletedProduct(id, start, end);
            List<RegularCustomer> rs = new List<RegularCustomer>();
            foreach (Product pd in list)
            {
                bool find = false;
                int index = -1;
                foreach (RegularCustomer rc in rs)
                {
                    index++;
                    if (rc.Id == pd.BuyerID)
                    {
                        find = true;
                        break;
                    }
                }
                if (find)
                {
                    rs[index].Times++;
                    rs[index].Totalpurchase += (double)pd.SalePrice;
                }
                else
                {
                    rs.Add(new RegularCustomer(pd.BuyerID.Value, pd));
                }
            }
            // Create DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Number of product purchases", typeof(int));
            dt.Columns.Add("Total Purchases", typeof(string));

            foreach (RegularCustomer customer in rs)
            {
                dt.Rows.Add(customer.Name, customer.Times, string.Format(customer.Totalpurchase.ToString("N0") + " VND"));
            }

            return dt;
        }

        public List<Product> LoadListCompletedProduct(int sellerId, DateTime start, DateTime end)
        {
            using (var context = new Window_ProjectContext())
            {
                var productList = context.Products
                .Where(p => p.SellerID == sellerId &&
                            p.OrderCondition == 2 &&
                            p.CompleteTime >= start &&
                            p.CompleteTime <= end)
                .ToList();

            return productList;
            }
        }

        public List<Product> LoadProductWithinPeriod(int sellerId, DateTime start, DateTime end)
        {
            using (var context = new Window_ProjectContext())
            {
                // Query products within the specified date range
                var productList = context.Products
                    .Where(p => p.SellerID == sellerId &&
                                p.CompleteTime >= start &&
                                p.CompleteTime <= end)
                    .ToList();

                return productList;
            }
        }

        public Product Retrieve(int id)
        {
            using (var context = new Window_ProjectContext())
            {
                // Retrieve a single Product entity by its ID using Entity Framework
                var product = context.Products.FirstOrDefault(p => p.ID == id);

                return product; // Returns the Product entity or null if not found
            }
        }
    }
}
