using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConnexionDPI;
using System.Data.SqlClient;

namespace Infirmier.GestionSalle
{
    public partial class FormTypeSalle : Form
    {
        Model modele = new Model();

        public FormTypeSalle()
        {
            InitializeComponent();
        }

        private void FormTypeSalle_Load(object sender, EventArgs e)
        {
     
            modele.Bind(dataGridView1, bindingNavigator1, dataInfirmier.typedesalle, typedesalleBindingSource, "select * from typedesalle");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        public override void Refresh()
        {
            dataInfirmier.typedesalle.Clear();
            modele.Bind(dataGridView1, bindingNavigator1, dataInfirmier.typedesalle, typedesalleBindingSource, "select * from typedesalle");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            modele.Save();
            this.Refresh();
        }


        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Utilitaire.activerCellules_All(dataGridView1, e.RowIndex);
            }
        }
    }
}
