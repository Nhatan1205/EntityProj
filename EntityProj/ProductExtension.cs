using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProj
{
    internal class ProductExtension
    {
        private Product product;
        public ProductExtension() { }

        public ProductExtension(Product product) 
        {
            this.product = product;
        }

        private int billStatus;
        private DateTime buyDate;
        private int cancelLimit;


        public int BillStatus { get => billStatus; set => billStatus = value; }
        public DateTime BuyDate { get => buyDate; set => buyDate = value; }
        public int CancelLimit { get => cancelLimit; set => cancelLimit = value; }


        public string GetBillStatus()
        {
            switch (billStatus)
            {
                case 0:
                    return "";
                case 1:
                    return "Wait for confirmation";
                case 2:
                    return "Confirmed";
                case 3:
                    return "Pack";
                case 4:
                    return "Transport";
                case 5:
                    return "Completed";
                default:
                    return "";
            }
        }

        public DateTime CancelDate()
        {
            return BuyDate.AddHours(cancelLimit);
        }
    }
}
