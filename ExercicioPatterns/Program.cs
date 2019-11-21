using ExercicioPatterns.Database.Services.Implementation;
using ExercicioPatterns.Enums;
using ExercicioPatterns.Services.Implementations;
using System;

namespace ExercicioPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            var dbConfigService = DbConfigService.GetInstance(DbEnum.File);

            // File
            Console.WriteLine("Db Info : Arquivo");
            Console.WriteLine(dbConfigService.CreateConfigJson());

            // Queue
            Console.WriteLine("Db Info : Mensageria");
            dbConfigService.DbType = DbEnum.Queue;
            Console.WriteLine(dbConfigService.CreateConfigJson());

            // Environment Variable
            Environment.SetEnvironmentVariable("host", "192.168.0.1");
            Environment.SetEnvironmentVariable("port", "3666");
            Environment.SetEnvironmentVariable("user", "userEnvironment");
            Environment.SetEnvironmentVariable("password", "passEnvironment");
            Environment.SetEnvironmentVariable("database", "EnvironmentDatabase");

            Console.WriteLine("Db Info : Variaveis de Ambiente");
            dbConfigService.DbType = DbEnum.EnvironmentVariables;
            Console.WriteLine(dbConfigService.CreateConfigJson());

            // Database

            Console.WriteLine("Database : EnvironmentVariables");
            var connService = new DbConnectionService(DbEnum.EnvironmentVariables);
            Console.WriteLine(connService.GetConnString());
            connService.Execute("SELECT * FROM tb_teste t WHERE t.id = 0");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Database : File");
            connService = new DbConnectionService(DbEnum.File);
            Console.WriteLine(connService.GetConnString());
            connService.Execute("SELECT * FROM tb_teste t WHERE t.id = 0");
            Console.WriteLine("-----------------------------------------");

            Console.ReadKey();
        }
    }
}
