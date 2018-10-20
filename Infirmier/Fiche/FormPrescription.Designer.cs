namespace Infirmier.Fiche
{
    partial class FormPrescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrescription));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idTraitementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHospitalisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hospitalisationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataInfirmier = new Infirmier.DataInfirmier();
            this.idPersonneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traitementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ficheDeTransmissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.transmissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTransmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idTraitementDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTraitementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalisationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInfirmier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transmissionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTraitementDataGridViewTextBoxColumn,
            this.idHospitalisationDataGridViewTextBoxColumn,
            this.idPersonneDataGridViewTextBoxColumn,
            this.faitDataGridViewTextBoxColumn,
            this.traitementDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.prescriptionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 236);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // idTraitementDataGridViewTextBoxColumn
            // 
            this.idTraitementDataGridViewTextBoxColumn.DataPropertyName = "idTraitement";
            this.idTraitementDataGridViewTextBoxColumn.HeaderText = "idTraitement";
            this.idTraitementDataGridViewTextBoxColumn.Name = "idTraitementDataGridViewTextBoxColumn";
            this.idTraitementDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTraitementDataGridViewTextBoxColumn.Visible = false;
            // 
            // idHospitalisationDataGridViewTextBoxColumn
            // 
            this.idHospitalisationDataGridViewTextBoxColumn.DataPropertyName = "idHospitalisation";
            this.idHospitalisationDataGridViewTextBoxColumn.DataSource = this.hospitalisationBindingSource;
            this.idHospitalisationDataGridViewTextBoxColumn.DisplayMember = "idHospitalisation";
            this.idHospitalisationDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idHospitalisationDataGridViewTextBoxColumn.HeaderText = "Numéro Hospitalisation";
            this.idHospitalisationDataGridViewTextBoxColumn.Name = "idHospitalisationDataGridViewTextBoxColumn";
            this.idHospitalisationDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHospitalisationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idHospitalisationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idHospitalisationDataGridViewTextBoxColumn.ValueMember = "idHospitalisation";
            // 
            // hospitalisationBindingSource
            // 
            this.hospitalisationBindingSource.DataMember = "hospitalisation";
            this.hospitalisationBindingSource.DataSource = this.dataInfirmier;
            // 
            // dataInfirmier
            // 
            this.dataInfirmier.DataSetName = "DataInfirmier";
            this.dataInfirmier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idPersonneDataGridViewTextBoxColumn
            // 
            this.idPersonneDataGridViewTextBoxColumn.DataPropertyName = "idPersonne";
            this.idPersonneDataGridViewTextBoxColumn.DataSource = this.personnelBindingSource;
            this.idPersonneDataGridViewTextBoxColumn.DisplayMember = "nom";
            this.idPersonneDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idPersonneDataGridViewTextBoxColumn.HeaderText = "Medecin";
            this.idPersonneDataGridViewTextBoxColumn.Name = "idPersonneDataGridViewTextBoxColumn";
            this.idPersonneDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPersonneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idPersonneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idPersonneDataGridViewTextBoxColumn.ValueMember = "idPersonne";
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataMember = "personnel";
            this.personnelBindingSource.DataSource = this.dataInfirmier;
            // 
            // faitDataGridViewTextBoxColumn
            // 
            this.faitDataGridViewTextBoxColumn.DataPropertyName = "fait";
            this.faitDataGridViewTextBoxColumn.HeaderText = "Fait";
            this.faitDataGridViewTextBoxColumn.Name = "faitDataGridViewTextBoxColumn";
            this.faitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // traitementDataGridViewTextBoxColumn
            // 
            this.traitementDataGridViewTextBoxColumn.DataPropertyName = "traitement";
            this.traitementDataGridViewTextBoxColumn.HeaderText = "Traitement";
            this.traitementDataGridViewTextBoxColumn.Name = "traitementDataGridViewTextBoxColumn";
            this.traitementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheDeTransmissionsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 26);
            // 
            // ficheDeTransmissionsToolStripMenuItem
            // 
            this.ficheDeTransmissionsToolStripMenuItem.Name = "ficheDeTransmissionsToolStripMenuItem";
            this.ficheDeTransmissionsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ficheDeTransmissionsToolStripMenuItem.Text = "Fiche de transmissions";
            this.ficheDeTransmissionsToolStripMenuItem.Click += new System.EventHandler(this.ficheDeTransmissionsToolStripMenuItem_Click);
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "prescription";
            this.prescriptionBindingSource.DataSource = this.dataInfirmier;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(760, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransmissionDataGridViewTextBoxColumn,
            this.idPersonneDataGridViewTextBoxColumn1,
            this.idTraitementDataGridViewTextBoxColumn1,
            this.observationsDataGridViewTextBoxColumn,
            this.problemesDataGridViewTextBoxColumn,
            this.actionsDataGridViewTextBoxColumn,
            this.dateTraitementDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.transmissionBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(760, 156);
            this.dataGridView2.TabIndex = 0;
            // 
            // transmissionBindingSource
            // 
            this.transmissionBindingSource.DataMember = "transmission";
            this.transmissionBindingSource.DataSource = this.dataInfirmier;
            // 
            // idTransmissionDataGridViewTextBoxColumn
            // 
            this.idTransmissionDataGridViewTextBoxColumn.DataPropertyName = "idTransmission";
            this.idTransmissionDataGridViewTextBoxColumn.HeaderText = "idTransmission";
            this.idTransmissionDataGridViewTextBoxColumn.Name = "idTransmissionDataGridViewTextBoxColumn";
            this.idTransmissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTransmissionDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPersonneDataGridViewTextBoxColumn1
            // 
            this.idPersonneDataGridViewTextBoxColumn1.DataPropertyName = "idPersonne";
            this.idPersonneDataGridViewTextBoxColumn1.DataSource = this.personnelBindingSource;
            this.idPersonneDataGridViewTextBoxColumn1.DisplayMember = "nom";
            this.idPersonneDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idPersonneDataGridViewTextBoxColumn1.HeaderText = "Infirmier";
            this.idPersonneDataGridViewTextBoxColumn1.Name = "idPersonneDataGridViewTextBoxColumn1";
            this.idPersonneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idPersonneDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idPersonneDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idPersonneDataGridViewTextBoxColumn1.ValueMember = "idPersonne";
            // 
            // idTraitementDataGridViewTextBoxColumn1
            // 
            this.idTraitementDataGridViewTextBoxColumn1.DataPropertyName = "idTraitement";
            this.idTraitementDataGridViewTextBoxColumn1.HeaderText = "idTraitement";
            this.idTraitementDataGridViewTextBoxColumn1.Name = "idTraitementDataGridViewTextBoxColumn1";
            this.idTraitementDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idTraitementDataGridViewTextBoxColumn1.Visible = false;
            // 
            // observationsDataGridViewTextBoxColumn
            // 
            this.observationsDataGridViewTextBoxColumn.DataPropertyName = "observations";
            this.observationsDataGridViewTextBoxColumn.HeaderText = "Observations";
            this.observationsDataGridViewTextBoxColumn.Name = "observationsDataGridViewTextBoxColumn";
            this.observationsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // problemesDataGridViewTextBoxColumn
            // 
            this.problemesDataGridViewTextBoxColumn.DataPropertyName = "problemes";
            this.problemesDataGridViewTextBoxColumn.HeaderText = "Problémes";
            this.problemesDataGridViewTextBoxColumn.Name = "problemesDataGridViewTextBoxColumn";
            this.problemesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionsDataGridViewTextBoxColumn
            // 
            this.actionsDataGridViewTextBoxColumn.DataPropertyName = "actions";
            this.actionsDataGridViewTextBoxColumn.HeaderText = "Actions";
            this.actionsDataGridViewTextBoxColumn.Name = "actionsDataGridViewTextBoxColumn";
            this.actionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTraitementDataGridViewTextBoxColumn
            // 
            this.dateTraitementDataGridViewTextBoxColumn.DataPropertyName = "dateTraitement";
            this.dateTraitementDataGridViewTextBoxColumn.HeaderText = "Date traitement";
            this.dateTraitementDataGridViewTextBoxColumn.Name = "dateTraitementDataGridViewTextBoxColumn";
            this.dateTraitementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 455);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrescription";
            this.Text = "FormPrescription";
            this.Load += new System.EventHandler(this.FormPrescription_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalisationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInfirmier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transmissionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTraitementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idHospitalisationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hospitalisationBindingSource;
        private DataInfirmier dataInfirmier;
        private System.Windows.Forms.DataGridViewComboBoxColumn idPersonneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn faitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traitementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheDeTransmissionsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idPersonneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTraitementDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTraitementDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transmissionBindingSource;
    }
}