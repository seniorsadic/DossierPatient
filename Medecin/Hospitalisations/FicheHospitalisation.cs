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
    public partial class FicheHospitalisation : Form
    {
        Model mdl = new Model();
        Model mdl1 = new Model();
        private FormHospitalisation frm;
        private string idHospitalisation;
        private int appel = 0;// 0: ajout; 1: visualisation; 2: modification;

        public FicheHospitalisation()
        {
            InitializeComponent();
        }

        public FicheHospitalisation(FormHospitalisation frm)
        {
            InitializeComponent();
            this.frm = frm;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm">pour raffraichir le formulaire apres modification</param>
        /// <param name="idConsultation">pour filtrer la requete sur un disciplet</param>
        /// <param name="appel">permet de savoir s'il s'agit d'afficher juste les détails ou en faire un formulaire de modification</param>
        public FicheHospitalisation(FormHospitalisation frm, string idHospitalisation, int appel)
        {
            InitializeComponent();
            this.idHospitalisation = idHospitalisation;
            this.appel = appel;
            this.frm = frm;
        }


       

        private void FicheHospitalisation_Load(object sender, EventArgs e)
        {
           
           
            mdl1.Bind("SELECT * FROM consultation", medecinDataSet.consultation);
            //comboBox_consultation.ResetText();

            if (appel > 0)//Clic-droit Détails or Clic-droit Modifier
            {

                mdl.Bind("SELECT * FROM hospitalisation WHERE idHospitalisation  ='" + idHospitalisation + "'", medecinDataSet.hospitalisation, hospitalisationBindingSource);




                if (appel == 1)
                    desactiverTout();
            }
        }

        private void effacerTout()
        {
           
            comboBox_consultation.ResetText();
            textBox_motif.Text = textBox_motif.Text = string.Empty;
            datedebut.Text = dateFin.Text= string.Empty;
        }

        private void desactiverTout()
        {
          datedebut.Enabled=dateFin.Enabled = comboBox_consultation.Enabled = false;
            textBox_mode.ReadOnly = textBox_motif .ReadOnly = true;

            button1.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (appel == 0)
            {
                if ( textBox_motif.Text != string.Empty && datedebut.Text != string.Empty && comboBox_consultation.Text != string.Empty)
                {

                    // string matricule = GenererMatricule();
                    Tools.executeLMD_Query("INSERT INTO hospitalisation(idConsultation,motif,dateDebut,dateFin,modeSortie) VALUES ('" +
                           comboBox_consultation.SelectedValue + "','" +
                           textBox_motif.Text + "','" +
                           datedebut.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                           dateFin.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                           textBox_mode.Text + "')");

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
