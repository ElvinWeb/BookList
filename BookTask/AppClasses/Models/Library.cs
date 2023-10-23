using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClasses.Models
{
    public class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            this.Books = new List<Book>();
        }

        public List<Book> FindAllBooksByName(string name)
        {
            List<Book> filteredBooks = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Name.Equals(name.Trim()))
                {
                    filteredBooks.Add(book);
                }
            }
            return filteredBooks;
        }

        public void RemoveAllBooksByName(string name)
        {
            foreach (Book book in Books)
            {
                if (book.Name.Equals(name.Trim()))
                {
                    Books.RemoveAll(book => book.Name.Equals(name.Trim()));
                }
            }
        }

        public List<Book> SearchBooks(string searchValue)
        {
            List<Book> filteredBooks = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Name.Contains(searchValue.Trim()) ||
                    book.AuthorName.Contains(searchValue.Trim()) ||
                    book.PageCount.ToString().Contains(searchValue.Trim()))
                {
                    filteredBooks.Add(book);
                }
            }
            return filteredBooks;
        }

        public List<Book> FindAllBooksByPageCountRange(int minPageCount, int maxPageCount)
        {
            List<Book> filteredBooks = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.PageCount >= minPageCount && book.PageCount <= maxPageCount)
                {
                    filteredBooks.Add(book);
                }
            }
            return filteredBooks;
        }

        public void RemoveBookByCode(string value)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Code.Equals(value.Trim()))
                {
                    Books.RemoveAt(i);
                }
            }
        }


    }
}
