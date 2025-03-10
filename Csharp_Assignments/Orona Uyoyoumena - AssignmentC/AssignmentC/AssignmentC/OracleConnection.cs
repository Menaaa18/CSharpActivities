using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC
{ 
    /// <summary>
    /// Defines an Oracle database connection class by extending a base class
    /// </summary>
    class OracleConnection : DbConnection
    {
        // Constructor for OracleConnection that passes the connection string to the base DbConnection constructor
        public OracleConnection(string connectionString) : base(connectionString) { }
        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection...");
        }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle connection...");
        }
    }
}
