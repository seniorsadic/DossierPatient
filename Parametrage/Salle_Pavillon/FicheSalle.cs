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
    public partial class FicheSalle : Form
    {
        Model mdl = new Model();
        FormSalle frm = new FormSalle();
        string idsalle;
        int appel = 0;

        public FicheSalle(FormSalle frm)
        {
            this.frm = frm;
            InitializeComponent();
        }
        public FicheSalle(FormSalle frm, string idsalle, int appel)
        {
            this.frm = frm;
            this.idsalle = idsalle;
            this.appel = appel;
            InitializeComponent();
        }
        public FicheSalle()
        {
            InitializeComponent();
        }

        private void FicheSalle_Load(object sender, EventArgs e)
        {

            mdl.Bind("select * from service", paramDataSet.service);
            mdl.Bind("select * from typedesalle", paramDataSet.typedesalle);
            if (appel > 0)
            {
                mdl.Bind("select * from salle where idSalle='" + idsalle + "'", paramDataSet.Salle);
                if (appel == 1)
                    desactiverTout(); 
            }

        }
        public override void Refresh()
        {
            paramDataSet.service.Clear();
            paramDataSet.typedesalle.Clear();
            
            mdl.Bind("select * from service", paramDataSet.service);
            mdl.Bind("select * from typedesalle", paramDataSet.typedesalle);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (appel == 0)
            {
                if (comboBox_typesalle.Text != string.Empty && comboBox_service.Text != string.Empty && textBox_capacite.Text != string.Empty && textBox_dispo.Text != string.Empty && textBox_numSalle.Text != string.Empty && textBox_prix.Text != string.Empty)
                {
               
                    ConnexionDPI.Tools.executeLMD_Query("INSERT INTO salle(idTypeDeSalle,idService,numeroSalle,capacite,disponibilite, prixParJour ) VALUES ('" +
                            comboBox_typesalle.SelectedValue + "','" +
                            comboBox_service.SelectedValue + "','" +
                            textBox_numSalle.Text + "','" +
                            textBox_capacite.Text + "','" +
                            textBox_dispo.Text + "','" +
                            textBox_prix.Text + "')");

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
 

        private void desactiverTout()
        {
            comboBox_typesalle.Enabled = comboBox_service.Enabled  = false;
            textBox_numSalle.ReadOnly = textBox_capacite.ReadOnly = textBox_dispo.ReadOnly = textBox_prix.ReadOnly = true; 
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
