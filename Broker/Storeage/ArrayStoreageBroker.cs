using Book.CRUD.Models;
using System.Reflection;


namespace Book.CRUD.Broker.Storeage
{
    public class ArrayStoreageBroker : IStoreageBroker
    {
        private Books[] BooksInfo { get; set; } = new Books[10];
        
        public ArrayStoreageBroker() 
        {
            BooksInfo[0] = new Books()
            {
                Id = 1,
                Name = "O'tgan kunlar",
                Author = "Abdulla Qodiriy"
            };
            BooksInfo[1] = new Books()
            {
                Id = 2,
                Name = "Shum bola",
                Author = "G'afur G'ulom"
            };
        }
        public Books ReadBook(int id)
        {
            for (int itaration  = 0; itaration < BooksInfo.Length; itaration++)
            {
                Books bookInfoLine = BooksInfo[itaration];
                if (bookInfoLine.Id == id)
                {
                return bookInfoLine;
                }
{}
            }
            return new Books();
        }
    }
}
