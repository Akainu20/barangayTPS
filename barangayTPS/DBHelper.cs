using System;
using System.Data;
using System.Data.SQLite;

namespace barangayTPS
{
    public static class DBHelper
    {
        // ⚠️ CHANGE THIS PATH ONCE YOU MOVE THE DB INTO YOUR PROJECT FOLDER
        // For now this path works since your DB is located here while you're testing:
        private static readonly string DbFilePath =
        @"C:\barangayTPS\barangayTPS\barangayTPS\barangayTPS.db";

        private static string ConnectionString =>
            $"Data Source={DbFilePath};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        // SELECT → DataTable
        public static DataTable GetDataTable(string sql, params SQLiteParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (var da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // INSERT / UPDATE / DELETE
        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }

        // Single value
        public static object ExecuteScalar(string sql, params SQLiteParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteScalar();
            }
        }

        // Login authentication
        public static string AuthenticateUser(string username, string password)
        {
            string sql = "SELECT Role FROM Accounts WHERE Username = @u AND Password = @p LIMIT 1;";

            DataTable dt = GetDataTable(sql,
                new SQLiteParameter("@u", username),
                new SQLiteParameter("@p", password));

            if (dt.Rows.Count == 0)
                return null;

            return dt.Rows[0]["Role"].ToString();
        }

        // Insert resident document request
        public static int InsertRequest(
            string username,
            string fullname,
            int age,
            string address,
            string contact,
            string docType,
            string purpose,
            string status,
            string dateSubmitted)
        {
            string sql = @"
                INSERT INTO Requests 
                (Username, FullName, Age, Address, Contact, Document_Type, Purpose, Status, Date_Submitted)
                VALUES 
                (@Username, @FullName, @Age, @Address, @Contact, @Document_Type, @Purpose, @Status, @Date_Submitted);
            ";

            return ExecuteNonQuery(sql,
                new SQLiteParameter("@Username", username),
                new SQLiteParameter("@FullName", fullname),
                new SQLiteParameter("@Age", age),
                new SQLiteParameter("@Address", address),
                new SQLiteParameter("@Contact", contact),
                new SQLiteParameter("@Document_Type", docType),
                new SQLiteParameter("@Purpose", purpose),
                new SQLiteParameter("@Status", status),
                new SQLiteParameter("@Date_Submitted", dateSubmitted));
        }

        // Get available document types
        public static DataTable GetDocumentTypes()
        {
            string sql = "SELECT DocumentType FROM Documents;";
            return GetDataTable(sql);
        }

        // Get requests (with optional filter)
        public static DataTable GetRequests(string filter = "", params SQLiteParameter[] parameters)
        {
            string sql = "SELECT RequestID, Username, FullName, Age, Address, Contact, Document_Type, Purpose, Status, Date_Submitted FROM Requests";

            if (!string.IsNullOrWhiteSpace(filter))
                sql += " WHERE " + filter;

            sql += " ORDER BY Date_Submitted DESC;";

            return GetDataTable(sql, parameters);
        }
    }
}
