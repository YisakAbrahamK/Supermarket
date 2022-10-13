using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public DateTime  ExpiredDate { get; set; }

        public double Tax { get; set; }

        public string UPC { get; set; }

        public int ShelfNumber { get; set; }

        //static List<Product> Products=new List<Product>();

        //public static List<Product> getAllProduct() { return Products; }


        //public static void lodeTestdata()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Product p = new Product();

        //        p.Name = $"Product { i + 1}";
        //        p.Price=i+4.8;
        //        p.ExpiredDate = DateTime.Now;
        //        p.Tax = i + 4;
        //        p.UPC=i+385232595;
        //        Products.Add(p);
        //    }

        //}

    }
}
