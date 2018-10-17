using System;
using Class07Demo.Classes;
using System.Collections.Generic;

namespace Class07Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Days saturday = Days.Saturday;
            //Console.WriteLine(saturday);
            //Console.WriteLine((int)saturday);

            GenericExamples();

        }

        static void GenericExamples()
        {
            string[] myArray = new string[5];

            List<string> myCat = new List<string>();

            myCat.Add("Joise");
            myCat.Add("Belle");
            myCat.Add("Matilda");
            myCat.Add("Flash");
            myCat.Add("Kimchi");

            foreach (string cat in myCat)
            {
                Console.WriteLine(cat);
            }

            myCat.Remove("Belle");

            Console.WriteLine("==============");
            foreach (string cat in myCat)
            {
                Console.WriteLine(cat);
            }

        }

        static void LibraryExample()
        {
            Book book 
        }
    }
}
