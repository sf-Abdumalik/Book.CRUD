﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CRUD.Broker.Storeage
{
    interface IStoreageBroker
    {
        Books ReadBook(int id);
    }
}
