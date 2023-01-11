namespace debugGUI.classes
{
    internal class Taak
    {

        public int Id { get; private set; }
        public DeelTaak deeltaak { get; private set; }
        public Werknemer projectLid { get; private set; }
        //public string Beschrijving { get; set; }
        //public string Title { get; set; }
        //public string Status { get; set; }
        //public int Looptijd { get; set; }
        //public int Opvolger_Id { get; set; }
        //public int Project_Id { get; set; }
        //public int Gebruikte_Uren { get; set; }
        //public int Werknemer_Id { get; set; }

        public Taak(int id, DeelTaak deeltaak, Werknemer projectLid)
        {
            this.Id = id;
            this.deeltaak = deeltaak;
            this.projectLid = projectLid;
            //Beschrijving = beschrijving;
            //Title = title;
            //Status = status;
            //Looptijd = looptijd;
            //Opvolger_Id = opvolger_id;
            //Project_Id = project_id;
            //Gebruikte_Uren = gebruikte_uren;
            //Werknemer_Id = werknemer_id;

        }
    }
}
