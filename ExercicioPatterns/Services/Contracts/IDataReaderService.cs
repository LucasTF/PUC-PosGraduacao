using ExercicioPatterns.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPatterns.Services.Contracts
{
    interface IDataReaderService
    {
        string GetInfoString(DbInfoTypeEnum infoType);
    }
}
