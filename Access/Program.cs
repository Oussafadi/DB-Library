using DataAccess;
using MODELES;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Windows.Forms;

public class Program
{
    public static void Main(string[] args)
    {
        Connexion.file = "C:\\Users\\joudia\\Desktop\\Data\\.env";
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
        rules["code_filiere"] = "GINF";
        rules["niveau"] = "1";

        foreach (Module module in Model.select<Module>(rules)) {

            Dictionary<string, object> rules_matiere = new Dictionary<string, object>();
            
            rules_matiere["code_module"] = module.code;
            foreach (Matiere matiere in Model.select<Matiere>(rules_matiere))
            {

                System.Console.WriteLine(matiere.designation);
            }
        }

    }
}
