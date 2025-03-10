using AssignmentC;
using System;

class Program
{
    /// <summary>
    /// Execution of SQL commands using SQL server and Oracle by polymorphism
    /// </summary>
    static void Main()
    {
        // Using SqlConnection
        var sqlConnection = new SqlConnection("Server=myServer;Database=myDB;");
        var sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Users");
        sqlCommand.Execute();

        Console.WriteLine();

        // Using OracleConnection
        var oracleConnection = new OracleConnection("Server=myOracleServer;Database=myOracleDB;");
        var oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Customers");
        oracleCommand.Execute();
    }
}