using DataAccess;

namespace MODELES
{
    internal class Note : Model 
    {
        public string code_elv, code_mat;
        public float note;

        public override string ToString()
        {
            return $" note de l'Eleve avec le code: {code_elv} dans la matiere  {code_mat} est : {note}";
        }
    }
}
