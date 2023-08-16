using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SQLMigrationManager
{

    namespace SQLMigrations
    {
        public class StoredProcedureScripts
        {
            private readonly string connectionString = Environment.GetEnvironmentVariable("connectionString");
            private readonly string pathOfFiles = Environment.GetEnvironmentVariable("storedProcedureDirectory");
            public void Run()
            {
                SqlConnection connection = new SqlConnection(connectionString);
                Server server = new Server(new ServerConnection(connection));
                List<string> filePaths = Directory.GetFiles(pathOfFiles).ToList();
                foreach (string file in filePaths)
                {
                    try
                    {
                        Console.WriteLine($"executing {file}");
                        FileInfo fileInfo = new FileInfo(file);
                        string script = fileInfo.OpenText().ReadToEnd();
                        server.ConnectionContext.ExecuteNonQuery(script);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                }
                connection.Close();
            }
        }
    }
}
