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
    public class ListOfAwardsDao : IListOfAwardsDao
    {
        private string connnectionString = "Data Source=IBPPM-BIOENG\\SQLEXPRESS; Initial Catalog = Rewarding; Integrated Security = True";

        public int AddAwardToUser(ListOfAwards value)
        {
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddAwardToUser";

                cmd.Parameters.Add(new SqlParameter("@IDUser", value.IDUser));
                cmd.Parameters.Add(new SqlParameter("@IDAward", value.IDAward));
                connection.Open();

                Object tmp = cmd.ExecuteScalar();

                if (tmp == null)
                    return -1;
                return (int)tmp;

                //return (int)(decimal)cmd.ExecuteScalar();
            }
        }

        public IEnumerable<ListOfAwards> GetAllUsersWithAwards()
        {
            var result = new List<ListOfAwards>();
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllUsersWithAwards", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var listOfAwards = new ListOfAwards
                    {
                        IDUser = (int)reader["IDUser"],
                        IDAward = (int)reader["IDAward"]
                    };

                    result.Add(listOfAwards);
                }
            }

            return result;
        }
    }
}
