using Book.CRUD.Broker.Storeage;
using Book.CRUD.Service;
using System;
using System.Linq.Expressions;

IBookService bookService = new BookService();
var book = bookService.GetBook(1);
Console.WriteLine($"{book.Id}. {book.Name}. {book.Author}");