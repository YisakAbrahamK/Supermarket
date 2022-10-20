using Supermarket.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class Context:DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Casher> Cashers { get; set; }
    }
}

