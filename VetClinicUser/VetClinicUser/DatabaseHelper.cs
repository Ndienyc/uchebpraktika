using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace VetClinicUser
{
    public static class DatabaseHelper
    {
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "VetClinic.accdb");
        private static string connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";

        public static string GetConnectionString() => connStr;

        public static DataTable GetData(string query)
        {
            var dt = new DataTable();
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var da = new OleDbDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetDataParam(string query, params OleDbParameter[] parameters)
        {
            var dt = new DataTable();
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                using (var cmd = new OleDbCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public static void ExecuteQuery(string query, params OleDbParameter[] parameters)
        {
            using (var conn = new OleDbConnection(connStr))
            {
                conn.Open();
                var cmd = new OleDbCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
