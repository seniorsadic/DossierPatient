using Connexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quincaillerie
{
    public partial class DossierPatient : Form
    {
        Modele model = new Modele();
        public DossierPatient()
        {
            InitializeComponent();
        }

        private void DossierPatient_Load(object sender, EventArgs e)
        {
            Connexion.Tools.Connect();
            model.Bind("select * from patient" , test.patient);
            ListViewItem lvi = new ListViewItem("Bien");
            lvi.SubItems.Add("Bien1");
            listView1.Items.Add(lvi);
            comboBox1.AutoCompleteCustomSource.Add("Bien");
            comboBox1.AutoCompleteCustomSource.Add("Test");
            comboBox1.AutoCompleteCustomSource.Add("Tester");
            comboBox1.AutoCompleteCustomSource.Add("Bienvenue");
        }
    }
}
