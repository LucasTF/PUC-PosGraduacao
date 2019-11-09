using ExercicioPatterns.Enums;
using ExercicioPatterns.Factories.Contracts;
using ExercicioPatterns.Resources;

namespace ExercicioPatterns.Factories
{
    class DbInfoFactory : IDbInfoFactory
    {
        public DbInfo CreateDbInfo(string connString, DbInfoTypeEnum infoType)
        {
            switch (infoType)
            {
                case DbInfoTypeEnum.Json:
                    return CreateDbInfoFromJson(connString);
                case DbInfoTypeEnum.Txt:
                    return CreateDbInfoFromTxt(connString);
                case DbInfoTypeEnum.AmbientVariables:
                    return CreateDbInfoFromVariables(connString);
                default:
                    return null;
            }
        }

        private DbInfo CreateDbInfoFromJson(string connString)
        {
            return new DbInfo();
        }

        private DbInfo CreateDbInfoFromTxt(string connString)
        {
            return new DbInfo();
        }

        private DbInfo CreateDbInfoFromVariables(string connString)
        {
            return new DbInfo();
        }
    }
}
