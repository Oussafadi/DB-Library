namespace DataAccess
{
    public class Eleve : Model
    {
        
        public string code = "";
        public string nom = "";
        public string prenom = "";
        public string niveau = "";
        public string code_filiere = "";

      // public Etudiant() { this.niveau = "AP1"; }
        public override string ToString()
        {
            return "nom :" + nom + " niveau :" + niveau ;
        }
    }

    
}
