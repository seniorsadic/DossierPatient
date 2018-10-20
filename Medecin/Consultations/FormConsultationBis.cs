using ConnexionDPI;
using Medecin.Ordonnance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medecin.Consultations
{
    public partial class FormConsultationBis : Form
    {
        public Model model=new Model();
        public int idPatient = 1;
        public int idMedecin = 1;
        public DateTime date = DateTime.Now;
        public String idConsultation = String.Empty;
        String idOrdonnance;

        public FormConsultationBis()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormConsultationBis_Load(object sender, EventArgs e)
        {
            model.Bind("select * from pathologie", medecinDataSet.pathologie);
            model.Bind("select * from examen", medecinDataSet.examen);
            model.Bind("select * from medicament", medecinDataSet.medicament);
            model.Bind("select * from patient where idPatient="+idPatient, medecinDataSet.patient);
            hospitaliserToolStripMenuItem.Enabled = false;
          //  this.reportViewer1.RefreshReport();
        }

        private void examBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable medicamentordonnance = medecinDataSet.medicamentordonnance;
            DataTable resultatexamen = medecinDataSet.resultatexamen;
            MessageBox.Show("Nombre de medicament : " + medicamentordonnance.Rows.Count);
            Random a = new Random();
            Tools.executeLMD_Query("INSERT INTO consultation(idPathologie,idPersonnel,idPatient,numeroConsultation,date,observationsPrescriptions) VALUES ('" +
                            comboBox1.SelectedValue + "','" +
                            idMedecin + "','" +
                            idPatient + "','" +
                            a.Next(100000000, 999999999) + "','" +
                            date.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                            textBox1.Text + "')");
            idConsultation = Tools.executeSimpleQuery("select max(idConsultation) from consultation");
            if (medicamentordonnance.Rows.Count > 0)
            {
                Tools.executeLMD_Query("INSERT INTO ordonnance(idConsultation,date,remarques) VALUES ('" +
                            idConsultation + "','" +
                            date.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                            textBox1.Text + "')");
                idOrdonnance = Tools.executeSimpleQuery("select max(idOrdonnance) from ordonnance");
                foreach (DataRow empR in medicamentordonnance.Rows)
                {
                    Tools.executeLMD_Query("INSERT INTO medicamentordonnance(idOrdonnance,idMedicament,nombrePrise,dateDebut,dateFin) VALUES ('" +
                            idOrdonnance + "','" +
                            empR["idMedicament"].ToString() + "','" +
                            empR["nombrePrise"].ToString() + "','" +
                            empR["dateDebut"].ToString() + "','" +
                            empR["dateFin"].ToString() + "')");
                    
                }
             }
            if(resultatexamen.Rows.Count > 0)
            {
                foreach (DataRow empR in resultatexamen.Rows)
                {
                    Tools.executeLMD_Query("INSERT INTO resultatexamen(idConsultation,idExam) VALUES ('" +
                            idConsultation + "','" +
                            empR["idExam"].ToString()  + "')");

                }
            }
            ajouterToolStripMenuItem.Visible = false;
            hospitaliserToolStripMenuItem.Enabled = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hospitaliserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicheHospitalisation fiche = new FicheHospitalisation(this, Int32.Parse(idConsultation));
            fiche.ShowDialog();

        }

        private void ordonnaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicheOrdonnance fiche = new FicheOrdonnance(this,idOrdonnance);
            fiche.ShowDialog();
        }
    }
}
