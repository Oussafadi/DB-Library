using DataAccess;
using System.Collections.Generic;
using System.Security;

public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("DataAccess");

        //Filiere ap = new Filiere();
        //ap.code = "AP";
        //ap.id = 1;
        //ap.save();


        //Eleve e7 = new Eleve();
        //e7.code = "1234";
        //e7.nom = "o";
        //e7.prenom = "fadil";
        //e7.niveau = "AP1";
        //e7.code_filiere = "AP";
        //e7.save();  // Procedure update Marche bien

        //Module m = new Module();
        //m.code = "2";
        //m.niveau = "3";
        //m.code_filiere = "1";
        //m.id = 1;
        //m.save();

        Dictionary<string, object> rules = new Dictionary<string, object>();
        rules["code_matiere"] = "AP111";

        Model.select<Note>(rules);
        
        foreach (Note note in Model.select<Note>(rules)) {
            System.Console.WriteLine(note);
        }

        foreach (Filiere filiere in Model.all<Filiere>())
        {
            System.Console.WriteLine(filiere.code);
        }

    }
}
