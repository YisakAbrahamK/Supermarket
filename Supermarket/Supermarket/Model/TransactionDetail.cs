using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;

namespace Supermarket.Model
{
    public class TransactionDetail
    {
        [Key]
        public int Id { get; set; }
        public double Total { get; set; }
        public double Tax { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { get; set; }
        public Product product { get; set; }
        public Transaction Transaction { get; set; }

    }
   
}
