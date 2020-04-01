namespace GitExercise
{
    class myClass
    {
        public myClass(string navn, string adresse, int postnummer)
        {
            this.Navn = navn;
            this.Adresse = adresse;
            this.Postnummer = postnummer;
        }
        public string Navn
        {
            get;
            set;
        }
        public string Adresse
        {
            get;
            set;
        }
        public int Postnummer
        {
            get;
            set;
        }
    }
}