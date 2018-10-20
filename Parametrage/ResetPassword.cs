
using ConnexionDPI;
using Parametrage.Personnel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parametrage
{
    public partial class ResetPassword : Form
    {
        private int id_user;
        private FrmUtilisateur frmutilisateur;
        public ResetPassword()
        {
            InitializeComponent();
        }
        public ResetPassword(int id_user, FrmUtilisateur frmutilisateur)
        {
            InitializeComponent();
            this.id_user = id_user;
            this.frmutilisateur = frmutilisateur;
        }
        private void ResetPassword_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox1.Text == textBox2.Text)
            {
               Tools.executeLMD_Query("UPDATE users SET password='" + textBox1.Text + "' WHERE id_user='" + id_user + "'");
                this.Close();
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Erreur de confirmation ! ";
            }
            frmutilisateur.Refresh();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
