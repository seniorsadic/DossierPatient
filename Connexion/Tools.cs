using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using users_parameters;
using System.Data;

namespace ConnexionDPI
{
     public class Tools
    {

        //-----------------------------------    CONNEXION TEMPORAIRE   -------------------
        public static string BDHost = "localhost", BDPort = "3306", BDName = "dpidb_new", BDUserName = "root", BDUserPwd = "";

        public static MySqlConnection mySqlConnection = null;
       public static ParamUsers paramUsers = null;

        public static MySqlConnection SpecialConnect(string server, string database, string username, string password)
        {
            MySqlConnection mySqlConnection = null;
            try
            {
                mySqlConnection = new MySqlConnection(
                                "SERVER=" + server + ";" +
                                "DATABASE=" + database + ";" +
                                "UID=" + username + ";" +
                                "PASSWORD=" + password + ";" +
                                "PORT=" + BDPort + ";" +
                                "CharSet=utf8");
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                // ??
                throw ex;
            }
            return mySqlConnection;
        }

        public static MySqlConnection SpecialConnect(string database)
        {
            return SpecialConnect(BDHost, database, BDUserName, BDUserPwd);
        }

        public static void SpecialClose(MySqlConnection mySqlConnection)
        {
            try
            {
                if (mySqlConnection != null)
                    mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                // ???
                throw ex;
            }
        }

        public static void loadParamUsers(int current_numUser)
        {
            List<Dictionary<string, string>> ldics = getDictListFromQuery("Select * from users u, personnel p WHERE u.id_user=p.idPersonnel");
            paramUsers = new ParamUsers(current_numUser);
            foreach (Dictionary<string, string> dic in ldics)
            { // numUser, int privilege, string prenom, string nom, string fonction
                paramUsers.addUser(int.Parse(dic["id_user"]), int.Parse(dic["param"]), int.Parse(dic["secretaire"]), int.Parse(dic["medecin"]), int.Parse(dic["comptabilite"]), int.Parse(dic["infirmier"]), dic["nom"]);
            }
        }

        //----------------------------------- CONNEXION PAR DEFAUT ------------------------

