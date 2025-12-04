using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDiem.DAL
{
    public class DbHelper
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["QuanLyDiemConnection"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // SELECT – trả về DataTable
        public static DataTable ExecuteQuery(string procName, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(procName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        // INSERT / UPDATE / DELETE – trả về số dòng ảnh hưởng
        public static int ExecuteNonQuery(string procName, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(procName, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
