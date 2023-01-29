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
        public int rol { get; private set; }
        public List<string>? opvolgers { get; private set; } = null;

        public DeelTaak(string titel, string beschrijving, int rol, List<string> opvolgers, int looptijd, string status)
        {
            this.titel = titel;
            this.looptijd = looptijd;
            this.status = status;
            this.beschrijving = beschrijving;
            this.rol = rol;
            this.opvolgers = opvolgers;
        }

        public void SaveDT(DeelTaak dt)
        {

        }
    }
}