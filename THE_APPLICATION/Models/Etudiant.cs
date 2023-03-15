
using DataAccess;

namespace MODELES {

    internal class Etudiant : Model
    {
        public string code, nom, prenom, niveau, code_fil;

      // public Etudiant() { this.niveau = "AP1"; }
        public override string ToString()
        {
            return "nom :" + nom + " niveau :" + niveau ;
        }
    }

    
}
