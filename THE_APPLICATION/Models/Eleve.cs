namespace DataAccess
{
    internal class Eleve : Model
    {
        public string code = "";
        public string nom = "";
        public string prenom = "";
        public string niveau = "";
        public string id_fil = "";

      // public Etudiant() { this.niveau = "AP1"; }
        public override string ToString()
        {
            return "nom :" + nom + " niveau :" + niveau ;
        }
    }

    
}
