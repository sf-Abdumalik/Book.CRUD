using Book.CRUD.Broker.Storeage;
using System;
using System.Linq.Expressions;

IStoreageBroker storeageBroker = new ArrayStoreageBroker();
var book = storeageBroker.ReadBook(1);
Console.WriteLine($"{book.Id}. {book.Name}. {book.Author}");