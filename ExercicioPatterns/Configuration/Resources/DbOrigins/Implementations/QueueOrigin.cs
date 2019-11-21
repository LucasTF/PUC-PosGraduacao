using ExercicioPatterns.Resources.DbOrigins.Contracts;
using System;

namespace ExercicioPatterns.Resources.DbOrigins.Implementations
{
    class QueueOrigin : IDbOrigin
    {
        public DbInfo GetDbInfo()
        {
            var dbInfoMock = new DbInfo("192.68.0.1", 3666, "userQueue", "passQueue", "QueueDatabase");
            return dbInfoMock;
        }
    }
}
