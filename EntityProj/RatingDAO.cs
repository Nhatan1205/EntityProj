using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProj
{
    internal class RatingDAO
    {
        public void Add(Rating rt, Product pd)
        {
            using (var context = new Window_ProjectContext())
            {
                // Attach the Product entity to the context if it's not already tracked
                if (!context.Products.Local.Any(p => p.ID == pd.ID))
                {
                    context.Products.Attach(pd);
                }

                // Create a new Rating entity and set its properties
                var newRating = new Rating
                {
                    Comment = rt.Comment,
                    Star = rt.Star,
                    SellerID = pd.SellerID.Value,
                    ProductID = pd.ID,
                    BuyerID = pd.BuyerID
                };

                // Add the new Rating entity to the context and save changes to the database
                context.Ratings.Add(newRating);
                context.SaveChanges();
            }
        }
        public DataTable Load(Account acc)
        {
            DataTable dataTable = new DataTable();

            using (var dbContext = new Window_ProjectContext())
            {
                // Query using Entity Framework to retrieve ratings for the account
                var ratings = dbContext.Ratings
                                      .Where(r => r.SellerID == acc.ID)
                                      .ToList();

                // Convert the list of ratings to a DataTable
                dataTable.Columns.Add("RatingId", typeof(int));
                dataTable.Columns.Add("SellerID", typeof(int));

                foreach (var rating in ratings)
                {
                    dataTable.Rows.Add(rating.RatingID, rating.SellerID);
                }
            }

            return dataTable;
        }

        public List<Rating> LoadList(Account acc)
        {
            using (var dbContext = new Window_ProjectContext())
            {
                // Query using Entity Framework LINQ to retrieve ratings for the account
                var ratings = dbContext.Ratings
                                      .Where(r => r.SellerID == acc.ID)
                                      .ToList();

                return ratings;
            }
        }
    }
}
