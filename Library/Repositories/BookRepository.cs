using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
   public static class BookRepository
   {
        public static readonly HashSet<Book> Books = new()
        {
            new Book (12345678,"GoodBook1","GoodAuthor1",5),
            new Book (22345678,"GoodBook2","GoodAuthor2",2),
            new Book (32345678,"GoodBook3","GoodAuthor2",5),
            new Book (42345678, "GoodBook4", "GoodAuthor2", 5)
        };

        public static Book GetBook(int iSBN)
        {
            return Books.SingleOrDefault(x => x.ISBN == iSBN) ?? throw new Exception($"Book with ISBN {iSBN} not found");
        }
   }
}
