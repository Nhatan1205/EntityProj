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
    }
}
