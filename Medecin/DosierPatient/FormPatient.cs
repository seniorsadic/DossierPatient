using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medecin.DosierPatient
{
    public partial class FormPatient : Form
    {
        Model mdl = new Model();
        public FormPatient()
        {
            InitializeComponent();
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {
            Tools.Connect();
            mdl.Bind(dataGridView1, bindingNavigator1, medecinDataSet.patient, patientBindingSource, "SELECT * FROM patient");
            Utilitaire.chargerToolStripComboListe(patientBindingSource, medecinDataSet.patient, toolStripComboBox1, 7);
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }
        public override void Refresh()
        {
          
            mdl.Bind(dataGridView1, bindingNavigator1, medecinDataSet.patient, patientBindingSource, "SELECT * FROM patient");
            toolStripComboBox1.Text = string.Empty;
            toolStripComboBox1.Items.Clear();
            Utilitaire.chargerToolStripComboListe(patientBindingSource, medecinDataSet.patient, toolStripComboBox1, 7);
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           patientBindingSource.Filter = "nom='" + toolStripComboBox1.Text + "'";
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            patientBindingSource.RemoveFilter();
            toolStripComboBox1.Text = string.Empty;
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }
    }
}
