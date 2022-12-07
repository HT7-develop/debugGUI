using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugGUI
{
    internal class Werknemer
    {
        public int id;
        public string naam;

        public int Id { get; }
        public string Naam { get; set;  }

        public Werknemer(int id, string naam) //constructor
        {
            Id = id;
            Naam = naam;
        }
    }
}
