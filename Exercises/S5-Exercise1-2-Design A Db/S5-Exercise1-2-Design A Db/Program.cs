using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S5_Exercise1_2_Design_A_Db
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracleDb = new OracleConnection("99999");
            //oracleDb.OpenConnection();
            //oracleDb.CloseConnection();
            //Console.WriteLine(oracleDb.ConnectionString);

            var sqlDb = new SqlConnection("12345");
            sqlDb.OpenConnection();
            //sqlDb.CloseConnection();
            //Console.WriteLine(sqlDb.ConnectionString);

            var sqlCommand = new DbCommand(sqlDb, "Execute sql command");
            //var oracleCommand = new DbCommand(oracleDb, "");

            // Each of the commands is tied to the actual DbConnection, per the constructor(s). Therefore, if the connection is already open, then it will throw an error.
            sqlCommand.Execute();
            //oracleCommand.Execute();
        }
    }
}
