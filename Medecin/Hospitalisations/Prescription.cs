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
    public partial class Prescription : Form
    {
        Model mdl = new Model();
        private FormHospitalisation frm;
        private string idHospitalisation;
        private int appel = 0;

        public Prescription()
        {
            InitializeComponent();
        }

        public Prescription(FormHospitalisation frm, string idHospitalisation, int appel)
        {
            InitializeComponent();
            this.frm = frm;
            this.idHospitalisation = idHospitalisation;
            this.appel = appel;
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            if (appel == 4)
            {
                
                mdl.Bind("SELECT * FROM personnel", medecinDataSet.personnel);

                mdl.Bind("SELECT * FROM hospitalisation where idHospitalisation=" + idHospitalisation, medecinDataSet.hospitalisation);
                mdl.Bind(dataGridView1, bindingNavigator1, medecinDataSet.Prescription, prescriptionBindingSource, "select * from prescription where prescription.idHospitalisation='" + idHospitalisation + "'");
                //    comboBox1.Enabled = false;
                comboBox1.ForeColor = Color.White;
                comboBox1.BackColor = Color.White;
                Utilitaire.desactiverColonnes_All(dataGridView1);

            }
        }

        public override void Refresh()
        {
           
            medecinDataSet.personnel.Clear();
            medecinDataSet.hospitalisation.Clear();
            medecinDataSet.Prescription.Clear();
            mdl.Bind("SELECT * FROM personnel", medecinDataSet.personnel);
            mdl.Bind("SELECT * FROM hospitalisation where idHospitalisation=" + idHospitalisation, medecinDataSet.hospitalisation);
            comboBox1.Enabled = false;
            mdl.Bind(dataGridView1, bindingNavigator1, medecinDataSet.Prescription, prescriptionBindingSource, "select * from prescription where prescription.idHospitalisation='" + idHospitalisation + "'");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    Utilitaire.activerCellules_All(dataGridView1, e.RowIndex);
            //}
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string medecin = Tools.executeSimpleQuery("select personnel.idPersonne from personnel,prescription  where personnel.idPersonne=prescription.idPersonne and personnel.nom='" + toolStripComboBox1.Text + "'");
           prescriptionBindingSource.Filter = "idPersonne='" + medecin + "'";
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           prescriptionBindingSource.RemoveFilter();
            toolStripComboBox1.Text = string.Empty;
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FichePrescription frm = new FichePrescription(this,idHospitalisation);
            frm.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FichePrescription frm = new FichePrescription(this, dataGridView1.CurrentRow.Cells[0].Value.ToString(), 2);
            frm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
