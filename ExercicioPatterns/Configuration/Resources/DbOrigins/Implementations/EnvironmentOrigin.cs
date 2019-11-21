using ExercicioPatterns.Resources.DbOrigins.Contracts;
using System;

namespace ExercicioPatterns.Resources.DbOrigins.Implementations
{
    class EnvironmentOrigin : IDbOrigin
    {
        public DbInfo GetDbInfo()
        {
            return new DbInfo
            {
                Host = Environment.GetEnvironmentVariable("host"),
                Port = int.Parse(Environment.GetEnvironmentVariable("port")),
                User = Environment.GetEnvironmentVariable("user"),
                Password = Environment.GetEnvironmentVariable("password"),
                Database = Environment.GetEnvironmentVariable("database")
            };
        }
    }
}
