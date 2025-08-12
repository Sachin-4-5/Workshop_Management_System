using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WorkshopManagementSystem.DAL
{
    public static class DbHelper
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["WorkshopDB"].ConnectionString;

        public static DataTable ExecuteDataTable(string query, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                if (parameters != null && parameters.Length > 0)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
