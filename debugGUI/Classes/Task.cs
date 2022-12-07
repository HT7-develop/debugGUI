using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace debugGUI.classes
{
    internal class Task
    {

        public int Id { get; }
        public string Beschrijving { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public int Looptijd { get; set; }
        public int Opvolger_Id { get; set; }
        public int Project_Id { get; set; }
        public int Gebruikte_Uren { get; set; }
        public int Werknemer_Id { get; set; }

        public Task(int id, string beschrijving, string title, string status, int looptijd, int opvolger_id, int project_id, int gebruikte_uren, int werknemer_id)
        {
            Id = id;
            Beschrijving = beschrijving;
            Title = title;
            Status = status;
            Looptijd = looptijd;
            Opvolger_Id = opvolger_id;
            Project_Id = project_id;
            Gebruikte_Uren = gebruikte_uren;
            Werknemer_Id = werknemer_id;

        }
    }
}
