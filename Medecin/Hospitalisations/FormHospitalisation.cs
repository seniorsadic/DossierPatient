using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medecin.Hospitalisations
{
    public partial class FormHospitalisation : Form
    {
        Model mdl = new Model();
        public FormHospitalisation()
        {
            InitializeComponent();
        }

        private void FormHospitalisation_Load(object sender, EventArgs e)
        {
            
          
            mdl.Bind("SELECT * FROM consultation", medecinDataSet.consultation);
            mdl.Bind(dataGridView1, bindingNavigator1, medecinDataSet.hospitalisation, hospitalisationBindingSource, "SELECT * FROM hospitalisation");
            Utilitaire.chargerToolStripComboListe(hospitalisationBindingSource, medecinDataSet.hospitalisation, toolStripComboBox1, 1);
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        public override void Refresh()
        {
          
            medecinDataSet.consultation.Clear();
            medecinDataSet.hospitalisation.Clear();
            mdl.Bind("SELECT * FROM consultation", medecinDataSet.consultation);
            mdl.Bind(dataGridView1, bindingNavigator1, medecinDataSet.hospitalisation, hospitalisationBindingSource, "SELECT * FROM hospitalisation");
            toolStripComboBox1.Text = string.Empty;
            toolStripComboBox1.Items.Clear();
            Utilitaire.chargerToolStripComboListe(hospitalisationBindingSource, medecinDataSet.hospitalisation, toolStripComboBox1, 1);
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FicheHospitalisation frm = new FicheHospitalisation(this);
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    supprimerToolStripMenuItem.Enabled = supprimerToolStripMenuItem.Enabled = true;

            //    if (Tools.paramUsers.getCurrentUser().param > 2)
            //    {
            //        if (dataGridView1.CurrentRow.Cells[1].ReadOnly == false)
            //            modifierToolStripMenuItem.Text = "Valider les modifications";
            //        else
            //            modifierToolStripMenuItem.Text = "Modifier";
            //    }
            //    else
            //        modifierToolStripMenuItem.Enabled = supprimerToolStripMenuItem.Enabled = false;
            //}
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                FicheHospitalisation frm = new FicheHospitalisation(this, dataGridView1.CurrentRow.Cells[0].Value.ToString(), 1);
                frm.ShowDialog();
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicheHospitalisation frm = new FicheHospitalisation(this, dataGridView1.CurrentRow.Cells[0].Value.ToString(), 2);
            frm.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous continuer ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Tools.executeLMD_Query("DELETE FROM hospitalisation WHERE idHospitalisation='" + dataGridView1.CurrentRow.Cells[0].Value + "'");
                    this.Refresh();
                }
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hospitalisationBindingSource.Filter = "idHospitalisation='" + toolStripComboBox1.Text + "'";
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            hospitalisationBindingSource.RemoveFilter();
            toolStripComboBox1.Text = string.Empty;
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void ajoutPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prescription frm = new Prescription(this, dataGridView1.CurrentRow.Cells[0].Value.ToString(), 4);
            frm.ShowDialog();
        }
    }
}
