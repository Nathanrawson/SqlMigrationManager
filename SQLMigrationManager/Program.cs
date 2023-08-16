using SQLMigrationManager.SQLMigrations;
using System;

namespace SQLMigrationManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var spScripts = new StoredProcedureScripts();
            Console.WriteLine("Running stored procedure scripts");
            spScripts.Run();
            Console.ReadLine();
        }
    }
}
