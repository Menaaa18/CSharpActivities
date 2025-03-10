using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC
{
    /// <summary>
    /// DbCommand: This class manages the execution of database commands
    /// </summary>
    class DbCommand
    {
        private readonly DbConnection _connection; // The database connection required to execute the command
        private readonly string _instruction; // The SQL or database command to be executed

        // Constructor: Initializes a new instance of the DbCommand class
        public DbCommand(DbConnection connection, string instruction)
        {
            // Ensure the provided connection is not null, otherwise throw an error
            _connection = connection ?? throw new InvalidOperationException("Connection cannot be null.");

            // Ensure the instruction is not null or empty, otherwise throw an error
            _instruction = string.IsNullOrWhiteSpace(instruction)
                ? throw new InvalidOperationException("Instruction cannot be null or empty.")
                : instruction;
        }

        // Execute: Opens the database connection, executes the command, and closes the connection
        public void Execute()
        {
            _connection.Open(); // Open the database connection
            Console.WriteLine($"Executing command: {_instruction}"); // Simulate command execution
            _connection.Close(); // Close the database connection
        }
    }
}
