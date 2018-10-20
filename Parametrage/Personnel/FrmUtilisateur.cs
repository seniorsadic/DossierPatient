

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
    public partial class FrmUtilisateur : Form
    {
        Model mdl = new Model();
        public FrmUtilisateur()
        {
            InitializeComponent();
        }
        
        private void FrmUtilisateur_Load(object sender, EventArgs e)
        {
           // mdl.Bind("SELECT * FROM users", paramDataSet.users);
            mdl.Bind(dataGridView1, bindingNavigator1, paramDataSet.users, usersBindingSource, "SELECT * FROM users");
            classerUtilisateur();
           Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        public override void Refresh()
        {
            paramDataSet.users.Clear();
            mdl.Bind(dataGridView1, bindingNavigator1, paramDataSet.users, usersBindingSource, "SELECT * FROM users");
            classerUtilisateur();
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }
        private void classerUtilisateur()
        {
            foreach (DataGridViewRow dr in this.dataGridView1.Rows)
            {
                if (int.Parse(dr.Cells[7].Value.ToString()) == 0)
                    dr.DefaultCellStyle.BackColor = Color.LightGray;
                else
                    dr.DefaultCellStyle.BackColor = Color.White;
                if (int.Parse(dr.Cells[0].Value.ToString()) == 1)//SuperAdmin
                    dr.ReadOnly = true;
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                Utilitaire.activerCellules_All(dataGridView1, e.RowIndex);
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (int.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString()) == 0)
                {
                    desactiverLeCompteToolStripMenuItem.Text = "Activer le compte";
                    reinitialiserMotDePasseToolStripMenuItem.Enabled = false;
                }
                else
                {
                    desactiverLeCompteToolStripMenuItem.Text = "Désactiver le compte";
                    if (int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) == 1)//on suppose que SupAdmin est le user n 1
                        desactiverLeCompteToolStripMenuItem.Enabled = false;
                    else
                    {
                        desactiverLeCompteToolStripMenuItem.Enabled = true;
                        reinitialiserMotDePasseToolStripMenuItem.Enabled = true;
                    }
                }

                modifierLutilisateurToolStripMenuItem.Enabled = true;

                if (Tools.paramUsers.getCurrentUser().param > 2)
                {
                    if (dataGridView1.CurrentRow.Cells[1].ReadOnly == false)
                        modifierLutilisateurToolStripMenuItem.Text = "Valider les modifications";
                    else
                        modifierLutilisateurToolStripMenuItem.Text = "Modifier";
                }
                else
                    modifierLutilisateurToolStripMenuItem.Enabled = false;
            }
        }

        private void modifierLutilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.CurrentRow.Cells[1].ReadOnly == true)
                {
                    Utilitaire.activerCellules_All(dataGridView1, dataGridView1.CurrentRow.Index);
                }
                else
                {
                    Validate();
                    mdl.Save();
                    this.Refresh();
                }
            }
        }

        private void reinitialiserMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                ResetPassword frm = new ResetPassword(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), this);
                frm.ShowDialog();
            }
        }

        private void desactiverLeCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (int.Parse(dataGridView1.CurrentRow.Cells[13].Value.ToString()) == 0)
                {
                    Tools.executeLMD_Query("UPDATE users SET statut='1' WHERE id_user='" + dataGridView1.CurrentRow.Cells[0].Value + "'");
                    desactiverLeCompteToolStripMenuItem.Text = "Désactiver le compte";
                }
                else
                {
                    Tools.executeLMD_Query("UPDATE users SET statut='0' WHERE id_user='" + dataGridView1.CurrentRow.Cells[0].Value + "'");
                    desactiverLeCompteToolStripMenuItem.Text = "Activer le compte";
                }
                Refresh();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            mdl.Save();
            this.Refresh();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
