using ExercicioPatterns.Resources.DbOrigins.Contracts;

namespace ExercicioPatterns.Resources.DbOrigins.Implementations
{
    class FileOrigin : IDbOrigin
    {
        public DbInfo GetDbInfo()
        {
            var fileMock = "host=192.68.0.1;port=3666;username=userFile;password=passFile;database=FileDatabase";
            var splittedFileMock = fileMock.Split(';');
            return new DbInfo
            {
                Host = splittedFileMock[0].Substring(5),
                Port = int.Parse(splittedFileMock[1].Substring(5)),
                User = splittedFileMock[2].Substring(9),
                Password = splittedFileMock[3].Substring(9),
                Database = splittedFileMock[4].Substring(9)
            };
        }
    }
}
