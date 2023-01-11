using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugGUI.classes
{
    public class DeelTaak
    {
        public string beschrijving { get; private set; }
        public string titel { get; private set; }
        public string status { get; private set; }
        public int looptijd { get; private set; }
        public int id { get; private set; }
        public string rol { get; private set; }
        public DeelTaak? opvolger_id { get; private set; } = null;

        public DeelTaak(string titel,string beschrijving, string rol, DeelTaak? opvolger_id, int looptijd, string status)
        {
            this.titel = titel;
            this.looptijd = looptijd;
            this.status = status;
            this.beschrijving = beschrijving;
            this.rol = rol;
            this.opvolger_id = opvolger_id;
        }
    }
}
