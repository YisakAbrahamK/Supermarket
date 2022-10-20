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

namespace Supermarket.Model
{
    public class Admin
    {
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
    }
}
