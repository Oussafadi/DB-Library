namespace DataAccess
{
    internal class Note : Model 
    {
        public string code_eleve = ""; 
        public string code_matiere = "";
        public float note = 0;

        public override string ToString()
        {
            return $" note de l'Eleve avec le code: {code_eleve} dans la matiere  {code_matiere} est : {note}";
        }
    }
}
