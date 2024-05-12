using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProj
{
    internal class RegularCustomer
    {
        private AccountDAO accountDAO = new AccountDAO();
        private int id;
        private string name;
        private double totalpurchase;
        private int times;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Times { get => times; set => times = value; }
        public double Totalpurchase { get => totalpurchase; set => totalpurchase = value; }

        public RegularCustomer() { }

        public RegularCustomer(int id, Product pd)
        {
            Account acc = accountDAO.Retrieve(id);
            this.id = acc.ID;
            this.name = acc.Name;
            totalpurchase = (double)pd.SalePrice;
            times = 1;
        }
    }
}
