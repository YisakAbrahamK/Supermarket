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

namespace Supermarket.Model
{
    public class Casher
    {
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
    }
}
