using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parametrage.Soins_Examen
{
    public partial class FicheExamen : Form
    {
        Model mdl = new Model();
        public FicheExamen()
        {
            InitializeComponent();
        }

        private void FicheExamen_Load(object sender, EventArgs e)
        {
            mdl.Bind(dataGridView1, bindingNavigator1, paramDataSet.examen, examenBindingSource, "select * from examen");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Utilitaire.activerCellules_All(dataGridView1, e.RowIndex);
            }
        }

        public override void Refresh()
        {
            paramDataSet.examen.Clear();
            mdl.Bind(dataGridView1, bindingNavigator1, paramDataSet.examen, examenBindingSource, "select * from examen");
            Utilitaire.desactiverColonnes_All(dataGridView1);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            mdl.Save();
            this.Refresh();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                modifierToolStripMenuItem.Enabled = supprimerToolStripMenuItem.Enabled = true;

                if (ConnexionDPI.Tools.paramUsers.getCurrentUser().param > 2)
                {
                    if (dataGridView1.CurrentRow.Cells[1].ReadOnly == false)
                        modifierToolStripMenuItem.Text = "Valider les modifications";
                    else
                        modifierToolStripMenuItem.Text = "Modifier";
                }
                else
                    modifierToolStripMenuItem.Enabled = supprimerToolStripMenuItem.Enabled = false;
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.CurrentRow.Cells[1].ReadOnly == true)
                {
                    Utilitaire.activerCellules_All(dataGridView1, dataGridView1.CurrentRow.Index);
                }
                else
                {
                    Validate();
                    mdl.Save();
                    this.Refresh();
                }
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous continuer ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnexionDPI.Tools.executeLMD_Query("Delete from examen WHERE idExam='" + dataGridView1.CurrentRow.Cells[0].Value + "'");
                    this.Refresh();
                }
            }
        }

    }
}
