using debugGUI.classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugGUI.classes
{
    internal class ProjectSoort
    {

        static dbConnection dbConnection = new dbConnection();
        SqlConnection conn = new SqlConnection(dbConnection.ConnectionString);

        public string naam { get; }
        public List<DeelTaak> deelTaken { get; private set; } = new List<DeelTaak>();

        public ProjectSoort(string naam)
        {
            this.naam = naam;
        }

        /* Voeg een DeelTaak toe aan deze projectsoort
         * 
         * Geeft /true/ als de nieuwe taak valide is
         * en voegt deze nieuwe taak toe aan deze projectsoort
         * 
         * Geeft /false/ terug wanneer de id van de nieuwe taak
         * al bestaat binnen het project en voegt de taak niet
         * toe aan deze projectsoort
         */
        public bool addDeelTaak(DeelTaak nieuweDeelTaak)
        {
            foreach (DeelTaak DeelTaak in deelTaken)
            {
                if (DeelTaak.id == nieuweDeelTaak.id) // id van nieuwe taak is niet uniek binnen het project
                {
                    return false;
                }
            }
            deelTaken.Add(nieuweDeelTaak);
            return true;
        }

        /* Verwijder een DeelTaak uit deze projectsoort
         * 
         * Geeft /true/ als DeelTaak bestaat binnen deze projectsoort
         * en verwijderd deze uit deze projectsoort
         * 
         * Geeft /false/ terug wanneer DeelTaak niet bestaat binnen deze
         * projectsoort
         */
        public bool removeDeelTaak(DeelTaak DeelTaak)
        {
            if (deelTaken.Contains(DeelTaak))
            {
                deelTaken.Remove(DeelTaak);
                return true;
            }
            else return false;
        }

        /* Wijzig een DeelTaak uit deze projectsoort
         * 
         * Geeft /true/ als DeelTaak bestaat binnen deze projectsoort
         * en wijzigt deze op basis van de meegegeven parameters. De
         * gewijzigde taak behoudt zijn oorspronkelijke id.
         * 
         * Geeft /false/ terug wanneer DeelTaak niet bestaat binnen deze
         * projectsoort
         */
        //public bool wijzigDeelTaak(DeelTaak DeelTaak, string titel, string beschrijving, int id, int tijdInDagen, string rol, List<DeelTaak> opvolgers, int looptijd, string status)
        //{
        //    if (deelTaken.Contains(DeelTaak))
        //    {
        //        deelTaken.Remove(DeelTaak);
        //        DeelTaak gewijzigdeDeelTaak = new DeelTaak(titel, beschrijving, rol, opvolgers, looptijd, status);
        //        deelTaken.Add(gewijzigdeDeelTaak);
        //        return true;
        //    }
        //    else return false;
        //}

        //public int berekenDoorlooptijd()
        //{

        //    int doorlooptijd = 0;

        //    foreach (DeelTaak DeelTaak in deelTaken)
        //    {

        //    }

        //    return doorlooptijd;
        //}

        //public int berekenDoorlooptijd(DeelTaak taak)
        //{
        //    if (taak.opvolgers.Count == 0) return taak.looptijd;
        //    else if (taak.opvolgers.Count == 1)
        //    {
        //        int totaal = taak.looptijd;
        //        foreach (DeelTaak opvolger in taak.opvolgers)
        //        {
        //            totaal += berekenDoorlooptijd(opvolger);
        //        }
        //        return totaal;
        //    }
        //    else
        //    {
        //        int maximum = 0;
        //        int branch = 0;
        //        foreach (DeelTaak opvolger in taak.opvolgers)
        //        {
        //            branch = berekenDoorlooptijd(opvolger);
        //            if (branch >= maximum)
        //            {
        //                maximum = branch;
        //            }
        //        }
        //        return maximum + taak.looptijd;
        //    }
        //}
    }
}