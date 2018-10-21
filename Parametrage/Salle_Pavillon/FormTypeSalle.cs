﻿using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parametrage.Salle_Pavillon
{
    public partial class FormTypeSalle : Form
    {
        Model modele = new Model();

        public FormTypeSalle()
        {
            InitializeComponent();
        }

        private void FormTypeSalle_Load(object sender, EventArgs e)
        {

            modele.Bind(dataGridView1, bindingNavigator1, paramDataSet.typedesalle, typedesalleBindingSource, "select * from typedesalle");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        public override void Refresh()
        {
            paramDataSet.typedesalle.Clear();
            modele.Bind(dataGridView1, bindingNavigator1, paramDataSet.typedesalle, typedesalleBindingSource, "select * from typedesalle");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Validate();
            modele.Save();
            this.Refresh();
        }


        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Utilitaire.activerCellules_All(dataGridView1, e.RowIndex);
            }
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
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
                    modele.Save();
                    this.Refresh();
                }
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                modifierToolStripMenuItem.Enabled = supprimerToolStripMenuItem.Enabled = true;

                if (ConnexionDPI.Tools.paramUsers.getCurrentUser().param > 2)
                {
                    if (dataGridView1.CurrentRow.Cells[1].ReadOnly == false)
                        modifierToolStripMenuItem.Text = "Valider les modifications";
                    else
                        modifierToolStripMenuItem.Text = "Modifier";
                }
                else
                    modifierToolStripMenuItem.Enabled = supprimerToolStripMenuItem.Enabled = false;
            }
        }

       
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (MessageBox.Show("Voulez-vous continuer ?", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ConnexionDPI.Tools.executeLMD_Query("Delete from typedesalle WHERE idTypeDeSalle='" + dataGridView1.CurrentRow.Cells[0].Value + "'");
                    this.Refresh();
                }
            }
        }
    }
}
