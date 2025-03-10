using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC
{
    /// <summary>
    /// SQL Database Connection by overriding methods from a base class
    /// </summary>
    class SqlConnection : DbConnection
    {
        // Constructor: Accepts a connection string and passes it to the base class
        public SqlConnection(string connectionString) : base(connectionString) { }

        // Overrides the Open() method to simulate opening a SQL Server connection
        public override void Open()
        {
            Console.WriteLine("Opening SQL Server connection...");
        }

        // Overrides the Close() method to simulate closing a SQL Server connection
        public override void Close()
        {
            Console.WriteLine("Closing SQL Server connection...");
        }
    }
}
