using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medecin.Consultations
{
    public partial class FicheConsultation : Form
    {
        Model mdl = new Model();
        private FormConsultation frm;
        private string idConsultation;
        private int appel = 0;// 0: ajout; 1: visualisation; 2: modification;

        public FicheConsultation()
        {
            InitializeComponent();
        }

        public FicheConsultation(FormConsultation frm)
        {
            
            this.frm = frm;
            InitializeComponent();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm">pour raffraichir le formulaire apres modification</param>
        /// <param name="idConsultation">pour filtrer la requete sur un disciplet</param>
        /// <param name="appel">permet de savoir s'il s'agit d'afficher juste les détails ou en faire un formulaire de modification</param>
        public FicheConsultation(FormConsultation frm, string idConsultation, int appel)
        {
            
            this.idConsultation = idConsultation;
            this.appel = appel;
            this.frm = frm;
            InitializeComponent();
        }

        private void FicheConsultation_Load(object sender, EventArgs e)
        {
            mdl.Bind("SELECT * FROM pathologie", medecinDataSet.pathologie);
            //comboBox_pathologie.ResetText();
            mdl.Bind("SELECT * FROM personnel", medecinDataSet.personnel);
            //comboBox_medecin.ResetText();
            mdl.Bind("SELECT * FROM patient", medecinDataSet.patient);
            //comboBox_patient.ResetText();

            if (appel > 0)//Clic-droit Détails or Clic-droit Modifier
            {

                mdl.Bind("SELECT * FROM consultation WHERE idConsultation  =" + idConsultation, medecinDataSet.consultation, consultationBindingSource);




                if (appel == 1)
                    desactiverTout();
            }
        }

        private void effacerTout()
        {
            comboBox_pathologie.ResetText();
            comboBox_medecin.ResetText();
            comboBox_patient.ResetText();
            textBox_numCons.Text = textBox_observation.Text = string.Empty;
            date.Text = string.Empty;
        }

        private void desactiverTout()
        {
            comboBox_medecin.Enabled = comboBox_patient.Enabled = comboBox_pathologie.Enabled = date.Enabled = false;
            textBox_observation.ReadOnly = textBox_numCons.ReadOnly = true;

            button1.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (appel == 0)
            {
                if (textBox_numCons.Text != string.Empty && textBox_observation.Text != string.Empty && date.Text != string.Empty && comboBox_pathologie.Text != string.Empty && comboBox_patient.Text != string.Empty && comboBox_medecin.Text != string.Empty)
                {

                    // string matricule = GenererMatricule();
                    Tools.executeLMD_Query("INSERT INTO consultation(idPathologie,idPersonne,idPatient,numeroConsultation,date,observationsPrescriptions) VALUES ('" +
                           comboBox_pathologie.SelectedValue + "','" +
                            comboBox_medecin.SelectedValue + "','" +
                         comboBox_patient.SelectedValue + "','" +
                           textBox_numCons.Text + "','" +
                          date.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                          textBox_observation.Text + "')");



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
            if (appel != 1)
                effacerTout();
            else
                this.Close();
        }
    }
}
