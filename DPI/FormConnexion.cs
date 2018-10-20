using ConnexionDPI;
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
    public partial class FormConnexion : Form
    {
        Model mdl = new Model();
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            Tools.Connect();
           mdl.Bind("SELECT * FROM personnel", dPIDataSet.personnel);
           comboBox1.ResetText();
           this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty && comboBox1.SelectedValue.ToString() != string.Empty)
            {
                string password = Tools.executeSimpleQuery("SELECT password FROM users WHERE id_user='" + comboBox1.SelectedValue + "'");
                if (password == textBox1.Text)
                {
                    Tools.Close();
                    FormPrincipale frm = new FormPrincipale(int.Parse(comboBox1.SelectedValue.ToString()));
                    frm.Show();
                    //this.Close();
                }
                else
                {
                    label3.Visible = true;
                    label3.Text = "Mot de passe incorrecte !";
                }
            }
            else
            {
                label3.Text = "Utilisateur inconnu !";
                label3.Visible = true;
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}
