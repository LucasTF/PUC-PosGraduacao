﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPatterns.Resources
{
    class DbInfo
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        public DbInfo()
        {

        }
    }
}
