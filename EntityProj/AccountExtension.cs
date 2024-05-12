using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityProj
{
    internal class AccountExtension
    {
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private RatingDAO ratingDAO = new RatingDAO();
        private List<Rating> ratingList = new List<Rating>();
        private float avgRating;

        public AccountExtension() { }   

        /*
        public AccountExtension(Account account)
        {
            this.account = account;
        }
        */

        public List<Rating> RatingList { get => ratingList; set => ratingList = value; }
        public float AvgRating { get => avgRating; set => avgRating = value; }

        public AccountExtension(int id)
        {
            Account acc = accountDAO.Retrieve(id);
            if (acc != null)
            {
                ratingList = ratingDAO.LoadList(acc);
                avgRating = AverageStar();
            }
        }

        public float AverageStar()
        {
            float avg = 0;
            if (this.ratingList.Count > 0)
            {
                foreach (Rating rt in this.ratingList)
                {
                    avg += (float)rt.Star;
                }
                float rs = avg / (float)this.ratingList.Count;
                rs = rs % 1 > 0.5f ? ((int)rs + 0.5f) : rs;
                avgRating = rs;
                return rs;
            }
            return 0;
        }
    }
}
