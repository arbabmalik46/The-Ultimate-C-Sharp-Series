using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger logger;
        public DbMigrator(ILogger ilogger)
        {
            logger = ilogger;
        }
        public void Migrat()
        {
            logger.LogInfo("Migration Started At " + DateTime.Now);
            logger.LogError("Migration Ended At "+ DateTime.Now.AddDays(1));
            
        }
    }
}
