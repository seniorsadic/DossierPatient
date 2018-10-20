using ConnexionDPI;
using Secretaire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Secretaire.Patient
{
    public partial class FormPatient : Form
    {
        Model mdl = new Model();

        public FormPatient()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPatient_Load(object sender, EventArgs e)
        {
            ConnexionDPI.Tools.Connect();
            //mdl.Bind("select * from patient", secretaireDataSet.patient);
            //mdl.Bind("select * from specialite", paramDataSet.specialite);
            //Utilitaire.chargerToolStripComboListe(specialiteBindingSource, paramDataSet.specialite, toolStripComboBox1, 1);
            mdl.Bind(dataGridView1, bindingNavigator1, secretaireDataSet.patient, bindingSourcePatient, "select * from patient");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        public override void Refresh()
        {
            secretaireDataSet.patient.Clear();
            toolStripTextBox1.Text = string.Empty;
            mdl.Bind(dataGridView1, bindingNavigator1, secretaireDataSet.patient, bindingSourcePatient, "select * from patient");
            Utilitaire.desactiverColonnes_All(dataGridView1);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FichePatient fichePatient = new FichePatient(this);
            fichePatient.ShowDialog();

        }

        private void détailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichePatient fichePatient = new FichePatient(this, dataGridView1.CurrentRow.Cells[0].Value.ToString(), 1);
            fichePatient.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichePatient fichePatient = new FichePatient(this, dataGridView1.CurrentRow.Cells[0].Value.ToString(), 2);
            fichePatient.ShowDialog();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void bindingSourcePatient_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSourcePatient_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bindingSourcePatient.Filter = "nom = '" + toolStripTextBox1.Text + "'";
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bindingSourcePatient.RemoveFilter();
            toolStripTextBox1.Text = string.Empty;
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }
    }
}
