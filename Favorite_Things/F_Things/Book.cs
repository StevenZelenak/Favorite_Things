using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.F_Things
{
    class Book
    {
        //Properties
        public string Name { get; set; }
        public int YearPrinted { get; set; }

        //Fields
        private bool _isOlder = false;

        //constructor
        public Book(string name, int yearprinted)
        {
            Name = name;
            YearPrinted = yearprinted;
            Console.WriteLine($"Your book name is {name} and the year it was made is {yearprinted}");
        }

        //Method
        public void CheckIfOlderBook()
        {
            if(YearPrinted < 1960)
            {
                _isOlder = true;
            }
            else
            {
                _isOlder = false;
            }
        }

        public void BookYearStatement()
        {
            if(_isOlder)
            {
                Console.WriteLine("This book is old as shit");
            }
            else
            {
                Console.WriteLine("This is a newer book");
            }
        }

    }
}
