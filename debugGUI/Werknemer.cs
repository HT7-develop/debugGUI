using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugGUI
{
    internal class Werknemer
    {
        public int Id { get; }
        public string Naam { get; set;  }

        public Werknemer(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }
    }
}
