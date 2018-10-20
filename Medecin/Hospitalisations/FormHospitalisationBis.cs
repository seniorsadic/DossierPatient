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

namespace Medecin.Hospitalisations
{
    public partial class FormHospitalisationBis : Form
    {
        Model model = new Model();
        public FormHospitalisationBis()
        {
            InitializeComponent();
        }

        private void FormHospitalisationBis_Load(object sender, EventArgs e)
        {
            model.Bind("select * from hospitalisation ", medecinDataSet.hospitalisation);
            chargerHospitalisation();
        }

        public void chargerHospitalisation()
        {
           // TreeNode newNode;
            DataTable tester = medecinDataSet.hospitalisation;
            foreach (DataRow empR in tester.Rows)
            {
                treeView1.Nodes.Add(empR["idConsultation"].ToString());
            }
        }
    }
}
