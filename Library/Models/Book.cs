using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
   public class Book
   {
        public int ISBN { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }

        public ushort Quantity { get; private set; }
        public ushort NumberOfLentBooks { get; private set; }


        public Book(int iSBN, string title, string author, ushort quantity)
        {
            SetISBN(iSBN);
            Title = title;
            Author = author;
            Quantity = quantity;
            NumberOfLentBooks = 0;
            
        }
        public bool CanBorrow() => Quantity > NumberOfLentBooks;

        public void SetISBN(int iSBN)
        {
                ISBN = (9999999 < iSBN && iSBN < 100000000) ? iSBN : throw new Exception($"Wrong ISBN : {iSBN}, ISBN should be 8 digits");
        }
        public void SetAuthor(string author)
        {
            Author = String.IsNullOrEmpty(author) ? throw new Exception($"Author : {author} should contain at least one character") : author;
        }
        public void SetTitle(string title)
        {
            Title = String.IsNullOrEmpty(title) ? throw new Exception($"Title : {title} should contain at least one character") : title;
        }

        internal void Borrow()
        {
            NumberOfLentBooks++;
        }

        internal void Return()
        {
            NumberOfLentBooks--;
        }
    }
}
