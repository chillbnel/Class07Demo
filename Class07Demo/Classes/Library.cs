using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Class07Demo.Classes
{
    class Library <T> : IEnumerable // T for type... industry standard
    {
        T[] books = new T[5];//this is for initial memory allocation
        int count = 0;

        public void Add(T book)
        {
            if(count == books.Length)
            { 
                Array.Resize(ref books, 2 * books.Length);
            }
            books[count++] = book; //adds the book then iterates after book added
        }

    }

    //look at code to see what goes here...
}
