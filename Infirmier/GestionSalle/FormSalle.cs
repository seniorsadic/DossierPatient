using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Infirmier.GestionSalle
{
    public partial class FormSalle : Form
    {
        Model modele = new Model();

        public FormSalle()
        {
            InitializeComponent();
        }

        private void FormSalle_Load(object sender, EventArgs e)
        {
            modele.Bind("select * from service", dataInfirmier.Service);
            modele.Bind("select * from typedesalle", dataInfirmier.typedesalle);
            modele.Bind(dataGridView1,bindingNavigator1,dataInfirmier.Salle,salleBindingSource,"select * from salle");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        public override void Refresh()
        {
            dataInfirmier.Service.Clear();
            dataInfirmier.typedesalle.Clear();
            dataInfirmier.Salle.Clear();
            modele.Bind("select * from service", dataInfirmier.Service);
            modele.Bind("select * from typedesalle", dataInfirmier.typedesalle);
            modele.Bind(dataGridView1, bindingNavigator1, dataInfirmier.Salle, salleBindingSource, "select * from salle");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FicheSalle fiche = new FicheSalle(this);
            fiche.ShowDialog();
        }

        private void détailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicheSalle fiche = new FicheSalle(this,dataGridView1.CurrentRow.Cells[0].Value.ToString(),1);
            fiche.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicheSalle fiche = new FicheSalle(this, dataGridView1.CurrentRow.Cells[0].Value.ToString(), 2);
            fiche.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }
    }
}
