using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace Parametrage
{
    public static class Utilitaire
    {
        public static Form choisirForm(string className)
        {
            System.Type objType = System.Type.GetType(className);

            // Vérification si le type a bien été retrouvé
            if (objType != null)
            {
                // Instance dynamique à partir du type donné
                object objInstanceDynamique = System.Activator.CreateInstance(objType);

                // Casting de l'objet
                Form frm = objInstanceDynamique as Form;
                return frm;
            }
            else
            {
                MessageBox.Show("Le type semble être incorrect! 2");
                return null;
            }
        }

        //----------------------------------------Formatage----------------------------------------------------
        public static string numero(int nbre)
        {
            int n = nbre.ToString().Length;
            string ch = "";
            for (int i = 0; i < (6 - n); i++)
                ch = ch + "0";
            return ch + nbre;
        }

        public static string addslashes(string text)
        {
            return text.Replace("'", "\\'");
        }

        public static string formatageMontant(double mnt)
        {
            NumberFormatInfo nfi = new CultureInfo("fr-FR", false).NumberFormat;
            return mnt.ToString("N", nfi);
        }

        public static double resetFormatageMontant(string montant)
        {
            return double.Parse(montant.Trim());
        }


        //----------------------------------------Fonction de recherche sql---------------------------------------------------
        public static bool existeNumDansTable(string champ, string table, string cle)
        {
            return (ConnexionDPI.Tools.executeSimpleQuery("SELECT COUNT(" + champ + ") FROM " + table + " WHERE " + champ + "='" + cle + "'") != "0");
        }

        public static bool existeNumDansTable(string champ1, string champ2, string table, string cle1, string cle2)
        {
            return (ConnexionDPI.Tools.executeSimpleQuery("SELECT COUNT(" + champ1 + ") FROM " + table + " WHERE " + champ1 + "='" + cle1 + "' AND " + champ2 + "='" + cle2 + "'") != "0");
        }


        //-------------------------------- Convertion DateTime au fomat Mysql------------------------------------------------------------
        public static string dateMysqltoDTPicker(string dateMysql)
        {
            string time = dateMysql.Split(' ')[1];
            string date = dateMysql.Split(' ')[0];
            return date.Split('-')[2] + "/" + date.Split('-')[1] + "/" + date.Split('-')[0] + " " + time;
        }

        public static string dateDTPickertoMysql(string dateDTPicker)
        {
            string time = dateDTPicker.Split(' ')[1];
            string date = dateDTPicker.Split(' ')[0];
            return date.Split('/')[2] + "-" + date.Split('/')[1] + "-" + date.Split('/')[0] + " " + time;
        }


        //--------------------------------- Fonction sur DataGridView-----------------------------------------------------------
        public static void desactiverColonnes_All(DataGridView dataGridView1)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].ReadOnly = true;
        }

        public static void activerCellules_All(DataGridView dataGridView1, int row)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Rows[row].Cells[i].ReadOnly = false;
        }

        public static void ajouterColonneDGV(string texte, int index, DataGridView dtg)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = "col" + index;
            col.HeaderText = texte;
            dtg.Columns.Add(col);
        }

        public static void remplirLignesPourFormatageMnt(DataGridView dtg, int indexDest, int indexOrigine)
        {
            for (int i = 0; i < dtg.Rows.Count; i++)
            {
                dtg.Rows[i].Cells[indexDest].Value = formatageMontant(double.Parse(dtg.Rows[i].Cells[indexOrigine].Value.ToString()));
            }
        }


        //--------------------------------------Fonction de recherche------------------------------------------------------
        public static bool trouverChTab(string[] tab, string str)
        {
            foreach (string s in tab)
            {
                if (s == str)
                    return true;
            }

            return false;
        }

        public static bool trouverChamp(BindingSource bs, DataTable dt, string champ, int indexChamp = 0)
        {
            if (bs.Count == 0)
                return false;
            else
            {
                for (int r = 0; r < dt.Rows.Count; r++)
                    if (dt.Rows[r][indexChamp].ToString() == champ)
                        return true;
            }
            return false;

        }


        //--------------------------------------Charger les données de la base dans un coposant------------------------------------------------------
        public static void chargerliste(BindingSource bs, DataTable dt, AutoCompleteStringCollection source, int indexChamp = 0)
        {

            if (bs.Count == 0)
                return;

            string[] tab = new string[dt.Rows.Count];
            int i = 0;

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                if (!trouverChTab(tab, dt.Rows[r][indexChamp].ToString()))
                    tab[i++] = dt.Rows[r][indexChamp].ToString();
            }

            source.Clear();
            foreach (string s in tab)
            {
                if (s != null)
                    source.Add(s);
            }

        }

        public static void chargerComboListe(BindingSource bs, DataTable dt, ComboBox cb, int indexChamp = 0)
        {

            if (bs.Count == 0)
                return;

            string[] tab = new string[dt.Rows.Count];
            int i = 0;

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                if (!trouverChTab(tab, dt.Rows[r][indexChamp].ToString()))
                    tab[i++] = dt.Rows[r][indexChamp].ToString();
            }
            cb.Items.Clear();
            foreach (string s in tab)
            {
                if (s != null)
                    cb.Items.Add(s);
            }
            cb.Sorted = true;
            cb.Refresh();
        }

        public static void chargerComboListe(BindingSource bs, DataTable dt, ToolStripComboBox cb, int indexChamp = 0)
        {

            if (bs.Count == 0)
                return;

            string[] tab = new string[dt.Rows.Count];
            int i = 0;

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                if (!trouverChTab(tab, dt.Rows[r][indexChamp].ToString()))
                    tab[i++] = dt.Rows[r][indexChamp].ToString();
            }
            cb.Items.Clear();
            foreach (string s in tab)
            {
                if (s != null)
                    cb.Items.Add(s);
            }
            cb.Sorted = true;
            //cb.Refresh();
        }

        public static void chargerComboListe(BindingSource bs, DataTable dt, DataGridViewComboBoxCell cb, int indexChamp = 0)
        {

            if (bs.Count == 0)
                return;

            string[] tab = new string[dt.Rows.Count];
            int i = 0;

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                if (!trouverChTab(tab, dt.Rows[r][indexChamp].ToString()))
                    tab[i++] = dt.Rows[r][indexChamp].ToString();
            }
            cb.Items.Clear();
            foreach (string s in tab)
            {
                if (s != null)
                    cb.Items.Add(s);
            }
            cb.Sorted = true;
            //cb.Refresh();
        }

        public static void chargerComboListe(BindingSource bs, DataTable dt, ComboBox cb, string indexesChamps = "0")
        {

            if (bs.Count == 0)
                return;

            string[] indexes = indexesChamps.Split(';'); // Liste des indices de champ à indexer

            string[] tab = new string[dt.Rows.Count];
            string[] val = new string[dt.Rows.Count];
            int i = 0, indexChamp;

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int j = 0; j < indexes.Length; j++)
                {
                    indexChamp = Int32.Parse(indexes[j]);

                    if (j == 0)
                        tab[i] = dt.Rows[r][indexChamp].ToString();
                    else
                        tab[i] += " " + dt.Rows[r][indexChamp].ToString();
                }
                i++;
            }
            cb.Items.Clear();
            foreach (string s in tab)
            {
                if (s != null)
                {
                    cb.Items.Add(s);
                }

            }
            cb.Sorted = true;
            cb.Refresh();
        }

        public static void chargerToolStripComboListe(BindingSource bs, DataTable dt, ToolStripComboBox cb, int indexChamp = 0)
        {

            if (bs.Count == 0)
                return;

            string[] tab = new string[dt.Rows.Count];
            int i = 0;

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                if (!trouverChTab(tab, dt.Rows[r][indexChamp].ToString()))
                    tab[i++] = dt.Rows[r][indexChamp].ToString();
            }
            cb.Items.Clear();
            foreach (string s in tab)
            {
                if (s != null)
                    cb.Items.Add(s);
            }
            cb.Sorted = true;

        }




    }
}
