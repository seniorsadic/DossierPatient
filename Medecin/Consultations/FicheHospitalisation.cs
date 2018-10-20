using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medecin.Consultations
{
    public partial class FicheHospitalisation : Form
    {
        public int idConsultation;
        public FormConsultationBis form = new FormConsultationBis();
        public DateTime date = DateTime.Now;

        public FicheHospitalisation()
        {
            InitializeComponent();
        }

        public FicheHospitalisation(FormConsultationBis form,int idConsultation)
        {
            this.form = form;
            this.idConsultation = idConsultation;
            InitializeComponent();
        }

        private void FicheHospitalisation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tools.executeLMD_Query("INSERT INTO hospitalisation(idConsultation,motif,dateDebut) VALUES ('" +
                            idConsultation + "','" +
                            textBox1.Text + "','" +
                            date.ToString("yyyy-MM-dd HH:mm:ss")  + "')");
            this.Close();
        }
    }
}
