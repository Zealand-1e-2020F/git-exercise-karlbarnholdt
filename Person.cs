namespace GitExercise
{
    class Person
    {
        public Person(string navn, string adresse, int postnummer)
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
        public void NewName(string nytNavn)
        {
            this.Navn = nytNavn;
        }
        public override string ToString()
        {
            return $"Navnet er {this.Navn}. Adressen er {this.Adresse}, {this.Postnummer}.";
        }
    }
}