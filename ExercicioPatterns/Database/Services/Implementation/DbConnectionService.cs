using ExercicioPatterns.Database.Builders;
using ExercicioPatterns.Database.Repository.Contract;
using ExercicioPatterns.Enums;

namespace ExercicioPatterns.Database.Services.Implementation
{
    class DbConnectionService : IDbConnectionService
    {

        private IConnection _conn;

        public DbConnectionService(DbEnum dbType)
        {
            var builder = new ConnectionBuilder();
            _conn = builder.BuildConnection(dbType);
        }

        public void Close()
        {
            _conn.Close();
        }

        public void Execute(string query)
        {
            _conn.Execute(query);
        }

        public string GetConnString()
        {
            return _conn.ConnString;
        }

        public string Ping()
        {
            return _conn.Ping();
        }
    }
}
