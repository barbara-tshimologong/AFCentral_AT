using System;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class SqlServerAccess
    {

        public SqlServerAccess(string connString)
        {
            ConnString = connString;
        }

         public string ConnString { get; init; }

        public string CallSP()
        {
            using (SqlConnection cn = new Microsoft.Data.SqlClient.SqlConnection())
            {
                cn.ConnectionString = ConnString;

                cn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "spInsert_Facilitator";

                    cmd.ExecuteNonQuery();
                }

            }
            return "Successfully inserted";
        }
    }
}
