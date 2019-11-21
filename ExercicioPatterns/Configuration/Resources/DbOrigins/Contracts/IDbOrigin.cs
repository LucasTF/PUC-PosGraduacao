using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPatterns.Resources.DbOrigins.Contracts
{
    interface IDbOrigin
    {
        DbInfo GetDbInfo();
    }
}
