using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Supermarket.View.Forms.Admin;
using System.ComponentModel.DataAnnotations;

namespace Supermarket.Model
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Boolean Gender { get; set; }
        public string Password { get; set; }
        [Index(IsUnique = true)]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }

        public static void text()
        {
            MessageBox.Show("testc");
        }

        public static Admin CheckAdmin(string Email,String Password)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Admin"].ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_AdminLogin";

                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;

                SqlDataReader dataReader = cmd.ExecuteReader();
                Admin admin=null;
                while (dataReader.Read())
                {
                    admin = new Admin();
                    admin.Email = dataReader["Email"].ToString();
                    admin.Gender = Boolean.Parse(dataReader["Gender"].ToString());
                    admin.Id = int.Parse(dataReader["Id"].ToString());
                    admin.Location = dataReader["Location"].ToString();
                    admin.Password = dataReader["Password"].ToString();
                    admin.FirstName = dataReader["FirstName"].ToString();
                    admin.LastName = dataReader["LastName"].ToString();
                    admin.Phone = dataReader["Phone"].ToString();
                }
                return admin;
            }
        }
        public static List<Transaction> transactionSearch(string value)
        {
            List<Transaction> Transactions = null;
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Admin"].ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchTransaction";

                cmd.Parameters.Add("@value", SqlDbType.NVarChar).Value = value;

                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Transactions = new List<Transaction>();
                }
                while (dataReader.Read())
                {
                    Transaction transaction = new Transaction();
                    transaction.Id = int.Parse(dataReader["Id"].ToString());
                    transaction.Total = double.Parse(dataReader["Total"].ToString());
                    transaction.Tax = double.Parse(dataReader["Tax"].ToString());
                    transaction.Subtotal = double.Parse(dataReader["Subtotal"].ToString());
                    transaction.Quantity = int.Parse(dataReader["Quantity"].ToString());
                    transaction.PaidAmount = double.Parse(dataReader["PaidAmount"].ToString());
                    transaction.Change = double.Parse(dataReader["Change"].ToString());
                    transaction.PurchaseDate = DateTime.Parse(dataReader["PurchaseDate"].ToString());
                    transaction.Casher = Casher.getCasherById(int.Parse(dataReader["Casher_Id"].ToString()));
                    Transactions.Add(transaction);
                }
            }
            return Transactions;
        }
        public static List<Transaction> transactionSearchByDate(DateTime startDate,DateTime endDate)
        {
            List<Transaction> Transactions = null;
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Admin"].ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchTransactionByDate";

                cmd.Parameters.Add("@Begin", SqlDbType.DateTime).Value = startDate;
                cmd.Parameters.Add("@End", SqlDbType.DateTime).Value = endDate;

                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Transactions = new List<Transaction>();
                }
                while (dataReader.Read())
                {
                    Transaction transaction = new Transaction();
                    transaction.Id = int.Parse(dataReader["Id"].ToString());
                    transaction.Total = double.Parse(dataReader["Total"].ToString());
                    transaction.Tax = double.Parse(dataReader["Tax"].ToString());
                    transaction.Subtotal = double.Parse(dataReader["Subtotal"].ToString());
                    transaction.Quantity = int.Parse(dataReader["Quantity"].ToString());
                    transaction.PaidAmount = double.Parse(dataReader["PaidAmount"].ToString());
                    transaction.Change = double.Parse(dataReader["Change"].ToString());
                    transaction.PurchaseDate = DateTime.Parse(dataReader["PurchaseDate"].ToString());
                    transaction.Casher = Casher.getCasherById(int.Parse(dataReader["Casher_Id"].ToString()));
                    Transactions.Add(transaction);
                }
            }
            return Transactions;
        }
    }
}
