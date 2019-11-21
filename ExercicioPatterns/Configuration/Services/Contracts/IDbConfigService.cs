using ExercicioPatterns.Enums;

namespace ExercicioPatterns.Services.Contracts
{
    interface IDbConfigService
    {
        DbEnum DbType { get; set; }

        string CreateConfigJson();
    }
}
