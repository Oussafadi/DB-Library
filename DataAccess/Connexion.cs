using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System;

namespace DataAccess
{
    internal class Connexion
    {
        public static IDbConnection con;
        public static IDbCommand cmd ;

        public static void Connect()
        {

            if (con == null)
            {
             //   string str_con = "server=localhost;uid=root;pwd='';database=bdjava";
              //  con = new MySqlConnection(str_con);
             //   cmd = new MySqlCommand();

                var DatabaseInfo = new Dictionary<string, string>();
                string file = @"C:\Users\joudia\Desktop\project_c_sharp\DataAccess\.env";
                if (File.Exists(file))
                {
                    string[] lines = File.ReadAllLines(file);
                    string[] parts;
                    foreach ( string line in lines )
                    {
                        parts = line.Split("=".ToCharArray());
                        DatabaseInfo.Add(parts[0], parts[1]);
                    }
                }
                switch (DatabaseInfo["DB_CONNECTION"])
                {
                    case "mysql":
                        con = new MySqlConnection(
                            "server =" + DatabaseInfo["DB_HOST"] + ";" +
                            "uid=" + DatabaseInfo["DB_USERNAME"] + ";" +
                            "pwd=" + DatabaseInfo["DB_PASSWORD"] + ";" +
                            "database=" + DatabaseInfo["DB_DATABASE"]
                        );
                        cmd = new MySqlCommand();
                        break;

                    case "sqlserver":

                        Console.WriteLine("test test");
                        con = new SqlConnection("Data Source =" + DatabaseInfo["Data_Source"] + "; Initial Catalog=" + DatabaseInfo["Initial_Catalog"] + ";Integrated Security=" + DatabaseInfo["Integrated_Security"] + ";encrypt=false");
                        cmd = new SqlCommand();
                        break;

                }

            }
            if (con.State.ToString() =="Closed")
            {
                con.Open();
                cmd.Connection = con;
            }
        }

        public static int IUD(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteNonQuery();

        }

        public static IDataReader Select(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteReader();
        }

        public static Dictionary<string, string> Get_champs(string table)
        {
            int i;
            Dictionary<string, string> dict;
            string sql = "select * from " + table;
            dict = new Dictionary<string, string>();
           // cmd = new MySqlCommand(sql, Connexion.con);
            cmd.CommandText = sql;
            IDataReader rd = cmd.ExecuteReader();

            for (i = 0; i < rd.FieldCount; i++)
            {
                string colName = rd.GetName(i);
                string colType = rd.GetFieldType(i).ToString();
                dict.Add(colName, colType);
            }

            rd.Close();

            return dict;
        }

    }
}
