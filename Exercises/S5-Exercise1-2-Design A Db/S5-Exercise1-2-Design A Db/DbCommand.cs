using System;

namespace S5_Exercise1_2_Design_A_Db
{
    public class DbCommand {
        public DbConnection DbCxn { get; set; }
        public string Connection { get; set; }
        public string Command { get; set; }

        // Constructor that takes in a connection instance and a command, and if they aren't null, sets them as properties.
        public DbCommand(DbConnection dbConnection, string tsqInstruction)
        {
            if (dbConnection == null || string.IsNullOrEmpty(tsqInstruction))
            {
                throw new InvalidOperationException("Please ensure to provide a valid DbConnection and command!");
            }
            DbCxn = dbConnection;
            Connection = dbConnection.ConnectionString;
            Command = tsqInstruction;
        }

        public void Execute()
        {
            if (DbCxn.IsOpen)
            {
                throw new Exception("Please close out of your current Db connection in order to execude command");
            }

            DbCxn.OpenConnection();
            Console.WriteLine(Command);
            DbCxn.CloseConnection();
        }
    }
}
