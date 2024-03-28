using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.CRUD.Models;

namespace Book.CRUD.Broker.Storeage
{
    interface IStoreageBroker
    {
        Books ReadBook(int id);
    }
}
