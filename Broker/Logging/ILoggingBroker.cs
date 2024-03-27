﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CRUD.Broker.Logging
{
    internal interface ILoggingBroker
    {
        void LogInformaton(string message);
        void LogError(string userMessage);
    }
}
