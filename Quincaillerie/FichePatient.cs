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
    public partial class FichePatient : Form
    {
      
        private Form2 f=new Form2();

        public FichePatient()
        {
            InitializeComponent();
        }

        public FichePatient(Form2 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            if (textBox1.Text != string.Empty && textBox6.Text != string.Empty)
            {
                Connexion.Tools.executeLMD_Query("INSERT INTO patient(numeroPatient,poids,groupeSanguin,tension,profession,taille,nom,prenom,age,sexe,adresse,dateNaissance,lieuNaissance) VALUES ('" +
                     textBox1.Text.ToUpper() + ""+a.Next(100000000,999999999) + "','" +
                     0 + "','" +
                     comboBox2.Text + "','" +
                     textBox4.Text + "','" +
                     textBox2.Text + "','" +
                     0 + "','" +
                     textBox1.Text + "','" +
                     textBox6.Text + "','" +
                     0 + "','" +
                     comboBox1.Text + "','" +
                     textBox3.Text + "','" +                  
                     dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                     textBox8.Text + "')");
                f.Refresh();
                this.Close();
            }
            else
            {
                label8.Visible = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
