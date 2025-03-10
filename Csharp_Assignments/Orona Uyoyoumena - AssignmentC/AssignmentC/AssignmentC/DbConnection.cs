using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC
{
    /// <summary>
    /// Base Class for the different database connections
    /// </summary>
    public abstract class DbConnection
    {
        // Property to store the database connection string (read-only)
        public string ConnectionString { get; }

        // Property to store the connection timeout duration (modifiable)
        public TimeSpan Timeout { get; set; }

        // Constructor: Initializes the database connection with a connection string
        public DbConnection(string connectionString)
        {
            // Ensure the connection string is not null, empty, or whitespace, otherwise throw an error
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Connection string cannot be null or empty.");

            ConnectionString = connectionString; // Assign the provided connection string
            Timeout = TimeSpan.FromSeconds(30); // Set a default timeout of 30 seconds
        }

        // Abstract method to open the database connection (must be implemented by derived classes)
        public abstract void Open();

        // Abstract method to close the database connection (must be implemented by derived classes)
        public abstract void Close();
    }
}
