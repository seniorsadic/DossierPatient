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
    public partial class FichePrescription : Form
    {
        Model mdl = new Model();
        Model mdl1 = new Model();
        private Prescription frm;
        private string idPrescription;
        private string idHospitalisation;
        int appel = 0;

        public FichePrescription()
        {
            InitializeComponent();
        }

        public FichePrescription(Prescription frm,string idHospitalisation)
        {
            InitializeComponent();
            this.frm = frm;
            this.idHospitalisation = idHospitalisation;
        }
        public FichePrescription(Prescription frm, string idPrescription, int appel)
        {
            InitializeComponent();
            this.frm = frm;
            this.idPrescription = idPrescription;
            this.appel = appel;
        }


        private void FichePrescription_Load(object sender, EventArgs e)
        {
            mdl1.Bind("SELECT * FROM personnel", medecinDataSet.personnel);
            //comboBox_medecin.Text = Tools.paramUsers.getCurrentUser().getFullName();
            //comboBox_medecin.Enabled = false;
            if (appel > 0)
            {
                //comboBox_medecin.Text = Tools.paramUsers.getCurrentUser().getFullName();
                //comboBox_medecin.Enabled = false;
                mdl.Bind("select * from prescription where idPrescription='" + idPrescription + "'", medecinDataSet.Prescription, prescriptionBindingSource);
                if (appel == 1)
                    desactiverTout();
            }
        }

        private void effacerTout()
        {
            comboBox_medecin.ResetText();
            textBox_traitement.Text = textBox_fait.Text = string.Empty;

        }

        private void desactiverTout()
        {
            comboBox_medecin.Enabled = dateTimePicker1.Enabled = false;
            textBox_traitement.ReadOnly = textBox_fait.ReadOnly = true;
            button1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (appel == 0)
            {
                if (dateTimePicker1.Text != string.Empty && comboBox_medecin.Text != string.Empty && textBox_fait.Text != string.Empty && textBox_traitement.Text != string.Empty)
                {


                    Tools.executeLMD_Query("INSERT INTO prescription(idHospitalisation,idPersonne,fait,traitement,date) VALUES ('" +
                         idHospitalisation + "','" +
                         comboBox_medecin.SelectedValue + "','" +
                         textBox_fait.Text + "','" + 
                         textBox_traitement.Text + "','" +
                         dateTimePicker1.Value.Date.ToString("yyyy-MM-dd ") + "')");


                    frm.Refresh();
                    this.Close();
                }
                else
                    MessageBox.Show("Veillez renseigner tous les champs obligatoire !");
            }

            if (appel == 2)
            {
                Validate();
                mdl.Save();
                frm.Refresh();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (appel == 0)
            {
                effacerTout();
            }
            else
                this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
