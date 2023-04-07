using MySql.Data.MySqlClient;
using System.Data;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DataAccess
{
    public class Model
    {
        public int id = 0;
        private string sql = "";
        public static string xml_path = "";

        public Model()
        {
            Connexion.Connect();
        }

        //public Model(string sql)
        //{ this.sql = sql; }
        static public Dictionary<string, T> ObjectToDictionary<T>(object obj)
        {
            var attributs = new Dictionary<string, T>();
            FieldInfo[] objFields = obj.GetType().GetFields();
            for (int i = 0; i < objFields.Length; i++)
            {
                //  if (objFields[i].Name == "id") continue;
                //  Console.WriteLine(objFields[i].Name + ": " + objFields[i].GetValue(obj).ToString());
                attributs.Add(objFields[i].Name, (T)(Convert.ChangeType(objFields[i].GetValue(obj), typeof(T))));

            }
            return attributs;
        }

        public dynamic DictionaryToObject(Dictionary<String, object> dico)
        {
            if (dico.Keys.Count == 0) return null;

            Type type = this.GetType();
            var obj = Activator.CreateInstance(type);

            foreach (var kv in dico)
            {
                FieldInfo info = type.GetField(kv.Key);

                info.SetValue(obj, Convert.ChangeType(kv.Value, info.FieldType));
            }
            return Convert.ChangeType(obj, this.GetType());
        }
        public static dynamic DictionaryToObject<T>(Dictionary<String, object> dico)
        {
            if (dico.Keys.Count == 0) return null;

            Type type = typeof(T);
            var obj = Activator.CreateInstance(type);

            foreach (var kv in dico)
            {
                FieldInfo info = type.GetField(kv.Key);

                info.SetValue(obj, Convert.ChangeType(kv.Value, info.FieldType));
            }
            return Convert.ChangeType(obj, typeof(T));
        }

        public int save(string proc = null)
        {
            Dictionary<string, string> dico = new Dictionary<string, string>();
            dico = Model.ObjectToDictionary<string>(this);
            string requete = "";

            if (id == 0)
            { // insert
                if (proc != null)
                {
                    requete = proc;
                    Connexion.cmd.CommandType = CommandType.StoredProcedure;
                    Connexion.cmd.Parameters.Clear();
                    foreach (KeyValuePair<string, string> atr in dico)
                    {

                        
                        Connexion.cmd.Parameters.Add(new MySqlParameter(atr.Key, atr.Value));
                    }

                }
                else
                {
                    Connexion.cmd.CommandType = CommandType.Text;
                    requete = "INSERT INTO " + this.GetType().Name + "(";
                    FieldInfo[] fields = this.GetType().GetFields();
                    for (int i = 0; i < fields.Length; i++)
                    {
                        if (fields[i].Name == "id") continue;
                        requete += fields[i].Name + ",";
                    }
                    requete = requete.Remove(requete.Length - 1);

                    requete += ") VALUES(";
                    foreach (var atr in dico)
                    {
                        if (atr.Value == "0") continue;
                        if (atr.Value is string)
                        {
                            requete += " '" + atr.Value + "' ,";
                        }
                        else
                        {
                            requete += " " + atr.Value + " ,";
                        }
                    }
                    requete = requete.Remove(requete.Length - 1);
                    requete += ");";
                    // test 
                    Console.WriteLine(requete);
                }
            }
            if (id != 0)
            { // update 

                if (proc != null)
                {
                    requete = proc;
                    Connexion.cmd.CommandType = CommandType.StoredProcedure;
                    Connexion.cmd.Parameters.Clear();
                    foreach (KeyValuePair<string, string> atr in dico)
                    {

                        
                        Connexion.cmd.Parameters.Add(new MySqlParameter(atr.Key, atr.Value));

                    }

                }
                else
                {
                    Connexion.cmd.CommandType = CommandType.Text;

                    requete = "UPDATE " + this.GetType().Name + " SET";

                    foreach (var atr in dico)
                    {

                        if (atr.Value is string)
                        {
                            requete += " " + atr.Key + "='" + atr.Value + "',";
                        }
                        else
                        {
                            requete += " " + atr.Key + "=" + atr.Value + " , ";
                        }
                    }
                    requete = requete.Remove(requete.Length - 1);
                    requete += " WHERE id =" + id + ";";
                    // test 
                    Console.WriteLine(requete);
                }
            }

            return Connexion.IUD(requete);

        }
        public dynamic find()
        {
            Dictionary<string, Object> dico = new Dictionary<string, Object>();
            // dico = ObjectToDictionary<object>(this);

            sql = "SELECT * FROM " + this.GetType().Name + " WHERE id=" + id;
            // Console.WriteLine(sql);

            IDataReader rd = Connexion.Select(sql);
            while (rd.Read())
            {
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    dico.Add(rd.GetName(i), rd.GetValue(i).ToString());
                }
            }
            rd.Close();
            return DictionaryToObject(dico);
        }

        public static dynamic find<T>(int id)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();

            string sql = "SELECT * FROM " + typeof(T).Name + " WHERE id=" + id;
            Console.WriteLine(sql);
            IDataReader rd = Connexion.Select(sql);
            while (rd.Read())
            {
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    dico.Add(rd.GetName(i), rd.GetValue(i).ToString());
                }
            }
            rd.Close();
            return DictionaryToObject<T>(dico);
        }

        public int delete(string proc = null)
        {
            DateTime now = DateTime.Now;
            XDocument x = XDocument.Load(Model.xml_path);
            XElement delet = new XElement(this.GetType().Name);
            XElement root = x.Root;
            XElement clas = root.Element(this.GetType().Name+"s");
            Dictionary<string, string> dico = new Dictionary<string, string>();
            dico = Model.ObjectToDictionary<string>(this);
            foreach(var el in dico)
            {
                delet.Add(new XElement(el.Key.ToString(),el.Value));
            }
            delet.Add(new XElement("Date",now.ToString()));

            clas.Add(delet);
            x.Save(Model.xml_path);


            string requete;
            Connexion.cmd.CommandType = CommandType.StoredProcedure;
            Connexion.cmd.Parameters.Clear();
            if (proc != null)
            {
                requete = proc;


           
                Connexion.cmd.Parameters.Add(new MySqlParameter("id", this.id));


            }
            else
            {
                Connexion.cmd.CommandType = CommandType.Text;
                requete = "DELETE FROM " + this.GetType().Name + " WHERE id =" + this.id;
            }
           
            return Connexion.IUD(requete);
        }

        public List<dynamic> All()
        {

            // BLACH Dictionary<string, string> champs = new Dictionary<string, string>();
            List<dynamic> result = new List<dynamic>();
            string requete = "SELECT * FROM " + this.GetType().Name;
            IDataReader rd = Connexion.Select(requete);
            while (rd.Read())
            {
                var dico = new Dictionary<string, Object>();
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    dico.Add(rd.GetName(i), rd.GetValue(i).ToString());
                }
                var obj = DictionaryToObject(dico);
                result.Add(obj);
                dico = null;
            }
            rd.Close();
            return result;

        }
        public static List<dynamic> all<T>()
        {
            Connexion.Connect();

            List<dynamic> result = new List<dynamic>();
            System.Console.WriteLine(typeof(T).Name);
            string requete = "SELECT * FROM " + typeof(T).Name;
            Console.WriteLine(requete);
            IDataReader rd = Connexion.Select(requete);
            while (rd.Read())
            {
                var dico = new Dictionary<string, Object>();
                for (int i = 0; i < rd.FieldCount; i++)
                {
                    dico.Add(rd.GetName(i), rd.GetValue(i).ToString());
                }
                var obj = DictionaryToObject<T>(dico);
                result.Add(obj);
                dico = null;
            }
            rd.Close();
            return result;
        }

        public List<dynamic> Select(Dictionary<string, object> dico)
        {
            List<dynamic> result = new List<dynamic>();
            string requete = "SELECT * FROM " + this.GetType().Name;
            if (dico.Count != 0)
            {
                requete += " WHERE ";
                int i = 0;
                foreach (KeyValuePair<string, object> atr in dico)
                {
                    i++;
                    requete += " " + atr.Key + "='" + atr.Value + "' ";
                    if (i < dico.Count)
                    {
                        requete += " and ";
                    }
                }
                // test 
               // Console.WriteLine(requete);
            }
            IDataReader rd = Connexion.Select(requete);
            while (rd.Read())
            {
                var ResDico = new Dictionary<string, object>();
                for (int j = 0; j < rd.FieldCount; j++)
                {

                    ResDico.Add(rd.GetName(j), rd.GetValue(j).ToString());

                }

                result.Add(this.DictionaryToObject(ResDico));
                dico = null;
            }
            rd.Close();
            return result;

        }
        public static List<dynamic> select<T>(Dictionary<string, object> dico)
        {

            Connexion.Connect();

            List<dynamic> result = new List<dynamic>();
            string requete = "SELECT * FROM " + typeof(T).Name;

            if (dico.Count != 0)
            {
                requete += " WHERE ";
                int i = 0;
                foreach (KeyValuePair<string, object> atr in dico)
                {
                    i++;
                    requete += " " + atr.Key + "='" + atr.Value + "' ";
                    if (i < dico.Count)
                    {
                        requete += " and ";
                    }
                }
                // test 
                Console.WriteLine(requete);
            }
            IDataReader rd = Connexion.Select(requete);
            while (rd.Read())
            {
                var ResDico = new Dictionary<string, object>();
                for (int j = 0; j < rd.FieldCount; j++)
                {

                    ResDico.Add(rd.GetName(j), rd.GetValue(j).ToString());

                }
                result.Add(DictionaryToObject<T>(ResDico));
                dico = null;
            }
            rd.Close();
            return result;

        }
    }
}