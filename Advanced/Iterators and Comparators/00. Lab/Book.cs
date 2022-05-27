using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public override string ToString() => $"{Title} - {Year}";

        public int CompareTo([AllowNull] Book other)
        {
            if(Year > other.Year)
            {
                return 1;
            }
            else if(Year < other.Year)
            {
                return -1;
            }
            else
            {
                return Title.CompareTo(other.Title);
            }
        }
    }
}
