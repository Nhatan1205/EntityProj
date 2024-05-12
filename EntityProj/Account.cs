//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProj
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Address { get; set; }
        public byte[] Avatar { get; set; }
        public Nullable<float> Money { get; set; }
        public Nullable<int> selectedShippingID { get; set; }

        private List<Rating> ratingList = new List<Rating>();
        private float avgRating;

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
        public float AvgRating { get => avgRating; set => avgRating = value; }
        public List<Rating> RatingList { get => ratingList; set => ratingList = value; }
    }
}