        public static void Connect(string server, string database, string username, string password)
        {
            try
            {
                if (Tools.mySqlConnection != null)
                    return;
                Tools.mySqlConnection = new MySqlConnection(
                                    "SERVER=" + server + ";" +
                                    "DATABASE=" + database + ";" +
                                    "UID=" + username + ";" +
                                    "PASSWORD=" + password + ";" +
                                    "PORT=" + BDPort + ";" +
                                    "CharSet=utf8");
                Tools.mySqlConnection.Open();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Problème rencontré. Impossible de se connecter à la base de données !\n\n" + exc.StackTrace, "Gelo 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
        }

        public static void Connect()
        {
            Connect(BDHost, BDName, BDUserName, BDUserPwd);
        }

        //public static void ConnectAdminDB()
        //{
        //    Connect(BDHost, Connexion.Tools.Admin_BDName, BDUserName, BDUserPwd);
        //}

        public static void Close(bool b = false)
        {
            if (b)
            {
                Tools.mySqlConnection.Close();
                Tools.mySqlConnection = null;
            }
        }

        //------------------------------------     REQUETES SQL    ------------------------

        public static string executeLMD_Query(string sqlSelectQuery, string BDname = null)
        {
            return executeSimpleQuery(sqlSelectQuery, BDname);
        }

        public static string executeSimpleQuery(string sqlQuery, string BDname = null)
        {
            string res = null;
            try
            {
                MySqlConnection mySqlConnection = null;
                if (BDname != null)
                {
                    mySqlConnection = Tools.SpecialConnect(BDname);
                }
                else
                {
                    Tools.Connect();
                    mySqlConnection = Tools.mySqlConnection;
                }

                MySqlCommand command = mySqlConnection.CreateCommand();
                command.CommandText = sqlQuery;

                if (!sqlQuery.StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
                {
                    res = "" + command.ExecuteNonQuery();
                }
                else
                {
                    MySqlDataReader mDReader = command.ExecuteReader();
                    if (mDReader.Read())
                    {
                        res = mDReader.GetString(0);
                    }
                    mDReader.Close();
                }

                if (BDname != null)
                {
                    //Tools.SpecialClose(mySqlConnection);
                }
                else
                    Tools.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            return res;
        }

        public static List<string> getListFromQuery(string sqlQuery, string BDname = null)
        {
            List<string> list = new List<string>();
            MySqlDataReader mDReader = executeSelectQuery(sqlQuery, BDname);
            if (mDReader.HasRows)
                while (mDReader.Read())
                    list.Add(mDReader.GetString(0));
            mDReader.Close();
            return list;
        }

        public static List<Dictionary<string, string>> getDictListFromQuery(string sqlQuery, string BDname = null)
        {
            List<Dictionary<string, string>> dictList = new List<Dictionary<string, string>>();
            MySqlDataReader mDReader = executeSelectQuery(sqlQuery, BDname);
            int i;
            if (mDReader.HasRows)
                while (mDReader.Read())
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    for (i = 0; i < mDReader.FieldCount; i++)
                        if (!dict.ContainsKey(mDReader.GetName(i))) // Gestion des NATURAL JOIN
                            dict.Add(mDReader.GetName(i), (mDReader.IsDBNull(i)) ? "" : mDReader.GetString(i));
                    dictList.Add(dict);
                }
            mDReader.Close();
            return dictList;
        }

        public static Dictionary<string, string> getDictFromQuery(string sqlQuery, string BDname = null)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            MySqlDataReader mDReader = executeSelectQuery(sqlQuery, BDname);
            if ((mDReader.HasRows) && (mDReader.Read()))
            {
                for (int i = 0; i < mDReader.FieldCount; i++)
                    if (!dict.ContainsKey(mDReader.GetName(i))) // Gestion des NATURAL JOIN
                        dict.Add(mDReader.GetName(i), (mDReader.IsDBNull(i)) ? "" : mDReader.GetString(i));
            }
            mDReader.Close();
            return dict;
        }

        public static DataTable getDataTableFromQuery(string sqlQuery, string BDname = null)
        {
            DataTable dt = null;
            try
            {
                MySqlConnection mySqlConnection = null;
                if (BDname != null)
                {
                    mySqlConnection = Tools.SpecialConnect(BDname);
                }
                else
                {
                    Tools.Connect();
                    mySqlConnection = Tools.mySqlConnection;
                }

                MySqlCommand command = new MySqlCommand(sqlQuery, mySqlConnection);
                using (MySqlDataAdapter msda = new MySqlDataAdapter(command))
                {
                    dt = new DataTable();
                    msda.Fill(dt);
                }

                if (BDname != null)
                {
                    //Tools.SpecialClose(mySqlConnection);
                }
                else
                    Tools.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            return dt;
        }

        public static bool isEmptyQuery(string sqlQuery)
        {
            bool isEmpty = false;
            MySqlDataReader mDReader = executeSelectQuery(sqlQuery);
            isEmpty = !mDReader.HasRows;
            mDReader.Close();
            return isEmpty;
        }

        public static MySqlDataReader executeSelectQuery(string sqlQuery, string BDname = null)
        {
            MySqlDataReader mDReader = null;
            try
            {
                MySqlConnection mySqlConnection = null;
                if (BDname != null)
                {
                    mySqlConnection = Tools.SpecialConnect(BDname);
                }
                else
                {
                    Tools.Connect();
                    mySqlConnection = Tools.mySqlConnection;
                }

                MySqlCommand command = mySqlConnection.CreateCommand();
                command.CommandText = sqlQuery;

                mDReader = command.ExecuteReader();

                if (BDname != null)
                {
                    //Tools.SpecialClose(mySqlConnection);
                }
                else
                    Tools.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            return mDReader;
        }

        public static bool FIND(string tableName, string clause_WHERE__list_of_fields_and_values = null) // Ex. : nom=gueye,prenom=modou,age=12 
        {
            MySqlDataReader msdataReader = executeSelectQuery("SELECT * FROM " + tableName + ((clause_WHERE__list_of_fields_and_values == null) ? "" : " WHERE (" + clause_WHERE__list_of_fields_and_values.Replace(",", ") AND (") + ")"));
            bool trouve = (msdataReader.HasRows) ? true : false;
            msdataReader.Close();
            return trouve;
        }

        public static MySqlDataReader SELECT(string tableName, string clause_WHERE = null)
        {
            return executeSelectQuery("SELECT * FROM " + tableName + ((clause_WHERE != null) ? (" WHERE " + clause_WHERE) : ""));
        }

        public static string SELECT_ONE(string tableName, string fieldName, string clause_WHERE = null)
        {
            return executeSimpleQuery("SELECT " + fieldName + " FROM " + tableName + ((clause_WHERE != null) ? (" WHERE " + clause_WHERE) : ""));
        }

        public static void DELETE(string tableName, string clause_WHERE = null)
        {
            executeLMD_Query("DELETE FROM " + tableName + ((clause_WHERE != null) ? (" WHERE " + clause_WHERE) : ""));
        }

        public static void UPDATE(string tableName, string list_of_fields_and_values, string clause_WHERE = null) // Ex. : nom=gueye,prenom=modou,age=12 
        {
            executeLMD_Query("UPDATE " + tableName + " SET " + list_of_fields_and_values + ((clause_WHERE != null) ? (" WHERE " + clause_WHERE) : ""));
        }

        public static void INSERT(string tableName, string list_of_values) // list_of_values = liste de champs séparés par des ","
        {
            executeLMD_Query("INSERT INTO " + tableName + " VALUES (" + list_of_values + ")");
        }
    }
}
