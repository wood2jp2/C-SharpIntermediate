using System;

namespace S5_Exercise1_2_Design_A_Db
{
    public class SqlConnection : DbConnection
    {

        public SqlConnection(string cxnString) : base(cxnString) { }

        public override void CloseConnection()
        {
            if (!IsOpen)
            {
                throw new InvalidOperationException("The database was already closed!");
            }
            IsOpen = false;
            Console.WriteLine("Close connection to Sql database.");
        }

        public override void OpenConnection()
        {
            if (IsOpen)
            {
                throw new InvalidOperationException("The database was already open!");
            }
            IsOpen = true;
            Console.WriteLine("Open connection to Sql database.");
        }
    }
}
