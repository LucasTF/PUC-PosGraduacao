using ExercicioPatterns.Database.Repository.Contract;
using ExercicioPatterns.Database.Repository.Implementation;
using ExercicioPatterns.Enums;
using ExercicioPatterns.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPatterns.Database.Builders
{
    class ConnectionBuilder
    {
        public IConnection BuildConnection(DbEnum dbType)
        {
            var dbConfig = DbConfigService.GetInstance(dbType);
            var connString = dbConfig.CreateConfigJson();
            return InitializeConnection(connString);
        }

        private IConnection InitializeConnection(string connString)
        {
            var conn = Connection.GetInstance(connString);
            conn.Open();
            conn.Ping();
            return conn;
        }

    }
}
