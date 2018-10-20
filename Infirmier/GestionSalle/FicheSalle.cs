using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConnexionDPI;


namespace Infirmier.GestionSalle
{
    public partial class FicheSalle : Form
    {
        Model modele = new Model();
        FormSalle form;
        string idSalle;
        int choix = 0;

        public FicheSalle()
        {
            InitializeComponent();
        }

        public FicheSalle(FormSalle form)
        {
            this.form = form;
            InitializeComponent();
        }

        public FicheSalle(FormSalle form, string idSalle, int choix)
        {
            this.form = form;
            this.idSalle = idSalle;
            this.choix = choix;
            InitializeComponent();
        }

        private void FicheSalle_Load(object sender, EventArgs e)
        {
            modele.Bind("select * from typedesalle", dataInfirmier.typedesalle);
            modele.Bind("select * from service", dataInfirmier.Service);
            if (choix>0)
            {
                modele.Bind("select * from salle where idSalle="+idSalle, dataInfirmier.Salle,salleBindingSource);
                if (choix == 1)
                {
                    desactiver();
                }
            }
        }

        private void desactiver()
        {
            textBox2.ReadOnly = textBox1.ReadOnly = textBox3.ReadOnly = true;
            comboBox1.Enabled = comboBox2.Enabled = false;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (choix == 0)
            {
               Tools.executeLMD_Query("INSERT INTO salle(idTypeDeSalle,idService,numeroSalle,capacite,disponibilite,prixParJour) VALUES ('" +
                            comboBox1.SelectedValue + "','" +
                            comboBox2.SelectedValue + "','" +
                            textBox1.Text + "','" +
                            textBox2.Text + "','" +
                            1 + "','" +
                            textBox3.Text + "')");
            }
            if (choix == 2)
            {
                Tools.executeLMD_Query("UPDATE salle SET idTypeDeSalle='" + comboBox1.SelectedValue
                           + "' , idService='"+ comboBox2.SelectedValue
                           + "' , numeroSalle='" + textBox1.Text
                           + "' , capacite='" + textBox2.Text
                           + "' , prixParJour='" + textBox3.Text
                           + "' WHERE idSalle='" + idSalle + "'");
            }
            form.Refresh();
            this.Close();
        }
    }
}
