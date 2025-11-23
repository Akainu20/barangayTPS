using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace barangayTPS
{
    public static class DBHelper
    {
        private static string connectionString = @"Data Source=C:\barangayTPS\barangayTPS\barangayTPS\barangayTPS\barangayTPS.db;Version=3;";

        public static void InitializeDatabase()
        {
            try
            {
                string fullPath = @"C:\barangayTPS\barangayTPS\barangayTPS\barangayTPS\barangayTPS.db";
                bool databaseExists = File.Exists(fullPath);

                MessageBox.Show($"Looking for database at: {fullPath}");
                MessageBox.Show($"Database exists: {databaseExists}");

                if (!databaseExists)
                {
                    MessageBox.Show("Database file not found at the specified path!");
                    return;
                }

                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Successfully connected to your barangayTPS.db database!");

                    // Show all accounts for verification
                    CheckAllAccounts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection error: {ex.Message}");
            }
        }

        // ==================== ACCOUNT METHODS ====================
        public static string AuthenticateUser(string username, string password)
        {
            MessageBox.Show($"Authenticating: {username}");

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
                        MessageBox.Show($"Authentication result: {result}");
                        return result?.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                    return null;
                }
            }
        }

        public static int InsertUser(string username, string password, string role)
        {
            MessageBox.Show($"Inserting user: {username}, {password}, {role}");

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

                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show($"InsertUser: {result} row(s) affected");
                        return result;
                    }
                }
                catch (SQLiteException ex)
                {
                    if (ex.Message.Contains("UNIQUE constraint failed"))
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                    }
                    else
                    {
                        MessageBox.Show($"SQLite error: {ex.Message}");
                    }
                    return 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return 0;
                }
            }
        }

        public static void CheckAllAccounts()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Username, Password, Role FROM Accounts";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    string accounts = "All accounts in database:\n";
                    bool hasAccounts = false;

                    while (reader.Read())
                    {
                        hasAccounts = true;
                        accounts += $"Username: {reader["Username"]}, Password: {reader["Password"]}, Role: {reader["Role"]}\n";
                    }

                    if (!hasAccounts)
                    {
                        accounts += "No accounts found in database!";
                    }
                    MessageBox.Show(accounts);
                }
            }
        }

        // ==================== REQUEST METHODS ====================
        public static DataTable GetRequests(string whereClause = "", params SQLiteParameter[] parameters)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT 
                    RequestID,
                    Username,
                    FullName,
                    Age,
                    Address,
                    Contact,
                    Document_Type as DocumentType,
                    Purpose,
                    Status,
                    Date_Submitted as DateRequested 
                    FROM Requests";

                if (!string.IsNullOrEmpty(whereClause))
                {
                    query += " WHERE " + whereClause;
                }

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
            MessageBox.Show($"Inserting request for: {username}, Document: {docType}");

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

                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show($"InsertRequest: {result} row(s) affected");
                    return result;
                }
            }
        }

        // ==================== DOCUMENT METHODS ====================
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

        public static void CheckAllDocuments()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DocumentType FROM Documents";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    string documents = "Available document types:\n";
                    bool hasDocuments = false;

                    while (reader.Read())
                    {
                        hasDocuments = true;
                        documents += $"- {reader["DocumentType"]}\n";
                    }

                    if (!hasDocuments)
                    {
                        documents += "No document types found!";
                    }
                    MessageBox.Show(documents);
                }
            }
        }

        // ==================== RESIDENT METHODS ====================
        public static DataTable GetResidentData()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Use the exact column names that match your data grid
                string query = @"SELECT 
            Username,
            FullName as ResidentName,  // Changed from 'Name'
            Age as ResidentAge,        // Changed from 'Age'
            Address as ResidentAddress, // Changed from 'Address'
            Contact as ResidentContactNum // Changed from 'ContactNumber'
            FROM Requests 
            WHERE Username IS NOT NULL";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static void CheckAllResidents()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT 
                    Username,
                    FullName,
                    Age,
                    Address,
                    Contact
                    FROM Requests";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    string residents = "Residents with requests:\n";
                    bool hasResidents = false;

                    while (reader.Read())
                    {
                        hasResidents = true;
                        residents += $"User: {reader["Username"]}, Name: {reader["FullName"]}, Contact: {reader["Contact"]}\n";
                    }

                    if (!hasResidents)
                    {
                        residents += "No residents found with requests!";
                    }
                    MessageBox.Show(residents);
                }
            }
        }

        // ==================== DEBUG METHODS ====================
        public static void ShowTableData(string tableName)
        {
            try
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = $"SELECT * FROM {tableName}";
                    using (var cmd = new SQLiteCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        string data = $"{tableName} data:\n";
                        bool hasData = false;

                        while (reader.Read())
                        {
                            hasData = true;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                data += $"{reader.GetName(i)}: {reader[i]}, ";
                            }
                            data += "\n";
                        }

                        if (!hasData)
                        {
                            data += "No data found";
                        }
                        MessageBox.Show(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading {tableName}: {ex.Message}");
            }
        }

        public static void TestConnection()
        {
            try
            {
                using (var conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Database connection test: SUCCESS");

                    // Test all tables
                    CheckAllAccounts();
                    CheckAllDocuments();
                    CheckAllResidents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection test: FAILED - {ex.Message}");
            }
        }

        public static void Debug_CheckRequestsTable()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Username, FullName, Age, Address, Contact FROM Requests";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    string data = "REQUESTS TABLE DATA:\n";
                    int count = 0;

                    while (reader.Read())
                    {
                        count++;
                        data += $"[{count}] User: '{reader["Username"]}', Name: '{reader["FullName"]}', Age: {reader["Age"]}\n";
                    }

                    if (count == 0)
                    {
                        data += "NO DATA FOUND IN REQUESTS TABLE!";
                    }

                    MessageBox.Show(data);
                }
            }
        }
    }
}