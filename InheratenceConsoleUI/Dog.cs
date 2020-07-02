using System;
using System.Collections.Generic;
using System.Text;

namespace InheratenceConsoleUI
{
    public class Dog : Animal //this has the smae properties as Animal + the others.
    {
        public string OwnerName { get; set; }
        public string FavorateToy { get; set; }

        public Dog()
        {

        }
    }
}
