﻿using DataAccess;

public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("DataAccess");
        // Connexion.Connect();
        // Model m1 = new Model("test object to dictionnary");
        //var dico =  m1.ObjectToDictionary<object>(m1);
        // dynamic obj = m1.DictionaryToObject(dico);
        // int id = obj.id;
        // Console.WriteLine(id);

        // test procedure save  , test procedure delete et update

        //Etudiant e6 = new Etudiant();
        // e6.id = 10;
        //  e6.delete("EtudiantDelete");  // Procedure Delete Marche bien

        Eleve e7 = new Eleve();
        e7.code = "1234";
        e7.nom = "o";
        e7.prenom = "fadil";
        e7.niveau = "GINF2";
        e7.id_fil = "1";
        e7.id = 1;
        e7.save();  // Procedure update Marche bien

        Module m = new Module();
        m.code = "2";
        m.niveau = "3";
        m.id_filiere = "1";
        m.id = 1;
        m.save();

        //e6.code = "5355";
        //e6.nom = "Oussamatest";
        //e6.prenom = "Fadiltest";
        //e6.niveau = "GINF2";
        //e6.code_fil = "1";
        //e6.save();

        //dynamic res = e6.find();
        //Console.WriteLine(res.ToString());

        // e0.save("etudiantINSERT");       // Procedure Insert Marche bien

        // Console.WriteLine(e0.find());

        // Test Save()

        //Etudiant e1 = new Etudiant();
        //e1.code = "123";
        //e1.nom = "Oussama";
        //e1.prenom = "Fadil";
        //e1.niveau = "GINF2";
        //e1.code_fil = "1";
        //e1.save();

        //Etudiant e2 = new Etudiant();
        //e2.code = "124";
        //e2.nom = "Yassine";
        //e2.prenom = "Jellouli";
        //e2.niveau = "GINF2";
        //e2.code_fil = "1";
        //e2.save();

        //Etudiant e3 = new Etudiant();
        //e3.code = "125";
        //e3.nom = "Iliass";
        //e3.prenom = "Khayat";
        //e3.niveau = "GINF2";
        //e3.code_fil = "1";
        //e3.save();

        //Etudiant e4 = new Etudiant();
        //e4.code = "126";
        //e4.nom = "Lagzal";
        //e4.prenom = "Mohamed";
        //e4.niveau = "GINF2";
        //e4.code_fil = "1";
        //e4.save();



        // Test All()

        //Etudiant e3 = new Etudiant();
        //dynamic list = e3.All();
        //foreach (var etd in list)
        //{
        //    Console.WriteLine(etd.ToString());
        //}

        //  Test Find()

        //Etudiant e4 = new Etudiant();
        //e4.id = 12346;
        //dynamic res = e4.find();
        //Console.WriteLine(res.ToString());

        // Test Find<T>(id)

        //dynamic res2 = Etudiant.find<Etudiant>(12346);
        //Console.WriteLine(res2.ToString());

        //  TEST all<T>()

        //dynamic res3 = Etudiant.all<Etudiant>();
        //foreach (var etd in res3)
        //{
        //    Console.WriteLine(etd.ToString());
        //}
    }
}
