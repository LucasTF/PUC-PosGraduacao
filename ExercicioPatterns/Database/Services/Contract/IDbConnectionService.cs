namespace ExercicioPatterns.Database.Services.Implementation
{
    interface IDbConnectionService
    {
        void Close();
        string Ping();
        void Execute(string query);
        string GetConnString();
    }
}
