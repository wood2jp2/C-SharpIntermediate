using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        // Dependency Injection: in the constructor here, we are outlining what this class relies on. In the main method
        // we will specify a concrete class that relies on that interface  
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        // See, DbMigrator knows NOTHING about logging to a console, below. It is simply talking to the interface. 
        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
              
            // Details of migrating the database
            _logger.LogInfo("Migration ended at " + DateTime.Now);
        }
    }
}
