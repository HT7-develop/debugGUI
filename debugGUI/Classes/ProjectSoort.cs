using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugGUI.classes
{
    internal class ProjectSoort
    {
        public int Id { get; }
        public string Beschrijving { get; set; }
        public string Naam { get; set; }

        public ProjectSoort(int id, string beschrijving, string naam)
        {
            Id = id;
            Beschrijving = beschrijving;
            Naam = naam;
        }
    }
}
