
using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parametrage.Personnel
{
    public partial class FichePersonnel : Form
    {

        Model mdl = new Model();
        private FormPersonnels frm = new FormPersonnels();
        private string idpersonnel;
        private int appel = 0;
        
        public FichePersonnel(FormPersonnels frm)
        {
            this.frm = frm;
            InitializeComponent();
        }
        public FichePersonnel(FormPersonnels frm, string idpersonnel, int appel)
        {
            
            this.frm = frm;
            this.idpersonnel = idpersonnel;
            this.appel = appel;
            InitializeComponent();
        }
        public FichePersonnel()
        {
            InitializeComponent();
        }

        private void FichePersonnel_Load(object sender, EventArgs e)
        {
            mdl.Bind("select * from service", paramDataSet.service);
            mdl.Bind("select * from specialite", paramDataSet.specialite);
            if (appel > 0)
            {
                mdl.Bind("select * from personnel where idPersonnel='" + idpersonnel + "'", paramDataSet.Personnel);
                if (appel == 1)
                    desactiverTout();
            }
       
        }
        public override void Refresh()
        {
            paramDataSet.service.Clear();
            paramDataSet.specialite.Clear();
            comboBox_genre.Text = string.Empty;
            mdl.Bind("select * from service", paramDataSet.service);
            mdl.Bind("select * from specialite", paramDataSet.specialite);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (appel == 0)
            {
                if(textBox_nom.Text != string.Empty && comboBox_genre.Text != string.Empty && comboBox_service.Text != string.Empty && comboBox_specialite.Text != string.Empty && textBox_ancienete.Text != string.Empty && textBox_adresse.Text != string.Empty && dateTimePicker_dateN.Text != string.Empty && textBox_lieuN.Text != string.Empty && textBox_telephone.Text != string.Empty)
                {
                    int age = DateTime.Now.Year - Convert.ToDateTime(dateTimePicker_dateN.Text).Year;
                    ConnexionDPI.Tools.executeLMD_Query("INSERT INTO personnel(idService,idSpecialite,matricule,anciente,nom, age, sexe, adresse, datenaissance, lieuNaiissance, telephone ) VALUES ('" +
                            comboBox_service.SelectedValue + "','" +
                            comboBox_specialite.SelectedValue + "','" +
                            GenererMatricule() + "','" +
                            textBox_ancienete.Text + "','" +
                            textBox_nom.Text + "','" +
                            age + "','" +
                            comboBox_genre.Text + "','" +
                            textBox_adresse.Text + "','" +
                            dateTimePicker_dateN.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                            textBox_lieuN.Text + "','" +
                            textBox_telephone.Text + "')");

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
        private string GenererMatricule()
        {
            string[] stringSeparators = new string[] { " " };
            string[] result = new string[3];
            string nom = null;
            string prenom = null;
            int idPersonnel = int.Parse(ConnexionDPI.Tools.executeSimpleQuery("select max(idPersonnel) from personnel")) + 1;
            // 
            string nomcomplet = textBox_nom.Text;
            result = nomcomplet.Split(stringSeparators, StringSplitOptions.None);
            for (int i = 0; i < result.Length; i++)
            {
                prenom = result[0].Substring(0, 2).ToUpper();
                nom = result[result.Length - 1].Substring(0, 2).ToUpper();

            }

            string date = Convert.ToDateTime(dateTimePicker_dateN.Value).Year.ToString();
            string matricule = String.Concat(prenom, nom, date, (0000 + idPersonnel).ToString());
            return matricule;
        }

        private void desactiverTout()
        {
            comboBox_specialite.Enabled = comboBox_genre.Enabled = comboBox_service.Enabled = dateTimePicker_dateN.Enabled = false;
            textBox_adresse.ReadOnly = textBox_ancienete.ReadOnly = textBox_lieuN.ReadOnly = textBox_nom.ReadOnly = true;
            textBox_telephone.ReadOnly = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
