using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace barangayTPS
{
    public static class DBHelper
    {
        public static string connectionString = @"Data Source=C:\barangayTPS\barangayTPS\barangayTPS\barangayTPS\barangayTPS.db;Version=3;";

        public static void InitializeDatabase()
        {
            try
            {
                string fullPath = @"C:\barangayTPS\barangayTPS\barangayTPS\barangayTPS\barangayTPS.db";
                bool databaseExists = File.Exists(fullPath);

                if (!databaseExists)
                {
                    return;
                }

                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection error: {ex.Message}");
            }
        }

        public static string AuthenticateUser(string username, string password)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Role FROM Accounts WHERE Username = @username AND Password = @password";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        var result = cmd.ExecuteScalar();
                        return result?.ToString();
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public static int InsertUser(string username, string password, string role)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Accounts (Username, Password, Role) VALUES (@username, @password, @role)";

                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);

                        return cmd.ExecuteNonQuery();
                    }
                }
                catch (SQLiteException ex)
                {
                    if (ex.Message.Contains("UNIQUE constraint failed"))
                    {
                        return 0;
                    }
                    return 0;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }

        public static DataTable GetRecentRequestsForDashboard(string whereClause = "", params SQLiteParameter[] parameters)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT 
                        RequestID,
                        FullName as [Resident Name],
                        Document_Type as [Document Type],
                        Date_Submitted as [Date Requested],
                        Status
                        FROM Requests";

                if (!string.IsNullOrEmpty(whereClause))
                {
                    query += " WHERE " + whereClause;
                }

                query += " ORDER BY RequestID DESC";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }

                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetDetailedRequestsForHistory(string whereClause = "", params SQLiteParameter[] parameters)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT 
                        RequestID as [Request ID],
                        FullName as [Resident Name],
                        Document_Type as [Document Type],
                        Date_Submitted as [Date Requested],
                        Status,
                        Purpose as [Purpose of Request]
                        FROM Requests";

                if (!string.IsNullOrEmpty(whereClause))
                {
                    query += " WHERE " + whereClause;
                }

                query += " ORDER BY Date_Submitted DESC";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }

                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static int InsertRequest(string username, string fullName, int age, string address,
                                      string contact, string docType, string purpose, string status, string date)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Requests 
                               (Username, FullName, Age, Address, Contact, Document_Type, Purpose, Status, Date_Submitted) 
                               VALUES (@username, @fullName, @age, @address, @contact, @docType, @purpose, @status, @date)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@docType", docType);
                    cmd.Parameters.AddWithValue("@purpose", purpose);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@date", date);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetDocumentTypes()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DocumentType FROM Documents";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable GetResidentData()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT DISTINCT 
                        Username,
                        FullName as ResidentName,
                        Age as ResidentAge,
                        Address as ResidentAddress,
                        Contact as ResidentContactNum
                        FROM Requests 
                        WHERE Username IS NOT NULL 
                        AND FullName IS NOT NULL
                        AND FullName != ''
                        ORDER BY FullName";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static void TestConnection()
        {
            try
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}