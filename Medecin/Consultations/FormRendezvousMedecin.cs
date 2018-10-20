using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medecin.Consultations
{
    public partial class FormRendezvousMedecin : Form
    {
        Model model = new Model();
        public int idMedecin = 1;
        public DateTime date = DateTime.Now;
        public DateTime dateDebut = DateTime.Today, dateFin = DateTime.Today;

        public FormRendezvousMedecin()
        {
            InitializeComponent();
        }

        private void FormRendezvousMedecin_Load(object sender, EventArgs e)
        {
            model.Bind("select * from patient", medecinDataSet.patient);
            dataGridView1.RowCount = 10;
            gererDate(dateDebut.DayOfWeek + "");
            toolStripLabel1.Text = dateDebut.ToString("dd/MM/yyyy");
            toolStripLabel2.Text = dateFin.ToString("dd/MM/yyyy");
            charger();
        }

        public override void Refresh()
        {
            medecinDataSet.patient.Clear();
            model.Bind("select * from patient", medecinDataSet.patient);
            charger();
        }

        public void charger()
        {
            //  dataGridView1=new DataGridView();
            vider();
            medecinDataSet.rendezvous.Clear();
            model.Bind("select * from rendezvous where idPersonnel='" + idMedecin + "' and dateRv between '" + dateDebut.ToString("yyyy-MM-dd") + " 00:00:00' and '" + dateFin.ToString("yyyy-MM-dd") + " 00:00:00' order by dateRv", medecinDataSet.rendezvous);
            DataTable tester = medecinDataSet.rendezvous;
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
                if(testDate>=date)
                     dataGridView1.Rows[i].Cells[(int)testDate.DayOfWeek - 1].Style.BackColor = Color.LightGreen;
                else
                    dataGridView1.Rows[i].Cells[(int)testDate.DayOfWeek - 1].Style.BackColor = Color.Orange;
                i++;             
            }
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        public void vider()
        {
            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Utilitaire.activerCellules_All(dataGridView1, i);
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = string.Empty;
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dateDebut = dateDebut.AddDays(7);
            dateFin = dateFin.AddDays(7);
            toolStripLabel1.Text = dateDebut.ToString("dd/MM/yyyy");
            toolStripLabel2.Text = dateFin.ToString("dd/MM/yyyy");
            charger();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Tu as clické sur " + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            FormConsultationBis form = new FormConsultationBis();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         //   MessageBox.Show("Tu as clické sur " + e.ColumnIndex.ToString());
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         //   MessageBox.Show("Tu as clické sur " + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value );
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
