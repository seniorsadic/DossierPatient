using Infirmier.GestionSalle;
using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Infirmier.Fiche;

namespace Infirmier
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tools.Connect();
            FormSalle form = new FormSalle();
          //  FormPrescription form = new FormPrescription();
            //  FormTypeSalle form = new FormTypeSalle();
          //  FormPriseTT form = new FormPriseTT();
            this.Visible = true;
            form.Show();
        }
    }
}
