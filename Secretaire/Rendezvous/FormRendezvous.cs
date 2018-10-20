using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Secretaire.Rendezvous
{
    public partial class FormRendezvous : Form
    {
        Model mdl = new Model();
        public FormRendezvous()
        {
            InitializeComponent();
        }

        private void FormRendezvous_Load(object sender, EventArgs e)
        {
            //ConnexionDPI.Tools.Connect();
            mdl.Bind("select * from patient", secretaireDataSet.patient);
            mdl.Bind("select * from personnel", secretaireDataSet.personnel);
            mdl.Bind("select * from consultation", secretaireDataSet.consultation);
            //Utilitaire.chargerToolStripComboListe(specialiteBindingSource, paramDataSet.specialite, toolStripComboBox1, 1);
            mdl.Bind(dataGridView1, bindingNavigator1, secretaireDataSet.rendezvous, bindingSourceRendezvous, "select * from rendezvous");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        public override void Refresh()
        {
            secretaireDataSet.rendezvous.Clear();
            toolStripComboBox1.Text = string.Empty;
            mdl.Bind(dataGridView1, bindingNavigator1, secretaireDataSet.rendezvous, bindingSourceRendezvous, "select * from rendezvous");
            Utilitaire.desactiverColonnes_All(dataGridView1);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FicheRendezvous ficheRendezvous = new FicheRendezvous(this);
            ficheRendezvous.ShowDialog();
        }
    }
}
