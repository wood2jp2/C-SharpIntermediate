using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            // to pass a class type to another class: initialize like this OR set an instance to a variable (var something = new Something())
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            // the take away here is that we are able to compose classes (migrator and installer) that can take in a logger
            // instance, and use its' logging function to log something, all within the Migrate and Install methods
            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
