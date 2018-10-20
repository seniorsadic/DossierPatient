using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DPI
{
    public partial class FormPrincipale : Form
    {

        private int id_dirigeant;

        public FormPrincipale(int id_dirigeant)
        {
            InitializeComponent();
            this.id_dirigeant = id_dirigeant;
        }

        public FormPrincipale()
        {
            InitializeComponent();
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            ConnexionDPI.Tools.Connect();

            ConnexionDPI.Tools.loadParamUsers(id_dirigeant);

            toolStripStatusLabel1.Text = ConnexionDPI.Tools.paramUsers.getCurrentUser().getFullName() + " est connecté(e)";

            tabControl1.Controls.Remove(tabControl1.SelectedTab);//supprimer l'onglet par defaut
            creerMenuHorizontal();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Controls.Remove(this.tabControl1.SelectedTab);
        }

        private void creerMenuHorizontal()
        {
            //if (param == 0)
            //    paramétrageToolStripMenuItem.Visible = false;
            //if (admin == 0)
            //    administrationToolStripMenuItem.Visible = false;
            //if (im == 0)
            //    inscriptionMensualitéToolStripMenuItem.Visible = false;
            //if (gp = 3)
            //    gestionPédagogiqueToolStripMenuItem.Enabled = false;
            //if (me = 3)
            //    matérielEtÉquipementToolStripMenuItem.Enabled = false;
        }

        //------------- DEBUT CREATION ONGLET---------------------

        private bool existeOnglet(string nomOnglet)
        {
            foreach (TabPage tp in this.tabControl1.TabPages)
            {
                if (tp.Text == nomOnglet)
                {
                    this.tabControl1.SelectedTab = tp;//il le met au premier plan s'il est deja ouvert
                    return true;
                }
            }
            return false;
        }

        private void creerOnglet(string titre, Form MyForm)
        {
            TabPage tp = new TabPage(titre);
            Panel pan = new Panel();
            pan.Dock = DockStyle.Fill;
            tp.Controls.Add(pan);

            MyForm.TopLevel = false;
            MyForm.FormBorderStyle = FormBorderStyle.None;
            MyForm.Parent = pan;//definir le panel comme parent du Form
            MyForm.Top = 0;
            MyForm.Left = 0;

            MyForm.Dock = DockStyle.Fill;
            MyForm.BringToFront();
            MyForm.Show();

            //rattacher la tabPage au tabcontrol
            this.tabControl1.TabPages.Add(tp);
            //mettre l'onglet choisi au premier plan
            this.tabControl1.SelectedTab = tp;
        }

        public static Form choisirForm(string className)
        {
            if (className.Contains("Parametrage"))
                return Parametrage.Utilitaire.choisirForm(className);
            else if (className.Contains("Infirmier"))
                return Infirmier.Utilitaire.choisirForm(className);
            else if (className.Contains("Medecin"))
                return Medecin.Utilitaire.choisirForm(className);
            else if (className.Contains("Secretaire"))
                return Secretaire.Utilitaire.choisirForm(className);
            //else
            //                if (className.Contains("Administration"))
            //    return Administration.Utilitaire.choisirForm(className);

            System.Type objType = System.Type.GetType("DPI." + className);
            if (objType != null)
            {
                object objInstanceDynamique = System.Activator.CreateInstance(objType);
                Form frm = objInstanceDynamique as Form;
                return frm;
            }
            else
                MessageBox.Show("Le type semble être incorrect!");

            
            return null;
        }

        private void afficherForm(string className, string titre)
        {
            if (!existeOnglet(titre))
            {
                Form frm = choisirForm(className);//
                if (frm != null)
                    creerOnglet(titre, frm);
            }
        }

        //------------- FIN CREATION ONGLET---------------------

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.Controls.Count > 0)
            {
                Form form = tabControl1.SelectedTab.Controls[0].Controls[0] as Form;
                form.Refresh();
            }
            //if(tabControl1.Name == "Gestion Passage")
            //{
            //    foreach (TabPage tp in this.tabControl1.TabPages)
            //        if (this.tabControl1.Name.Equals("Administration Passage"))
            //            this.tabControl1.Controls.Remove(tp);
            //}
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.Controls.Remove(this.tabControl1.SelectedTab);
        }

        private void fermerLesAutresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in this.tabControl1.TabPages)
                if (tp != this.tabControl1.SelectedTab)
                    this.tabControl1.Controls.Remove(tp);
        }

       

        

      

        private void voletPédagogiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Secretaire.Rendezvous.FormPatient", "Patient");
        }

       

        private void PavillonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Parametrage.Salle_Pavillon.FichePavillon", "Pavillon");
        }

        private void SallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Parametrage.Salle_Pavillon.FormSalle", "Salle");
        }

        private void ExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Parametrage.Soins_Examen.FicheExamen", "Examen");
        }

        private void InterventionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Parametrage.Soins_Examen.FicheTypeIntervention", "TypeIntervention");
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Parametrage.Personnel.FicheService", "Service");
        }

        private void spécialitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Parametrage.Personnel.FicheSpecialite", "Spécialité");
        }

        private void personnelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            afficherForm("Parametrage.Personnel.FormPersonnels", "Personnels");
        }

        private void lesDisciplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Secretaire.Rendezvous.Rendezvous", "Rendez vous");
        }


        private void consultationtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            afficherForm("Medecin.Consultations.FormConsultation", "Consultation");
        }

        private void hospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Medecin.Hospitalisations.FormHospitalisation", "Hospitalisation");
        }

        private void dossierpatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            afficherForm("Medecin.DosierPatient.FormPatient", "Patient");
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Medecin.Hospitalisations.Prescription", "Prescription");
        }

       

        private void typeDeSalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Infirmier.GestionSalle.FormSalle", "Salle");
        }

        private void typeDeSalleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            afficherForm("Parametrage.Salle_Pavillon.FormTypeSalle", "Type Salle");
        }

        private void consultationBisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Medecin.Consultations.FormConsultationBis", "ConsultationBis");
        }

        private void mesRvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Medecin.Consultations.FormRendezvousMedecin", "MesRv");
        }

        private void hospiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficherForm("Medecin.Hospitalisations.FormHospitalisationBis", "MesHos");
        }
    }
}
