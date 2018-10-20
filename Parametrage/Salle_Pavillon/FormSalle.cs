using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parametrage.Salle_Pavillon
{
    public partial class FormSalle : Form
    {
        Model mdl = new Model();
        public FormSalle()
        {
            InitializeComponent();
        }

        private void FormSalle_Load(object sender, EventArgs e)
        {

            mdl.Bind("select * from service", paramDataSet.service);
            mdl.Bind("select * from typedesalle", paramDataSet.typedesalle);
            Utilitaire.chargerToolStripComboListe(serviceBindingSource, paramDataSet.service, toolStripComboBox1, 2);
            mdl.Bind(dataGridView1, bindingNavigator1, paramDataSet.Salle, salleBindingSource, "select * from salle");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }
        public override void Refresh()
        {
            paramDataSet.service.Clear();
            paramDataSet.typedesalle.Clear();
            paramDataSet.Salle.Clear();
            toolStripComboBox1.Text = string.Empty;
            mdl.Bind("select * from service", paramDataSet.service);
            mdl.Bind("select * from typedesalle", paramDataSet.typedesalle);
            mdl.Bind(dataGridView1, bindingNavigator1, paramDataSet.Salle, salleBindingSource, "select * from salle");
            Utilitaire.desactiverColonnes_All(dataGridView1);

        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idservice = ConnexionDPI.Tools.executeSimpleQuery("select idService from service where nomService= '" + toolStripComboBox1.Text + "'");
            salleBindingSource.Filter = "idService ='" + idservice + "'";

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = string.Empty;
            salleBindingSource.RemoveFilter();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                FicheSalle frm = new FicheSalle(this, dataGridView1.CurrentRow.Cells[0].Value.ToString(), 1);
                frm.ShowDialog();
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                FicheSalle frm = new FicheSalle(this, dataGridView1.CurrentRow.Cells[0].Value.ToString(), 2);
                frm.ShowDialog();
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous continuer ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnexionDPI.Tools.executeLMD_Query("Delete from salle ' WHERE idSalle='" + dataGridView1.CurrentRow.Cells[0].Value + "'");
                    this.Refresh();
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            FicheSalle frm = new FicheSalle(this);
            frm.ShowDialog();
        }
    }
}
