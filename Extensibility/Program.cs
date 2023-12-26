using System;

namespace Extensibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrat();
        }
    }
}
