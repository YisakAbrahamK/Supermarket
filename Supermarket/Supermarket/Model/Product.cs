using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Http.Headers;

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

        public int Quantity { get; set; }

        public static List<Product> Search(string value)
        {
            List<Product> products = null;
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Casher"].ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchProduct";

                cmd.Parameters.Add("@search", SqlDbType.NVarChar).Value = value;

                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    products = new List<Product>();
                }
                while (dataReader.Read())
                {
                    Product product = new Product();
                    product.Id = int.Parse(dataReader["Id"].ToString());
                    product.Name = dataReader["Name"].ToString();
                    product.Price = double.Parse(dataReader["Price"].ToString());
                    product.ExpiredDate = DateTime.Parse(dataReader["ExpiredDate"].ToString());
                    product.Tax= double.Parse(dataReader["Tax"].ToString());
                    product.UPC = dataReader["UPC"].ToString();
                    product.ShelfNumber = int.Parse(dataReader["ShelfNumber"].ToString());
                    product.Quantity = int.Parse(dataReader["Quantity"].ToString());
                    products.Add(product);
                }
            }
            return products;
        }

    }
}
