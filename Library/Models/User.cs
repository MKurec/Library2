using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
   public class User
   {
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public List<int> LentBooks = new();

        public User(string name, string lastName)
        {
            Id=Guid.NewGuid();
            SetName(name);
            SetLastName(lastName);
        }
        public User(Guid id,string name, string lastName)
        {
            Id = id;
            SetName(name);
            SetLastName(lastName);
        }
        public void SetName(string str)
        {
            Name = String.IsNullOrEmpty(str) ? throw new Exception($"Name : {str} should contain at least one character") : str;
        }
        public void SetLastName(string str)
        {
            LastName = String.IsNullOrEmpty(str) ? throw new Exception($"Last Name : {str} should contain at least one character") : str;
        }
        public void RentBook(Book book)
        {
            if (LentBooks.Contains(book.ISBN))
                throw new Exception($"User already rented this book ({book.Title})");
            LentBooks.Add(book.ISBN);
            book.Borrow();
        }
        public void EndRental(Book book)
        { 
            if(!LentBooks.Contains(book.ISBN))
                throw new Exception($"User doesn't rented this book ({book.Title})");
            LentBooks.Remove(book.ISBN);
            book.Return();
        }

    }
}
