using debugGUI.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugGUI.classes
{
    internal class ProjectSoort
    {
        //public int Id { get; }
        //public string Beschrijving { get; set; }
        //public string Naam { get; set; }

        //public ProjectSoort(int id, string beschrijving, string naam)
        //{
        //    Id = id;
        //    Beschrijving = beschrijving;
        //    Naam = naam;
        //}


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
        public bool wijzigDeelTaak(DeelTaak DeelTaak, string titel, string beschrijving, int id, int tijdInDagen, string rol, DeelTaak? opvolger_id, int looptijd, string status)
        {
            if (deelTaken.Contains(DeelTaak))
            {
                deelTaken.Remove(DeelTaak);
                DeelTaak gewijzigdeDeelTaak = new DeelTaak(titel,beschrijving, rol,opvolger_id, looptijd, status);
                deelTaken.Add(gewijzigdeDeelTaak);
                return true;
            }
            else return false;
        }

        /* Berekent de de duur van een (opeenvolging van) DeelTaak
         * 
         * Geeft een integer getal terug. Dit getal is de som van de
         * duur van DeelTaak + voorgaande taken OF de duur van DeelTaak
         * als deze geen voorgaande taken heeft
         */
        //private int getTakenDuur(DeelTaak DeelTaak)
        //{
        //    if (DeelTaak.opvolger_id == null) // DeelTaak staat los. Dus TakenDuur == duur van deze taak
        //    {
        //        return DeelTaak.tijdInDagen;
        //    }
        //    else // Taak heeft voorgaande taken. Dus TakenDuur == duur van deze taak + duur van voorgaande taken
        //    {
        //        return DeelTaak.tijdInDagen + getTakenDuur(DeelTaak.opvolger_id);
        //    }
        //}

        /* Berekent de doorlooptijd van deze projectsoort
         * 
         * De doorlooptijd is gelijk aan de totale duur
         * van de langste opeenvolging van taken OF, als een losse taak
         * langer duurt dan de langste opeenvolgende reeks van taken, de duur
         * van deze taak
         * 
         * Geeft een integer getal. Dit getal is de doorlooptijd
         * van deze projectsoort
         */
        //public int berekenDoorlooptijd()
        //{
        //    int doorlooptijd = 0;

        //    foreach (DeelTaak DeelTaak in deelTaken)
        //    {
        //        int tijdsduur = getTakenDuur(DeelTaak);

        //        if (tijdsduur > doorlooptijd) doorlooptijd = tijdsduur;
        //    }

        //    return doorlooptijd;
        //}

        /* Berekent de som van de duur van alle deeltaken 
         * 
         * Geeft een integer getal terug. Dit getal is de som van de
         * duur van alle deeltaken in de lijst deelTaken
         */
        //public int berekenTotaalUren()
        //{
        //    int totaalUren = 0;

        //    foreach (DeelTaak DeelTaak in deelTaken)
        //    {
        //        totaalUren += DeelTaak.tijdInDagen;
        //    }

        //    return totaalUren;
        //}
    }
}
