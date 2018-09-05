using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class DbMigrator
    {
        private readonly Logger _logger;

        // if you hover over 'logger' in the arg, and press Alt+Enter, you can initialize a field for logger
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("we are migrating");
        }
    }
}
