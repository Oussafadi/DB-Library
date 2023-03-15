namespace DataAccess
{
    internal class Note : Model 
    {
        public string id_elve = ""; 
        public string id_mat = "";
        public float note = 0;

        public override string ToString()
        {
            return $" note de l'Eleve avec le code: {id_elve} dans la matiere  {id_mat} est : {note}";
        }
    }
}
