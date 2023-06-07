using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic
{
   public static class RentalLogic
   {
        public static void RentBook(int iSBN,Guid id)
        {
            var book= BookRepository.GetBook(iSBN);
            var user = UsersRepositoriy.GetUser(id);
            if (!book.CanBorrow())
            {
                throw new Exception("Not enough books, all borrowed");
            }
            user.RentBook(book);
        }
        public static void EndRental(int iSBN, Guid id)
        {
            var book = BookRepository.GetBook(iSBN);
            var user = UsersRepositoriy.GetUser(id);
            user.EndRental(book);
        }
    }
}
