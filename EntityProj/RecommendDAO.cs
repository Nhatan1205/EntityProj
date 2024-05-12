using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProj
{
    internal class RecommendDAO
    {
        public List<string> GetTopThreeRecommendedTypesByBuyerID(int buyerID)
        {
            using (var context = new Window_ProjectContext())
            {
                // Lấy danh sách các loại (Type) được đề xuất cho một BuyerID cụ thể
                var topThreeTypes = context.Recommends
                                            .Where(r => r.BuyerID == buyerID)
                                            .OrderByDescending(r => r.ViewCount)
                                            .Take(3)
                                            .Select(r => r.Type)
                                            .ToList();

                return topThreeTypes;
            }
        }

        public void Update(string type, int buyerID)
        {
            using (var dbContext = new Window_ProjectContext())
            {
                // Check if a recommendation already exists for the given buyerID and type
                var existingRecommendation = dbContext.Recommends
                                                      .FirstOrDefault(r => r.BuyerID == buyerID && r.Type == type);

                if (existingRecommendation != null)
                {
                    // If the recommendation exists, update the ViewCount
                    existingRecommendation.ViewCount++;
                }
                else
                {
                    // If the recommendation doesn't exist, create a new recommendation
                    var newRecommendation = new Recommend
                    {
                        BuyerID = buyerID,
                        Type = type,
                        ViewCount = 1 // Start with ViewCount = 1 for new recommendations
                    };

                    // Add the new recommendation to the DbSet
                    dbContext.Recommends.Add(newRecommendation);
                }

                // Save changes to the database
                dbContext.SaveChanges();
            }
        }

    }
}
