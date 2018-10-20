using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parametrage.Personnel
{
    public partial class FormPersonnels : Form
    {
        Model mdl = new Model();
        public FormPersonnels()
        {
            InitializeComponent();
        }

        private void FormPersonnels_Load(object sender, EventArgs e)
        {
            mdl.Bind("select * from service", paramDataSet.service);
            mdl.Bind("select * from specialite", paramDataSet.specialite);
            Utilitaire.chargerToolStripComboListe(specialiteBindingSource, paramDataSet.specialite, toolStripComboBox1, 1);
            mdl.Bind(dataGridView1, bindingNavigator1, paramDataSet.Personnel, personnelBindingSource, "select * from personnel");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }
        public override void Refresh()
        {
            paramDataSet.service.Clear();
            paramDataSet.specialite.Clear();
            paramDataSet.Personnel.Clear();
            toolStripComboBox1.Text = string.Empty;
            mdl.Bind("select * from service", paramDataSet.service);
            mdl.Bind("select * from specialite", paramDataSet.specialite);
            mdl.Bind(dataGridView1, bindingNavigator1, paramDataSet.Personnel, personnelBindingSource, "select * from personnel");
            Utilitaire.desactiverColonnes_All(dataGridView1);

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idspecialite = ConnexionDPI.Tools.executeSimpleQuery("select idSpecialite from specialite where nomSpecialite= '" + toolStripComboBox1.Text + "'");
            personnelBindingSource.Filter = "idSpecialite ='" + idspecialite + "'";

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = string.Empty;
            personnelBindingSource.RemoveFilter();
        }


        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                FichePersonnel frm = new FichePersonnel(this, dataGridView1.CurrentRow.Cells[0].Value.ToString(), 1);
                frm.ShowDialog();
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)

            {
                
                FichePersonnel frm = new FichePersonnel(this, dataGridView1.CurrentRow.Cells[0].Value.ToString(), 2);
                frm.ShowDialog();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous continuer ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnexionDPI.Tools.executeLMD_Query("Delete from personnel  WHERE idPersonnel='" + dataGridView1.CurrentRow.Cells[0].Value + "'");
                    this.Refresh();
                }
            }
        }



        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            FichePersonnel frm = new FichePersonnel(this);
            frm.ShowDialog();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }
    }
}
