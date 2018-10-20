using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Secretaire.Rendezvous
{
    public partial class FicheRendezvous : Form
    {
        FormRendezvous formRendezvous;
        Model mdl = new Model();

        public FicheRendezvous(FormRendezvous formRendezvous)
        {
            this.formRendezvous = formRendezvous;
            InitializeComponent();
        }
        public FicheRendezvous()
        {
            InitializeComponent();
        }

        private void FicheRendezvous_Load(object sender, EventArgs e)
        {
            ConnexionDPI.Tools.Connect();
            mdl.Bind("select * from patient", secretaireDataSet.patient);
            mdl.Bind("select * from personnel", secretaireDataSet.personnel);
            mdl.Bind("select * from consultation", secretaireDataSet.consultation);
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //string dateRvStr = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + " " + dateTimePicker2.Value.Hour.ToString("HH:mm:ss");
            //DateTime dateRv = DateTime.ParseExact(dateRvStr, "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
            int annee = dateTimePicker1.Value.Date.Year;
            int mois = dateTimePicker1.Value.Date.Month;
            int jour = dateTimePicker1.Value.Date.Day;
            int heure = dateTimePicker2.Value.Date.Hour;
            int minute = dateTimePicker2.Value.Date.Minute;
            int seconde = dateTimePicker2.Value.Date.Second;
            DateTime date = new DateTime(annee, mois, jour, heure, minute, seconde);
            MessageBox.Show(dateTimePicker1.Value.Date.ToString(), "Test", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            Tools.executeLMD_Query("INSERT INTO rendezvous(idConsultation,idPersonnel,idPatient,dateRv) VALUES ('" +
                                comboBox1.SelectedValue + "','" +
                                comboBox2.SelectedValue + "','" +
                                comboBox3.SelectedValue + "','" +
                                dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") + "')");
            formRendezvous.Refresh();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
