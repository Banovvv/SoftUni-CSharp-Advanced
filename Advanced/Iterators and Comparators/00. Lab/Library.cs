using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
            Books.Sort();
        }

        public List<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private int currentIndex;
            private List<Book> books;

            public LibraryIterator(List<Book> books)
            {
                Reset();
                this.books = books;
            }

            public Book Current => books[currentIndex];

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                ++currentIndex;

                return currentIndex < books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public void Dispose()
            {
               
            }
        }
    }
}
