using SGU.Volokhina.Entitiess;
using SGU.Volokhina.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SGU.Volokhina.DAL
{
    public class UserDao : IUserDao
    {
        private string connnectionString = "Data Source=IBPPM-BIOENG\\SQLEXPRESS;Initial Catalog = Rewarding; Integrated Security = True";

        public int AddUser(User value)
        {
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddUser";

                cmd.Parameters.Add(new SqlParameter("@IDUser", value.IDUser));
                cmd.Parameters.Add(new SqlParameter("@FirstName", value.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", value.LastName));
                cmd.Parameters.Add(new SqlParameter("@DateOfBirth", value.DateOfBirth));
                cmd.Parameters.Add(new SqlParameter("@Age", value.Age));
                connection.Open();

                Object tmp = cmd.ExecuteScalar();

                if (tmp == null)
                    return -1;
                return (int)tmp;

                //return (int)cmd.ExecuteScalar();
            }
        }

        public void DeleteUser(int value)
        {
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteUser";

                cmd.Parameters.Add(new SqlParameter("@IDUser", value));

                connection.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            var result = new List<User>();
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllUsers", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var user = new User
                    {
                        IDUser = (int)reader["IDUser"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        DateOfBirth = reader["DateOfBirth"].ToString(),
                        Age = (int)reader["Age"]
                    };

                    result.Add(user);
                }
            }

            return result;
        }
    }
}