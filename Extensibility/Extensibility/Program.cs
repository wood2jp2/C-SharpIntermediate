using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{

    class Program
    {
        static void Main(string[] args)
        {
            // DbMigrator only cares that whatever is passed to it INTERFACES with ILogger. This way, you can pass it
            // FileLogger or ConsoleLogger
            //var dbMigrator = new DbMigrator(new ConsoleLogger());

            var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\joshua.wood\\Documents\\Miscellaneous\\CSharp_Intermediate\\C-SharpIntermediate\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
