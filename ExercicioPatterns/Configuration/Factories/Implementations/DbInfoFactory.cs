using ExercicioPatterns.Enums;
using ExercicioPatterns.Factories.Contracts;
using ExercicioPatterns.Resources;
using ExercicioPatterns.Resources.DbOrigins.Implementations;

namespace ExercicioPatterns.Factories
{
    class DbInfoFactory : IDbInfoFactory
    {
        public DbInfo CreateDbInfo(DbEnum dbType)
        {
            switch (dbType)
            {
                case DbEnum.File:
                    return GetFileInfo();
                case DbEnum.Queue:
                    return GetQueueInfo();
                case DbEnum.EnvironmentVariables:
                    return GetEnvironmentInfo();
                default:
                    return null;
            }
        }

        private DbInfo GetFileInfo()
        {
            var origin = new FileOrigin();
            return origin.GetDbInfo();
        }

        private DbInfo GetQueueInfo()
        {
            var origin = new QueueOrigin();
            return origin.GetDbInfo();
        }

        private DbInfo GetEnvironmentInfo()
        {
            var origin = new EnvironmentOrigin();
            return origin.GetDbInfo();
        }
    }
}
