using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugGUI.Classes
{
    public class DeelTaak
    {
        public String beschrijving { get; private set; }
        public int id { get; private set; }
        public int tijdInDagen { get; private set; }
        public string rol { get; private set; }
        public DeelTaak? voorgaandeTaak { get; private set; } = null;

        public DeelTaak(string beschrijving, int id, int tijdInDagen, string rol, DeelTaak? voorgaandeTaak)
        {
            this.beschrijving = beschrijving;
            this.id = id;
            this.tijdInDagen = tijdInDagen;
            this.rol = rol;
            this.voorgaandeTaak = voorgaandeTaak;
        }
    }
}
