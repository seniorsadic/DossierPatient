using ConnexionDPI;
using Medecin.Consultations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medecin.Ordonnance
{
    public partial class FicheOrdonnance : Form
    {
        Model model = new Model();
        string idOrdonnance;
        FormConsultationBis form = new FormConsultationBis();

        public FicheOrdonnance()
        {
            InitializeComponent();
        }

        public FicheOrdonnance(FormConsultationBis form, string idOrdonnance)
        {
            this.form = form;
            this.idOrdonnance = idOrdonnance;
            InitializeComponent();
        }
        private void FicheOrdonnance_Load(object sender, EventArgs e)
        {
            model.Bind("select * from medicamentordonnance where idOrdonnance="+idOrdonnance, medecinDataSet.medicamentordonnance);
            this.reportViewer1.RefreshReport();
        }
    }
}
