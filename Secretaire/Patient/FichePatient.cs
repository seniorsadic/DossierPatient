using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConnexionDPI;

namespace Secretaire.Patient
{
    public partial class FichePatient : Form
    {
        Model model = new Model();
        int statut = 0;
        string id;
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        FormPatient formPatient;

        public FichePatient()
        {
            InitializeComponent();
        }

        public FichePatient(FormPatient formPatient)
        {
            this.formPatient = formPatient;
            InitializeComponent();
        }

        public FichePatient(FormPatient formPatient, string id, int statut)
        {
            this.formPatient = formPatient;
            this.id = id;
            this.statut = statut;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(statut == 0){
                string numPatient = RandomString(4);
                Tools.executeLMD_Query("INSERT INTO patient(numeroPatient,prenom,nom,age,sexe,adresse,dateNaissance,lieuNaissance,poids,groupeSanguin,tension,profession,taille) VALUES ('" +
                                textBoxnom.Text + numPatient + "','" +
                                textBoxpre.Text + "','" +
                                textBoxnom.Text + "','" +
                                textBoxage.Text + "','" +
                                comboBoxsex.Text + "','" +
                                textBoxadr.Text + "','" +
                                dateTimePickerdn.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                                textBoxln.Text + "','" +
                                textBoxpoi.Text + "','" +
                                textBoxgs.Text + "','" +
                                textBoxten.Text + "','" +
                                textBoxpro.Text + "','" +
                                textBoxtai.Text + "')");
            }
            else
            {
                Validate();
                model.Save();
            }
            formPatient.Refresh();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FichePatient_Load(object sender, EventArgs e)
        {
            if (statut > 0)
            {
                model.Bind("select * from patient where idPatient=" + id, secretaireDataSet.patient, bindingSourcePatient);
                if(statut == 1)
                {
                    DesactiverTextBox();
                }

            }
        }

        private void DesactiverTextBox()
        {
            textBoxpro.ReadOnly = textBoxpre.ReadOnly = textBoxnom.ReadOnly = textBoxage.ReadOnly = textBoxadr.ReadOnly = textBoxln.ReadOnly = textBoxpoi.ReadOnly = textBoxgs.ReadOnly = textBoxten.ReadOnly = textBoxtai.ReadOnly = true;
            comboBoxsex.Enabled = dateTimePickerdn.Enabled = false;
            button2.Visible = false;
            label13.Visible = label14.Visible = label15.Visible = false;
        }
    }
}
