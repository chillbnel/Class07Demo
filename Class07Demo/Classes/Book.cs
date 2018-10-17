using System;
using System.Collections.Generic;
using System.Text;

namespace Class07Demo.Classes
{
    class Book
    {
        public Genre Genre { get; set; }
        public string Title { get; set; }
        public int NumPages { get; set; }
    }

    enum Genre
    {
        SciFi,
        Romance,
        Classics
    }
}
