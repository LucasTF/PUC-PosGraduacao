namespace ExercicioPatterns.Database.Repository.Contract
{
    interface IConnection
    {
        string ConnString { get; set; }
        void Open();
        void Close();
        string Ping();
        void Execute(string query);
    }
}
