using ExercicioPatterns.Enums;
using ExercicioPatterns.Resources;

namespace ExercicioPatterns.Factories.Contracts
{
    interface IDbInfoFactory
    {
        DbInfo CreateDbInfo(string connString, DbInfoTypeEnum infoType);
    }
}
