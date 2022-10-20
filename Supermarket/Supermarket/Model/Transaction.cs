using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public double Tax { get; set; }
        public double Subtotal { get; set; }
        public int Quantity { get; set; }
        public double PaidAmount { get; set; }
        public double Change { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Casher Casher{ get; set; }
    }
}
