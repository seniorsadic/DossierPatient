using Connexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quincaillerie
{
    public partial class Form2 : Form
    {
        Modele model = new Modele();
        public string idMedecin;
        public DateTime date = DateTime.Now;
        public DateTime dateDebut = DateTime.Today, dateFin = DateTime.Today;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Connexion.Tools.Connect();
            model.Bind("select * from patient", test.patient);
            model.Bind("select * from personnel", test.personnel);
            dataGridView1.RowCount = 10;
            Utilitaire.chargerToolStripComboListe(medecinSource1, test.personnel, toolStripComboBox2, 5);
           
            MessageBoxButtons button = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
         //   MessageBox.Show(dateDebut.DayOfWeek+"", "Tester", button, icon);
            gererDate(dateDebut.DayOfWeek + "");
            toolStripLabel3.Text = dateDebut.ToString("dd/MM/yyyy");
            toolStripLabel4.Text = dateFin.ToString("dd/MM/yyyy");

        }

        public override void Refresh()
        {
            test.patient.Clear();
            model.Bind("select * from patient", test.patient);

        }

        public void charger()
        {
            //  dataGridView1=new DataGridView();
            vider();
            test.rendezvous.Clear();
            model.Bind("select * from rendezvous where dateRv between '" + dateDebut.ToString("yyyy-MM-dd") + " 00:00:00' and '" + dateFin.ToString("yyyy-MM-dd") + " 00:00:00' order by dateRv", test.rendezvous);
            DataTable tester = test.rendezvous;
            int i = 0, k = 0;
            DateTime datepremier = date;
            foreach (DataRow empR in tester.Rows)
            {
                DateTime testDate = DateTime.ParseExact(empR["dateRv"].ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                if (k == 0)
                {
                    datepremier = testDate; k++;
                }

                if (datepremier.ToString("yyyy-MM-dd") != testDate.ToString("yyyy-MM-dd"))
                {
                    i = 0; datepremier = testDate;
                }
                dataGridView1.Rows[i].Cells[(int)testDate.DayOfWeek - 1].Value = Tools.executeSimpleQuery("select numeroPatient from patient where idPatient='" + empR["idPatient"].ToString() + "'");
                i++;
            }
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            idMedecin = Tools.executeSimpleQuery("select idPersonnel from personnel where nom='" + toolStripComboBox2.Text + "'");
            charger();
        }

        public void vider()
        {
            for(int i=0; i<dataGridView1.RowCount; i++)
            {
                for (int j= 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = string.Empty;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dateDebut = dateDebut.AddDays(-7);
            dateFin = dateFin.AddDays(-7);
            toolStripLabel3.Text = dateDebut.ToString("dd/MM/yyyy");
            toolStripLabel4.Text = dateFin.ToString("dd/MM/yyyy");
            if (idMedecin != string.Empty)
                charger();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dateDebut = dateDebut.AddDays(7);
            dateFin = dateFin.AddDays(7);
            toolStripLabel3.Text = dateDebut.ToString("dd/MM/yyyy");
            toolStripLabel4.Text = dateFin.ToString("dd/MM/yyyy");
            if (idMedecin != string.Empty)
                charger();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() != string.Empty)
                    {
                       
                        DateTime d = dateDebut.AddDays(j);
                        string idPatient = Tools.executeSimpleQuery("select idPatient from patient where numeroPatient='" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "'");
                        enregistrer(idPatient, d);
                    }
                    
                }
            }
            charger();
        }

        public void enregistrer(string idPatient, DateTime date)
        {
            string k  = Tools.executeSimpleQuery("select idRv from rendezvous where idPersonnel='" + idMedecin + "' and idPatient='" + idPatient + "' and dateRv like '%"+date.ToString("yyyy-MM-dd") +"%'");
   
            if (Convert.ToInt16(k)!=0)
            {
                Connexion.Tools.executeLMD_Query("Update rendezvous set idPatient='" + idPatient + "' WHERE idRv='" + k + "'");
            }
            else
            {
                Connexion.Tools.executeLMD_Query("INSERT INTO rendezvous(idPersonnel,idPatient,dateRv) VALUES ('" +
                      idMedecin + "','" +
                      idPatient + "','" +
                      date.ToString("yyyy-MM-dd HH:mm:ss") + "')");
            }
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichePatient fiche = new FichePatient(this);
            fiche.ShowDialog();
        }

        public void gererDate(string mot)
        {

            switch (mot)
            {
                case "Monday":
                    dateDebut = date;
                    dateFin = date.AddDays(6);
                    break;
                case "Tuesday":
                    dateDebut = date.AddDays(-1);
                    dateFin = date.AddDays(5);
                    break;
                case "Wednesday":
                    dateDebut = date.AddDays(-2);
                    dateFin = date.AddDays(4);
                    break;
                case "Thursday":
                    dateDebut = date.AddDays(-3);
                    dateFin = date.AddDays(3);
                    break;
                case "Friday":
                    dateDebut = date.AddDays(-4);
                    dateFin = date.AddDays(2);
                    break;
                case "Saturday":
                    dateDebut = date.AddDays(-5);
                    dateFin = date.AddDays(1);
                    break;
                case "Sunday":
                    dateDebut = date.AddDays(-6);
                    dateFin = date;
                    break;
            }
        }
    }
}
