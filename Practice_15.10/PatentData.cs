using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice_15._10
{
    public static class PatentData
    {
        public static readonly Inventor[] Inventors = new Inventor[]
        {
            new Inventor(){ Id = 1, Name = "Benjamin Franklin", Country = "USA", State = "PA", City = "philadelphia" },
            new Inventor(){ Id = 2, Name = "Orville Wright", Country = "USA", State = "NC", City = "Kitty Hawk" },
            new Inventor(){ Id = 3, Name = "Wilbur Wright", Country = "USA", State = "NC", City = "Kitty Hawk" },
            new Inventor(){ Id = 4, Name = "Samuel Morse", Country = "USA", State = "NC", City = "New York" },
            new Inventor(){ Id = 5, Name = "George Stephenson", Country = "UK", State = "Northumberland", City = "Wylam" },
            new Inventor(){ Id = 6, Name = "John Michaelis", Country = "USA", State = "IL", City = "Chicago" },
            new Inventor(){ Id = 7, Name = "Mary Phelps Jacob", Country = "USA", State = "NY", City = "New York" }
        };
        public static readonly Patent[] Patents = new Patent[] 
        {
            new Patent(){ Title = "Bifocals", YearOfPublication = "1784", ApplicationNumber = "1", InventorIds =new long[]{1} },
            new Patent(){ Title = "Phonograph", YearOfPublication = "1877", ApplicationNumber = "2", InventorIds =new long[]{1} },
            new Patent(){ Title = "Kinetoscope", YearOfPublication = "1888", ApplicationNumber = "3", InventorIds =new long[]{1} },
            new Patent(){ Title = "Electrical Telegraph", YearOfPublication = "1837", ApplicationNumber = "4", InventorIds =new long[]{4} },
            new Patent(){ Title = "Flying Machine", YearOfPublication = "1903", ApplicationNumber = "5", InventorIds =new long[]{2, 3} },
            new Patent(){ Title = "Steam Locomotive", YearOfPublication = "1815", ApplicationNumber = "6", InventorIds =new long[]{5} },
            new Patent(){ Title = "Froplet Deposition", YearOfPublication = "1989", ApplicationNumber = "7", InventorIds =new long[]{6} },
            new Patent(){ Title = "Backless Brassiere", YearOfPublication = "1914", ApplicationNumber = "8", InventorIds =new long[]{7} }
        };
    }
}
