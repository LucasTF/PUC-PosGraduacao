using ExercicioPatterns.Database.Repository.Contract;
using System;

namespace ExercicioPatterns.Database.Repository.Implementation
{
    sealed class Connection : IConnection
    {
        public string ConnString {get; set;}

        private static IConnection _instance;

        private Connection(string connString)
        {
            ConnString = connString;
        }

        private Connection()
        {

        }

        public static IConnection GetInstance(string connString)
        {
            if(_instance == null)
            {
                _instance =  new Connection(connString);
            }
            else
            {
                _instance.ConnString = connString;
            }
            return _instance;
        }

        public void Close()
        {
            Console.WriteLine("Connection Closed.");
        }

        public void Execute(string query)
        {
            Console.WriteLine("Executed Query : {0}", query);
        }

        public void Open()
        {
            Console.WriteLine("Connection Opened.");
        }

        public string Ping()
        {
            return "Pong";
        }
    }
}
