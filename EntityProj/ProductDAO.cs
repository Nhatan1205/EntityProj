using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Data.Entity.SqlServer;
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
                // Use SqlFunctions.PatIndex to perform pattern matching for comparison
                var recommendedProducts = context.Products
                    .Where(p => SqlFunctions.PatIndex(type, p.Type) > 0)
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

        public void Add(Product pd)
        {
            using (var dbContext = new Window_ProjectContext())
            {
                dbContext.Products.Add(pd);
                dbContext.SaveChanges();
            }
        }

        public Product GetLastProduct()
        {
            using (var dbContext = new Window_ProjectContext())
            {
                // Query using Entity Framework to get the last product based on Id in descending order
                var lastProduct = dbContext.Products
                                           .OrderByDescending(p => p.ID)
                                           .FirstOrDefault();

                return lastProduct;
            }
        }

        public List<Product> LoadListWithBuyerID(int buyerId)
        {
            using (var dbContext = new Window_ProjectContext())
            {
                // Query using Entity Framework to get products with the specified BuyerID
                var products = dbContext.Products
                                        .Where(p => p.BuyerID == buyerId)
                                        .ToList();

                return products;
            }
        }

        public void Delete(Product product)
        {
            using (var dbContext = new Window_ProjectContext())
            {
                // Attach the product to the DbContext if not already tracked
                dbContext.Products.Attach(product);

                // Remove the product from the Products DbSet
                dbContext.Products.Remove(product);

                // Save changes to the database
                dbContext.SaveChanges();
            }
        }

        public void UpdateOrderCondition(Product product)
        {
            using (var dbContext = new Window_ProjectContext())
            {
                // Retrieve the product from the database by its ID
                var existingProduct = dbContext.Products.Find(product.ID);

                if (existingProduct != null)
                {
                    // Update the BuyerID and OrderCondition of the existing product
                    existingProduct.BuyerID = product.BuyerID;
                    existingProduct.OrderCondition = product.OrderCondition;

                    // Set CompleteTime if OrderCondition is 'Completed'
                    if (product.OrderCondition == (int)ordercondition.Completed)
                    {
                        existingProduct.CompleteTime = DateTime.Now;
                    }
                    else
                    {
                        existingProduct.CompleteTime = null; // Clear CompleteTime if not 'Completed'
                    }

                    // Save changes to the database
                    dbContext.SaveChanges();
                }
                else
                {
                    // Handle case where no product was found with the specified ID
                    MessageBox.Show($"Product with ID = {product.ID} not found.");
                }
            }
        }

        /*
        public DataTable ProfitEveryHour(int id, DateTime targetDate)
        {
            DataTable dt = new DataTable();

            // Define columns for the DataTable
            dt.Columns.Add("HourNumber", typeof(int));
            dt.Columns.Add("TotalEarnings", typeof(decimal));

            // Initialize the list of hourly profits
            List<object[]> hourlyProfits = new List<object[]>();

            // Establish database connection and execute query
            using (var db = new Window_ProjectContext())
            {
                var query =
                    from hour in Enumerable.Range(1, 24)
                    join product in db.Products
                        on new { HourNumber = hour, Date = targetDate.Date, SellerID = id }
                        equals new { HourNumber = product.CompleteTime.Value.Hour, Date = product.CompleteTime.Value.Date, SellerID = product.SellerID }
                        into hourProducts
                    from p in hourProducts.DefaultIfEmpty()
                    group p by hour into g
                    select new
                    {
                        HourNumber = g.Key,
                        TotalEarnings = g.Sum(p => p != null ? p.SalePrice : 0)
                    };

                foreach (var result in query)
                {
                    hourlyProfits.Add(new object[] { result.HourNumber, result.TotalEarnings });
                }
            }

            // Populate the DataTable with the hourly profit data
            foreach (var profit in hourlyProfits)
            {
                dt.Rows.Add(profit);
            }

            return dt;
        }
        */


    }
}
