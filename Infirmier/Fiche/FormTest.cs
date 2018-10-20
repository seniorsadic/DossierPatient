using ConnexionDPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Infirmier.Fiche
{
    public partial class FormTest : Form
    {
        Model modele = new Model();
        private Int32 oldRowIndex = 0;
        private const Int32 CUSTOM_CONTENT_HEIGHT = 30;
        public FormTest()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            // Set a cell padding to provide space for the top of the focus 
            // rectangle and for the content that spans multiple columns. 
            Padding newPadding = new Padding(0, 1, 0, CUSTOM_CONTENT_HEIGHT);
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = newPadding;

            // Set the selection background color to transparent so 
            // the cell won't paint over the custom selection background.
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor =
                Color.Transparent;

            // Set the row height to accommodate the content that 
            // spans multiple columns.
            this.dataGridView1.RowTemplate.Height += CUSTOM_CONTENT_HEIGHT;

            // Initialize other DataGridView properties.
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            Tools.Connect();
            modele.Bind("select * from personnel", dataInfirmier.personnel);
            modele.Bind(dataGridView1, bindingNavigator1, dataInfirmier.prescription, prescriptionBindingSource, "select * from prescription");
            Utilitaire.desactiverColonnes_All(dataGridView1);

            // Adjust the row heights to accommodate the normal cell content.
            this.dataGridView1.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            // Attach handlers to DataGridView events.
            this.dataGridView1.ColumnWidthChanged += new
                DataGridViewColumnEventHandler(dataGridView1_ColumnWidthChanged);
            this.dataGridView1.RowPrePaint += new
                DataGridViewRowPrePaintEventHandler(dataGridView1_RowPrePaint);
            this.dataGridView1.RowPostPaint += new
                DataGridViewRowPostPaintEventHandler(dataGridView1_RowPostPaint);
            this.dataGridView1.CurrentCellChanged += new
                EventHandler(dataGridView1_CurrentCellChanged);
            this.dataGridView1.RowHeightChanged += new
                DataGridViewRowEventHandler(dataGridView1_RowHeightChanged);
        }

        public override void Refresh()
        {
            dataInfirmier.personnel.Clear();
            dataInfirmier.prescription.Clear();
            modele.Bind("select * from personnel", dataInfirmier.personnel);
            modele.Bind(dataGridView1, bindingNavigator1, dataInfirmier.prescription, prescriptionBindingSource, "select * from prescription");
            Utilitaire.desactiverColonnes_All(dataGridView1);
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.ColumnCount)
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView2.ColumnCount)
                dataGridView2.CurrentCell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        public void reinitialiser()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int IdxLigneActuelle = e.RowIndex;
            DataGridViewRow ligne = dataGridView2.Rows[IdxLigneActuelle];

            string idTransmission = ligne.Cells[0].Value.ToString();
            string observations = ConnexionDPI.Tools.executeSimpleQuery("SELECT observations FROM transmission where idTransmission='" + idTransmission + "'");
            string problemes = ConnexionDPI.Tools.executeSimpleQuery("SELECT problemes FROM transmission where idTransmission='" + idTransmission + "'");
            string actions = ConnexionDPI.Tools.executeSimpleQuery("SELECT actions FROM transmission where idTransmission='" + idTransmission + "'");
            textBox3.Text = observations;
            textBox4.Text = problemes;
            textBox5.Text = actions;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView2.Visible = true;

            int IdxLigneActuelle = e.RowIndex;
            DataGridViewRow ligne = dataGridView1.Rows[IdxLigneActuelle];

            string idPrescription = ligne.Cells[0].Value.ToString();
            reinitialiser();
            string fait = ConnexionDPI.Tools.executeSimpleQuery("SELECT fait FROM prescription where idTraitement='" + idPrescription + "'");
            string traitement = ConnexionDPI.Tools.executeSimpleQuery("SELECT traitement FROM prescription where idTraitement='" + idPrescription + "'");
            textBox1.Text = fait;
            textBox2.Text = traitement;

            dataInfirmier.transmission.Clear();

            modele.Bind(dataGridView2, bindingNavigator1, dataInfirmier.transmission, transmissionBindingSource, "select * from transmission where idTraitement='" + idPrescription + "'");
            Utilitaire.desactiverColonnes_All(dataGridView2);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
          
                if (this.dataGridView1.Columns["Medecin"].Index ==
                    e.ColumnIndex && e.RowIndex >= 0)
                {
                    Rectangle newRect = new Rectangle(e.CellBounds.X + 1,
                        e.CellBounds.Y + 1, e.CellBounds.Width - 4,
                        e.CellBounds.Height - 4);

                    using (
                        Brush gridBrush = new SolidBrush(this.dataGridView1.GridColor),
                        backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                    {
                        using (Pen gridLinePen = new Pen(gridBrush))
                        {
                            // Erase the cell.
                            e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                            // Draw the grid lines (only the right and bottom lines;
                            // DataGridView takes care of the others).
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                                e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom - 1);
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                                e.CellBounds.Top, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom);

                            // Draw the inset highlight box.
                            e.Graphics.DrawRectangle(Pens.Blue, newRect);

                            // Draw the text content of the cell, ignoring alignment.
                            if (e.Value != null)
                            {
                                e.Graphics.DrawString((String)e.Value, e.CellStyle.Font,
                                    Brushes.Crimson, e.CellBounds.X + 2,
                                    e.CellBounds.Y + 2, StringFormat.GenericDefault);
                            }
                            e.Handled = true;
                        }
                    }
                }
            }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            this.dataGridView1.Invalidate();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Do not automatically paint the focus rectangle.
            e.PaintParts &= ~DataGridViewPaintParts.Focus;

            // Determine whether the cell should be painted
            // with the custom selection background.
            if ((e.State & DataGridViewElementStates.Selected) ==
                        DataGridViewElementStates.Selected)
            {
                // Calculate the bounds of the row.
                Rectangle rowBounds = new Rectangle(
                    this.dataGridView1.RowHeadersWidth, e.RowBounds.Top,
                    this.dataGridView1.Columns.GetColumnsWidth(
                        DataGridViewElementStates.Visible) -
                    this.dataGridView1.HorizontalScrollingOffset + 1,
                    e.RowBounds.Height);

                // Paint the custom selection background.
                using (Brush backbrush =
                    new System.Drawing.Drawing2D.LinearGradientBrush(rowBounds,
                        this.dataGridView1.DefaultCellStyle.SelectionBackColor,
                        e.InheritedRowStyle.ForeColor,
                        System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
                {
                    e.Graphics.FillRectangle(backbrush, rowBounds);
                }
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Calculate the bounds of the row.
            Rectangle rowBounds = new Rectangle(
                this.dataGridView1.RowHeadersWidth, e.RowBounds.Top,
                this.dataGridView1.Columns.GetColumnsWidth(
                    DataGridViewElementStates.Visible) -
                this.dataGridView1.HorizontalScrollingOffset + 1,
                e.RowBounds.Height);

            SolidBrush forebrush = null;
            try
            {
                // Determine the foreground color.
                if ((e.State & DataGridViewElementStates.Selected) ==
                    DataGridViewElementStates.Selected)
                {
                    forebrush = new SolidBrush(e.InheritedRowStyle.SelectionForeColor);
                }
                else
                {
                    forebrush = new SolidBrush(e.InheritedRowStyle.ForeColor);
                }

                // Get the content that spans multiple columns.
                object recipe =
                    this.dataGridView1.Rows.SharedRow(e.RowIndex).Cells[2].Value;

                if (recipe != null)
                {
                    String text = recipe.ToString();

                    // Calculate the bounds for the content that spans multiple 
                    // columns, adjusting for the horizontal scrolling position 
                    // and the current row height, and displaying only whole
                    // lines of text.
                    Rectangle textArea = rowBounds;
                    textArea.X -= this.dataGridView1.HorizontalScrollingOffset;
                    textArea.Width += this.dataGridView1.HorizontalScrollingOffset;
                    textArea.Y += rowBounds.Height - e.InheritedRowStyle.Padding.Bottom;
                    textArea.Height -= rowBounds.Height -
                        e.InheritedRowStyle.Padding.Bottom;
                    textArea.Height = (textArea.Height / e.InheritedRowStyle.Font.Height) *
                        e.InheritedRowStyle.Font.Height;

                    // Calculate the portion of the text area that needs painting.
                    RectangleF clip = textArea;
                    clip.Width -= this.dataGridView1.RowHeadersWidth + 1 - clip.X;
                    clip.X = this.dataGridView1.RowHeadersWidth + 1;
                    RectangleF oldClip = e.Graphics.ClipBounds;
                    e.Graphics.SetClip(clip);

                    // Draw the content that spans multiple columns.
                    e.Graphics.DrawString(
                        text, e.InheritedRowStyle.Font, forebrush, textArea);

                    e.Graphics.SetClip(oldClip);
                }
            }
            finally
            {
                forebrush.Dispose();
            }

            if (this.dataGridView1.CurrentCellAddress.Y == e.RowIndex)
            {
                // Paint the focus rectangle.
                e.DrawFocus(rowBounds, true);
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (oldRowIndex != -1)
            {
                this.dataGridView1.InvalidateRow(oldRowIndex);
            }
            oldRowIndex = this.dataGridView1.CurrentCellAddress.Y;
        }

        private void dataGridView1_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            // Calculate the new height of the normal cell content.
            Int32 preferredNormalContentHeight =
                e.Row.GetPreferredHeight(e.Row.Index,
                DataGridViewAutoSizeRowMode.AllCellsExceptHeader, true) -
                e.Row.DefaultCellStyle.Padding.Bottom;

            // Specify a new padding.
            Padding newPadding = e.Row.DefaultCellStyle.Padding;
            newPadding.Bottom = e.Row.Height - preferredNormalContentHeight;
            e.Row.DefaultCellStyle.Padding = newPadding;
        }
    }
}
