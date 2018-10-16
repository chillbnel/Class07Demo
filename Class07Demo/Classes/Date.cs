using System;
using System.Collections.Generic;
using System.Text;

namespace Class07Demo.Classes
{
    class Date
    {
        public Days DayOfWeek { get; set; } //rather than a day use set type of cards (hearts, spades, clubs, diamonds)
    }

    enum Days //auto sets the index at 0 eg Monday = 0
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
