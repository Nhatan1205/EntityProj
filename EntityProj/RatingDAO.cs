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
