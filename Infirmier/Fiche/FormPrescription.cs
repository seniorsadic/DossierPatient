using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Infirmier.Fiche
{
    public partial class FormPrescription : Form
    {
        Model modele = new Model();

        public FormPrescription()
        {
            InitializeComponent();
        }

        private void FormPrescription_Load(object sender, EventArgs e)
        {
            modele.Bind("select * from personnel", dataInfirmier.personnel);
            modele.Bind("select * from hospitalisation", dataInfirmier.hospitalisation);
            modele.Bind(dataGridView1, bindingNavigator1, dataInfirmier.prescription, prescriptionBindingSource, "select * from prescription");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        public override void Refresh()
        {
            dataInfirmier.transmission.Clear();
            dataInfirmier.personnel.Clear();
            dataInfirmier.hospitalisation.Clear();
            dataInfirmier.prescription.Clear();
            modele.Bind("select * from personnel", dataInfirmier.personnel);
            modele.Bind("select * from hospitalisation", dataInfirmier.hospitalisation);
            modele.Bind(dataGridView1, bindingNavigator1, dataInfirmier.prescription, prescriptionBindingSource, "select * from prescription");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }



        private void ficheDeTransmissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicheTransmission fiche = new FicheTransmission(this, dataGridView1.CurrentRow.Cells[0].Value.ToString());
            fiche.ShowDialog();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView2.Visible = true;

            //if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
            //    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            // Refresh();

            int IdxLigneActuelle = e.RowIndex;
            DataGridViewRow ligne = dataGridView1.Rows[IdxLigneActuelle];

            string idPrescription = ligne.Cells[0].Value.ToString();

            dataInfirmier.transmission.Clear();

            modele.Bind(dataGridView2, bindingNavigator1, dataInfirmier.transmission, transmissionBindingSource, "select * from transmission where idTraitement='" + idPrescription + "'");
            Utilitaire.desactiverColonnes_All(dataGridView2);
        }
    }
}
