using System;

namespace S5_Exercise1_2_Design_A_Db
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public bool IsOpen { get; set; }

        // These are abstract, as we are overriding them depending on which kind of Database we are connecting to.
        public abstract void OpenConnection();
        public abstract void CloseConnection();

        public DbConnection(string cxnString)
        {
            if (String.IsNullOrEmpty(cxnString))
            {
                throw new InvalidOperationException("Please provide a valid connection string");
            }
            ConnectionString = cxnString;
            IsOpen = false;
        }

    }
}
