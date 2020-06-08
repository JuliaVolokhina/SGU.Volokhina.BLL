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
    public class AwardDao : IAwardDao
    {
        private string connnectionString = "Data Source=IBPPM-BIOENG\\SQLEXPRESS; Initial Catalog = Rewarding; Integrated Security = True";

        public int AddAward(Award value)
        {
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddAward";

                cmd.Parameters.Add(new SqlParameter("@Title", value.Title));
                connection.Open();

                Object  tmp = cmd.ExecuteScalar();

                if (tmp == null)
                    return -1;
                return (int)tmp;
            }
        }

            public IEnumerable<Award> GetAllAwards()
        {
            var result = new List<Award>();
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllAwards", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var award = new Award
                    {
                        IDAward = (int)reader["IDAward"],
                        Title = (string)reader["Title"]
                    };

                    result.Add(award);
                }
            }

            return result;
        }
    }
}