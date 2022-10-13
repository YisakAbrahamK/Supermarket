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
    }
}
