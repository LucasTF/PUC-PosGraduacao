using ExercicioPatterns.Enums;
using ExercicioPatterns.Factories;
using ExercicioPatterns.Services.Contracts;
using Newtonsoft.Json;
using System;

namespace ExercicioPatterns.Services.Implementations
{
    sealed class DbConfigService : IDbConfigService
    {

        private static IDbConfigService _instance;

        public DbEnum DbType { get; set; }

        private DbConfigService(DbEnum dbType)
        {
            DbType = dbType;
        }

        private DbConfigService()
        {

        }

        public static IDbConfigService GetInstance(DbEnum dbType)
        {
            if(_instance == null)
            {
                _instance = new DbConfigService(dbType);
            }
            else
            {
                _instance.DbType = dbType;
            }
            return _instance;
        }

        public string CreateConfigJson()
        {
            var Factory = new DbInfoFactory();
            var DbInfo = Factory.CreateDbInfo(DbType);
            return JsonConvert.SerializeObject(DbInfo);
        }
    }
}
