using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.View.Forms.Admin;
using Supermarket.View.Forms.Admin.Admin_Form_Subcomponents;
using System.ComponentModel.DataAnnotations;

namespace Supermarket.Model
{
    public class Casher
    {
        [Key]
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public Boolean Gender { get; set; }
        public string Password { get; set; }
        [Index(IsUnique = true)]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }

        public static Casher CheckCasher(string Email, String Password)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Casher"].ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_CasherLogin";

                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Password;

                SqlDataReader dataReader = cmd.ExecuteReader();
                Casher casher = null;
                while (dataReader.Read())
                {
                    casher = new Casher();
                    casher.Email = dataReader["Email"].ToString();
                    casher.Gender = Boolean.Parse(dataReader["Gender"].ToString());
                    casher.Id = int.Parse(dataReader["Id"].ToString());
                    casher.Location = dataReader["Location"].ToString();
                    casher.Password = dataReader["Password"].ToString();
                    casher.FirstName = dataReader["FirstName"].ToString();
                    casher.LastName = dataReader["LastName"].ToString();
                    casher.Phone = dataReader["Phone"].ToString();
                }
                return casher;
            }

        }

        public static Casher getCasherById(int id)
        {
            using (Context context = new Context())
            {
                var casher = context.Cashers.Find(id);
                return casher;
            }
        }

        public static List<Transaction> transactionSearch(string value,Casher casher)
        {
            List<Transaction> Transactions = null;
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["casher"].ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchTransactionByCasher";

                cmd.Parameters.Add("@value", SqlDbType.NVarChar).Value = value;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = casher.Id;

                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    Transactions = new List<Transaction>();
                }
                while (dataReader.Read())
                {
                    Transaction transaction = new Transaction();    
                    transaction.Id= int.Parse(dataReader["Id"].ToString()); 
                    transaction.Total= double.Parse(dataReader["Total"].ToString());
                    transaction.Tax = double.Parse(dataReader["Tax"].ToString());
                    transaction.Subtotal = double.Parse(dataReader["Subtotal"].ToString());
                    transaction.Quantity = int.Parse(dataReader["Quantity"].ToString());
                    transaction.PaidAmount = double.Parse(dataReader["PaidAmount"].ToString());
                    transaction.Change = double.Parse(dataReader["Change"].ToString());
                    transaction.PurchaseDate = DateTime.Parse(dataReader["PurchaseDate"].ToString());
                    transaction.Casher = getCasherById(int.Parse(dataReader["Casher_Id"].ToString()));
                    Transactions.Add(transaction);
                }
            }
            return Transactions;
        }
        public static List<Transaction> transactionSearchByDate(DateTime startDate, DateTime endDate,Casher casher)
        {
            List<Transaction> Transactions = null;
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["casher"].ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchTransactionByDateCasher";

                cmd.Parameters.Add("@Begin", SqlDbType.DateTime).Value = startDate;
                cmd.Parameters.Add("@End", SqlDbType.DateTime).Value = endDate;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = casher.Id;


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
                    transaction.Casher = getCasherById(int.Parse(dataReader["Casher_Id"].ToString()));
                    Transactions.Add(transaction);
                }
            }
            return Transactions;
        }


        public static List<Casher> Search(string value)
        {
            List<Casher> cashers = null;
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Admin"].ConnectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_SearchCasher";

                cmd.Parameters.Add("@search", SqlDbType.NVarChar).Value = value;

                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    cashers = new List<Casher>();
                }
                while (dataReader.Read())
                {
                    Model.Casher casher = new Casher();
                    casher.FirstName = dataReader["FirstName"].ToString();
                    casher.LastName = dataReader["LastName"].ToString();
                    casher.Location = dataReader["Location"].ToString();
                    casher.Password = dataReader["Password"].ToString();
                    casher.Email = dataReader["Email"].ToString();
                    casher.Phone = dataReader["Phone"].ToString();
                    casher.Id = int.Parse(dataReader["Id"].ToString());
                    casher.Gender = bool.Parse(dataReader["Gender"].ToString());
                    cashers.Add(casher);
                }
            }
            return cashers;
        }
    }
}
