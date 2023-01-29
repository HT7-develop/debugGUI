namespace debugGUI.classes
{
    internal class Taak
    {

        public int Id { get; private set; }
        public DeelTaak deeltaak { get; private set; }
        public Werknemer projectLid { get; private set; }
      

        public Taak(int id, DeelTaak deeltaak, Werknemer projectLid)
        {
            this.Id = id;
            this.deeltaak = deeltaak;
            this.projectLid = projectLid;
        }
    }
}
